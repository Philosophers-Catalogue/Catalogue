using Philosophers_Catalogue;
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

builder.Services.AddOpenApi();

builder.Services.AddNpgsql<PhilosophersCatalogueDbContext>(
    builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnection"), opt =>
        opt
            .UseNodaTime()
            .MapEnum<WorkTypes>()
            .MapEnum<InteractionType>()
            .MapEnum<ItemType>()
            .EnableRetryOnFailure());

builder.Services.AddIdentity<User, ApplicationRole>()
    .AddEntityFrameworkStores<PhilosophersCatalogueDbContext>();

builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
    .AddNegotiate();

builder.Services.AddQuartz(q =>
{
    var jobKey = new JobKey(nameof(WikipediaApiParser));
    q.AddJob<WikipediaApiParser>(opt => opt.WithIdentity(jobKey));

    q.AddTrigger(opt => opt
        .ForJob(jobKey)
        .WithSimpleSchedule(b => b
            .WithIntervalInHours(48)
            .RepeatForever()));
});

builder.Services.AddQuartzHostedService(opt => opt.WaitForJobsToComplete = true);

builder.Services.AddHttpClient<WikipediaApiParser>(opt =>
    opt.BaseAddress = new Uri(builder.Configuration.GetValue<string>("Wikipedia:BaseUrl") ?? string.Empty));

builder.Services.AddAuthorization(options => { options.FallbackPolicy = options.DefaultPolicy; });

var app = builder.Build();

await MigrateAsync();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();


await app.RunAsync();

app.SetDeveloperEndpoints();

return;

async Task MigrateAsync()
{
    using var scope = app.Services.CreateScope();
    await using var dbContext = scope.ServiceProvider.GetRequiredService<PhilosophersCatalogueDbContext>();
    await dbContext.Database.MigrateAsync();
}