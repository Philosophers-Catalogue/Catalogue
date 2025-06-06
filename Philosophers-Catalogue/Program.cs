using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Philosophers_Catalogue;
using Philosophers_Catalogue.Constants;
using Philosophers_Catalogue.Controllers;
using Philosophers_Catalogue.Models;
using Philosophers_Catalogue.Models.Enums;
using Quartz;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseDefaultServiceProvider(opt =>
{
    opt.ValidateOnBuild = true;
    opt.ValidateScopes = true;
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddOpenApi();

builder.Services.AddHttpContextAccessor();

builder.Services.AddNpgsql<PhilosophersCatalogueDbContext>(
    builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnection"), opt =>
        opt 
            .UseNodaTime()
            .MapEnum<WorkTypes>()
            .MapEnum<InteractionType>()
            .MapEnum<ItemType>()
            .EnableRetryOnFailure());

builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<PhilosophersCatalogueDbContext>();

builder.Services.AddQuartz(q =>
{
    var jobKey = new JobKey(nameof(WikipediaApiParser));
    q.AddJob<WikipediaApiParser>(opt => opt.WithIdentity(jobKey));

    q.AddTrigger(opt => opt
        .ForJob(jobKey)
        .StartAt(new DateTimeOffset(DateTime.MaxValue))
        .WithSimpleSchedule(b => b
            .WithIntervalInHours(128)
            .RepeatForever()));
});

builder.Services.AddCors(opt =>
    opt.AddDefaultPolicy(corsPolicyBuilder => corsPolicyBuilder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()));

builder.Services.AddQuartzHostedService(opt => opt.WaitForJobsToComplete = true);

builder.Services.AddHttpClient(WikipediaConstants.RuWikiClientName, opt =>
    {
        opt.BaseAddress = new Uri(builder.Configuration.GetValue<string>("Wikipedia:RuWikiBaseUrl") ?? string.Empty);
        opt.DefaultRequestHeaders.UserAgent.ParseAdd("Philosophers_Catalogue_Bot/1.0");
    }
);

builder.Services.AddHttpClient(WikipediaConstants.WikiDataClientName, opt =>
    {
        opt.BaseAddress = new Uri(builder.Configuration.GetValue<string>("Wikipedia:WikiDataBaseUrl") ?? string.Empty);
        opt.DefaultRequestHeaders.UserAgent.ParseAdd("Philosophers_Catalogue_Bot/1.0");
    }
);

var app = builder.Build();

await MigrateAsync();

if (app.Environment.IsDevelopment())
{   
    app.MapOpenApi();
    app.MapScalarApiReference();
    app.SetDeveloperEndpoints();
}

app.MapIdentityApi<User>();

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();

app.MapPost("/logout", async (SignInManager<IdentityUser> signInManager,
        [FromBody] object? empty) =>
    {
        if (empty == null)
            return Results.Unauthorized();

        await signInManager.SignOutAsync();

        return Results.Ok();

    })
    .WithOpenApi()
    .RequireAuthorization();

await app.RunAsync();

return;

async Task MigrateAsync()
{
    using var scope = app.Services.CreateScope();
    await using var dbContext = scope.ServiceProvider.GetRequiredService<PhilosophersCatalogueDbContext>();
    await dbContext.Database.MigrateAsync();
}