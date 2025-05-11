using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;
using Philosophers_Catalogue.Models.Enums;

#nullable disable

namespace Philosophers_Catalogue.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:interaction_type", "dislike,like,none,read_complete,read_start,save_for_later,view")
                .Annotation("Npgsql:Enum:item_type", "branch,category_school,not_specified,notion,philosopher,work")
                .Annotation("Npgsql:Enum:work_types", "book,collection,essay,interview,lecture,none,quotes,treatise");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WikipediaId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notions",
                columns: table => new
                {
                    NotionId = table.Column<Guid>(type: "uuid", nullable: false),
                    WikipediaId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notions", x => x.NotionId);
                });

            migrationBuilder.CreateTable(
                name: "Philosophers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WikipediaId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<LocalDate>(type: "date", nullable: false),
                    DeathDate = table.Column<LocalDate>(type: "date", nullable: false),
                    IsFemale = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Philosophers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemType = table.Column<ItemType>(type: "item_type", nullable: false),
                    InteractionType = table.Column<InteractionType>(type: "interaction_type", nullable: false),
                    RatingValue = table.Column<short>(type: "smallint", nullable: true),
                    InteractionTimestamp = table.Column<Instant>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interaction_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategorySchools",
                columns: table => new
                {
                    CategorySchoolId = table.Column<Guid>(type: "uuid", nullable: false),
                    WikipediaId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ParentCategorySchoolId = table.Column<Guid>(type: "uuid", nullable: true),
                    BranchId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySchools", x => x.CategorySchoolId);
                    table.ForeignKey(
                        name: "FK_CategorySchools_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySchools_CategorySchools_ParentCategorySchoolId",
                        column: x => x.ParentCategorySchoolId,
                        principalTable: "CategorySchools",
                        principalColumn: "CategorySchoolId");
                });

            migrationBuilder.CreateTable(
                name: "RelatedNotion",
                columns: table => new
                {
                    NotionIdFrom = table.Column<Guid>(type: "uuid", nullable: false),
                    NotionIdTo = table.Column<Guid>(type: "uuid", nullable: false),
                    RelationshipType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedNotion", x => new { x.NotionIdFrom, x.NotionIdTo });
                    table.ForeignKey(
                        name: "FK_RelatedNotion_Notions_NotionIdFrom",
                        column: x => x.NotionIdFrom,
                        principalTable: "Notions",
                        principalColumn: "NotionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelatedNotion_Notions_NotionIdTo",
                        column: x => x.NotionIdTo,
                        principalTable: "Notions",
                        principalColumn: "NotionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WikipediaId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PublicationYear = table.Column<int>(type: "integer", nullable: true),
                    PrimaryAuthorId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExternalUrl = table.Column<string>(type: "text", nullable: true),
                    Embeddings = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "russian")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" }),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    Type = table.Column<WorkTypes>(type: "work_types", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_Philosophers_PrimaryAuthorId",
                        column: x => x.PrimaryAuthorId,
                        principalTable: "Philosophers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategorySchoolNotion",
                columns: table => new
                {
                    CategoriesSchoolsCategorySchoolId = table.Column<Guid>(type: "uuid", nullable: false),
                    NotionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySchoolNotion", x => new { x.CategoriesSchoolsCategorySchoolId, x.NotionId });
                    table.ForeignKey(
                        name: "FK_CategorySchoolNotion_CategorySchools_CategoriesSchoolsCateg~",
                        column: x => x.CategoriesSchoolsCategorySchoolId,
                        principalTable: "CategorySchools",
                        principalColumn: "CategorySchoolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySchoolNotion_Notions_NotionId",
                        column: x => x.NotionId,
                        principalTable: "Notions",
                        principalColumn: "NotionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategorySchoolPhilosopher",
                columns: table => new
                {
                    CategorySchoolsCategorySchoolId = table.Column<Guid>(type: "uuid", nullable: false),
                    PhilosopherId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySchoolPhilosopher", x => new { x.CategorySchoolsCategorySchoolId, x.PhilosopherId });
                    table.ForeignKey(
                        name: "FK_CategorySchoolPhilosopher_CategorySchools_CategorySchoolsCa~",
                        column: x => x.CategorySchoolsCategorySchoolId,
                        principalTable: "CategorySchools",
                        principalColumn: "CategorySchoolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySchoolPhilosopher_Philosophers_PhilosopherId",
                        column: x => x.PhilosopherId,
                        principalTable: "Philosophers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategorySchoolWork",
                columns: table => new
                {
                    CategoriesSchoolsCategorySchoolId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySchoolWork", x => new { x.CategoriesSchoolsCategorySchoolId, x.WorkId });
                    table.ForeignKey(
                        name: "FK_CategorySchoolWork_CategorySchools_CategoriesSchoolsCategor~",
                        column: x => x.CategoriesSchoolsCategorySchoolId,
                        principalTable: "CategorySchools",
                        principalColumn: "CategorySchoolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySchoolWork_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotionWork",
                columns: table => new
                {
                    NotionsNotionId = table.Column<Guid>(type: "uuid", nullable: false),
                    RelatedItemsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotionWork", x => new { x.NotionsNotionId, x.RelatedItemsId });
                    table.ForeignKey(
                        name: "FK_NotionWork_Notions_NotionsNotionId",
                        column: x => x.NotionsNotionId,
                        principalTable: "Notions",
                        principalColumn: "NotionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotionWork_Works_RelatedItemsId",
                        column: x => x.RelatedItemsId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchoolNotion_NotionId",
                table: "CategorySchoolNotion",
                column: "NotionId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchoolPhilosopher_PhilosopherId",
                table: "CategorySchoolPhilosopher",
                column: "PhilosopherId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchools_BranchId",
                table: "CategorySchools",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchools_Name",
                table: "CategorySchools",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchools_ParentCategorySchoolId",
                table: "CategorySchools",
                column: "ParentCategorySchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchoolWork_WorkId",
                table: "CategorySchoolWork",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Interaction_InteractionTimestamp",
                table: "Interaction",
                column: "InteractionTimestamp");

            migrationBuilder.CreateIndex(
                name: "IX_Interaction_ItemId",
                table: "Interaction",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Interaction_ItemType",
                table: "Interaction",
                column: "ItemType");

            migrationBuilder.CreateIndex(
                name: "IX_Interaction_UserId",
                table: "Interaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotionWork_RelatedItemsId",
                table: "NotionWork",
                column: "RelatedItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Philosophers_Name",
                table: "Philosophers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RelatedNotion_NotionIdTo",
                table: "RelatedNotion",
                column: "NotionIdTo");

            migrationBuilder.CreateIndex(
                name: "IX_Works_Embeddings",
                table: "Works",
                column: "Embeddings")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Works_PrimaryAuthorId",
                table: "Works",
                column: "PrimaryAuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategorySchoolNotion");

            migrationBuilder.DropTable(
                name: "CategorySchoolPhilosopher");

            migrationBuilder.DropTable(
                name: "CategorySchoolWork");

            migrationBuilder.DropTable(
                name: "Interaction");

            migrationBuilder.DropTable(
                name: "NotionWork");

            migrationBuilder.DropTable(
                name: "RelatedNotion");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CategorySchools");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Notions");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Philosophers");
        }
    }
}
