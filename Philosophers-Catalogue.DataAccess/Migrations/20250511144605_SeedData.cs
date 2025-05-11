using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Philosophers_Catalogue.Models.Enums;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Philosophers_Catalogue.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolNotion_CategorySchools_CategoriesSchoolsCateg~",
                table: "CategorySchoolNotion");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolNotion_Notions_NotionId",
                table: "CategorySchoolNotion");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolPhilosopher_Philosophers_PhilosopherId",
                table: "CategorySchoolPhilosopher");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolWork_CategorySchools_CategoriesSchoolsCategor~",
                table: "CategorySchoolWork");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolWork_Works_WorkId",
                table: "CategorySchoolWork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorySchoolPhilosopher",
                table: "CategorySchoolPhilosopher");

            migrationBuilder.DropIndex(
                name: "IX_CategorySchoolPhilosopher_PhilosopherId",
                table: "CategorySchoolPhilosopher");

            migrationBuilder.RenameColumn(
                name: "WorkId",
                table: "CategorySchoolWork",
                newName: "CategorySchoolsCategorySchoolId");

            migrationBuilder.RenameColumn(
                name: "CategoriesSchoolsCategorySchoolId",
                table: "CategorySchoolWork",
                newName: "WorksId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySchoolWork_WorkId",
                table: "CategorySchoolWork",
                newName: "IX_CategorySchoolWork_CategorySchoolsCategorySchoolId");

            migrationBuilder.RenameColumn(
                name: "PhilosopherId",
                table: "CategorySchoolPhilosopher",
                newName: "PhilosophersId");

            migrationBuilder.RenameColumn(
                name: "NotionId",
                table: "CategorySchoolNotion",
                newName: "CategorySchoolsCategorySchoolId");

            migrationBuilder.RenameColumn(
                name: "CategoriesSchoolsCategorySchoolId",
                table: "CategorySchoolNotion",
                newName: "NotionsNotionId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySchoolNotion_NotionId",
                table: "CategorySchoolNotion",
                newName: "IX_CategorySchoolNotion_CategorySchoolsCategorySchoolId");

            migrationBuilder.DropColumn(
                name: "DeathDate",
                table: "Philosophers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Philosophers");

            migrationBuilder.AddColumn<int>(
                name: "DeathDate",
                table: "Philosophers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BirthDate",
                table: "Philosophers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorySchoolPhilosopher",
                table: "CategorySchoolPhilosopher",
                columns: new[] { "PhilosophersId", "CategorySchoolsCategorySchoolId" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Description", "Name", "WikipediaId" },
                values: new object[,]
                {
                    { new Guid("73a1b7a9-9be5-4eb2-a5bc-b703b4e3c2e5"), "Moral philosophy, involves systematizing, defending, and recommending concepts of right and wrong conduct.", "Этика", null },
                    { new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"), "Theory of knowledge, especially with regard to its methods, validity, and scope.", "Эпистемология", null },
                    { new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), "Branch of philosophy that examines the fundamental nature of reality, including the relationship between mind and matter, substance and attribute, potentiality and actuality.", "Метафизика", null },
                    { new Guid("a19db7ce-cf0c-4dc1-bf2a-ec4f192d1240"), "Philosophical study of beauty and taste.", "Эстетика", null },
                    { new Guid("d4623a52-4e63-42e6-b8a3-8750ad264f7c"), "Study of reasoning and argument.", "Логика", null }
                });

            migrationBuilder.InsertData(
                table: "Notions",
                columns: new[] { "NotionId", "CreatedAt", "Description", "Name", "UpdatedAt", "WikipediaId" },
                values: new object[,]
                {
                    { new Guid("0055f212-4e67-4aa5-a1a3-3f7c05d2125f"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "In Husserl's phenomenology, the object or content of a thought, judgment, or perception, but as it is meant or intended in that thought.", "Ноэма (Noema)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 314 },
                    { new Guid("103d2dcf-1cfc-4b77-86b0-202f38ff702e"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A concept in psychology, existentialist philosophy and aesthetics concerning the degree to which an individual's actions are congruent with their beliefs and desires, despite external pressures.", "Аутентичность (Authenticity)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 310 },
                    { new Guid("169ae31e-4083-4a0f-8ea0-06ccf1e2f502"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "In Leibniz's philosophy, an elementary individual substance that reflects the universe from a specific viewpoint and is subject to its own internal laws of development.", "Монада (Monad)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 313 },
                    { new Guid("3cf7e7fd-fb56-42b9-bd2e-8c0bb0f2a057"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Locke's theory that individuals are born without built-in mental content and that therefore all knowledge comes from experience or perception.", "Чистая доска (Tabula Rasa)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 305 },
                    { new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Heidegger's term for 'being-there' or 'presence', referring to the human way of being.", "Дазайн (Dasein)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 304 },
                    { new Guid("72e3c381-693e-46ae-b6d4-c74ed0e03f30"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A spiritual community of many jointly living people, a key concept in Russian religious philosophy.", "Соборность (Sobornost)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 315 },
                    { new Guid("8261284d-1b86-432f-bd91-b6c5d8f9f191"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Kant's central philosophical concept in his deontological moral philosophy.", "Категорический императив (Categorical Imperative)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 302 },
                    { new Guid("8adac4c3-007b-48f4-b76f-4b02128255c8"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A condition in social relationships reflected by a low degree of integration or common values and a high degree of distance or isolation between individuals, or between an individual and a group of people in a community or work environment.", "Отчуждение (Alienation)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 309 },
                    { new Guid("b624a80b-2594-4f57-b300-35dfd470087e"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Plato's theory that the physical world is not as real or true as timeless, absolute, unchangeable ideas.", "Теория форм (Theory of Forms)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 301 },
                    { new Guid("c94fe294-924e-4d2d-9c5c-8c423924f01e"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "In philosophy, an irresolvable internal contradiction or logical disjunction in a text, argument, or theory.", "Апория (Aporia)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 311 },
                    { new Guid("d18cc7a7-d229-4c5a-8ea1-b47a4e71c6a4"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A theory or model that originated during the Age of Enlightenment and usually concerns the legitimacy of the authority of the state over the individual.", "Общественный договор (Social Contract)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 307 },
                    { new Guid("db90ef98-0a7e-4e7e-b730-9981e407d31d"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Descartes' famous philosophical proposition: 'I think, therefore I am'.", "Мыслю, следовательно, существую (Cogito, ergo sum)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 306 },
                    { new Guid("e403af49-1a31-4dd9-984e-43b1dce3b43f"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Nietzsche's concept of a goal for humanity to set for itself.", "Сверхчеловек (Übermensch)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 303 },
                    { new Guid("f5ce7bd6-3802-45ae-875b-24b729c42f15"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A kind of logical argument that applies deductive reasoning to arrive at a conclusion based on two or more propositions that are asserted or assumed to be true.", "Силлогизм (Syllogism)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 312 },
                    { new Guid("f933e7d4-478f-442f-a1a5-8e2e0424375f"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A prominent concept in the philosophy of Friedrich Nietzsche, describing what he believed to be the main driving force in humans.", "Воля к власти (Will to Power)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 308 }
                });

            migrationBuilder.InsertData(
                table: "Philosophers",
                columns: new[] { "Id", "Bio", "BirthDate", "CreatedAt", "DeathDate", "IsFemale", "Name", "UpdatedAt", "WikipediaId" },
                values: new object[,]
                {
                    { new Guid("008d29a5-5f43-4a7a-a425-726279154c08"), "French philosopher, mathematician, and scientist. Dubbed the father of modern western philosophy.", 1596, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1650, false, "Рене Декарт (René Descartes)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 7 },
                    { new Guid("06f2387c-b659-4ff7-8a10-161ec964c27d"), "Danish philosopher, theologian, poet, social critic and religious author who is widely considered to be the first existentialist philosopher.", 1813, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1855, false, "Сёрен Кьеркегор (Søren Kierkegaard)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 12 },
                    { new Guid("25579215-4d3e-4205-981a-27ef7083a83c"), "French philosopher, historian of ideas, writer, political activist, and literary critic. Foucault's theories primarily address the relationship between power and knowledge, and how they are used as a form of social control through societal institutions.", 1926, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1984, false, "Мишель Фуко (Michel Foucault)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 20 },
                    { new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77"), "Russian philosopher, philologist and culturologist, one of the most prominent figures in Russian philosophical and religious thought of the 20th century.", 1893, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1988, false, "Алексей Лосев (Aleksei Losev)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 18 },
                    { new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f"), "Russian existentialist philosopher, known for his 'philosophy of despair' and his critique of rationalism.", 1866, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1938, false, "Лев Шестов (Lev Shestov)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 17 },
                    { new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278"), "Russian political and Christian existentialist philosopher who emphasized the existential spiritual significance of human freedom and the human person.", 1874, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1948, false, "Николай Бердяев (Nikolai Berdyaev)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 16 },
                    { new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b"), "French writer, intellectual, existentialist philosopher, political activist, feminist, and social theorist.", 1908, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1986, true, "Симона де Бовуар (Simone de Beauvoir)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 6 },
                    { new Guid("83cf4059-5701-417e-b508-f3cd23a27b6c"), "German philosopher. Best known for his 1818 work The World as Will and Representation.", 1788, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1860, false, "Артур Шопенгауэр (Arthur Schopenhauer)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 11 },
                    { new Guid("9a1d2ebc-bd4b-4380-a665-9f28a2304dc3"), "Russian philosopher, literary critic and scholar who worked on literary theory, ethics, and the philosophy of language.", 1895, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1975, false, "Михаил Бахтин (Mikhail Bakhtin)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 14 },
                    { new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1"), "Austrian-British philosopher who worked primarily in logic, the philosophy of mathematics, the philosophy of mind, and the philosophy of language.", 1889, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1951, false, "Людвиг Витгенштейн (Ludwig Wittgenstein)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 13 },
                    { new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0"), "Ancient Greek philosopher, founder of the Platonist school of thought and the Academy.", -428, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), -348, false, "Платон (Plato)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1 },
                    { new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d"), "German philosopher, a central figure in modern philosophy. Argued that the human understanding is the source of the general laws of nature that structure all our experience.", 1724, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1804, false, "Иммануил Кант (Immanuel Kant)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 3 },
                    { new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5"), "Ancient Greek philosopher and scientist. His writings cover many subjects including physics, biology, zoology, metaphysics, logic, ethics, aesthetics, poetry, theatre, music, rhetoric, psychology, linguistics, economics, politics, and government.", -384, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), -322, false, "Аристотель (Aristotle)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 2 },
                    { new Guid("d249f9e2-bb3c-4e30-8611-7b573bfa1a97"), "German philosopher, cultural critic, composer, poet, writer, and philologist whose work has exerted a profound influence on modern intellectual history.", 1844, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1900, false, "Фридрих Ницше (Friedrich Nietzsche)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 4 },
                    { new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e"), "Russian philosopher, theologian, poet, pamphleteer, and literary critic. He played a significant role in the development of Russian philosophy and poetry at the end of the 19th century and in the spiritual renaissance of the early 20th century.", 1853, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1900, false, "Владимир Соловьёв (Vladimir Solovyov)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 15 },
                    { new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3"), "Dutch philosopher of Portuguese Sephardi origin. One of the early thinkers of the Enlightenment and modern biblical criticism, including modern conceptions of the self and the universe.", 1632, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1677, false, "Бенедикт Спиноза (Baruch Spinoza)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 10 },
                    { new Guid("e93bb57f-c81d-4a4f-b5ae-fbcb3493c0e7"), "German-born American political theorist. Her work deals with the nature of power, and the subjects of politics, direct democracy, authority, and totalitarianism.", 1906, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1975, true, "Ханна Арендт (Hannah Arendt)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 19 },
                    { new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0"), "French philosopher, playwright, novelist, screenwriter, political activist, biographer, and literary critic. He was one of the key figures in the philosophy of existentialism and phenomenology.", 1905, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1980, false, "Жан-Поль Сартр (Jean-Paul Sartre)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 5 },
                    { new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e"), "English philosopher and physician, widely regarded as one of the most influential of Enlightenment thinkers and commonly known as the 'Father of Liberalism'.", 1632, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1704, false, "Джон Локк (John Locke)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 8 },
                    { new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2"), "Scottish Enlightenment philosopher, historian, economist, and essayist, who is best known today for his highly influential system of philosophical empiricism, skepticism, and naturalism.", 1711, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 1776, false, "Дэвид Юм (David Hume)", NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 9 }
                });

            migrationBuilder.InsertData(
                table: "CategorySchools",
                columns: new[] { "CategorySchoolId", "BranchId", "CreatedAt", "Description", "Name", "ParentCategorySchoolId", "UpdatedAt", "WikipediaId" },
                values: new object[,]
                {
                    { new Guid("14b3c490-6d37-4c8f-b0a2-d2e1e7d8ea64"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A method of critical thought which dominated teaching by the academics (scholastics, or schoolmen) of medieval universities in Europe from about 1100 to 1700.", "Схоластика (Scholasticism)", null, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 218 },
                    { new Guid("8128a0e4-6c1b-49a2-9b11-2f1930a9ecdc"), new Guid("d4623a52-4e63-42e6-b8a3-8750ad264f7c"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A tradition of philosophy characterized by an emphasis on clarity, argument, and formal logic.", "Аналитическая философия (Analytic Philosophy)", null, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 217 },
                    { new Guid("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2"), new Guid("73a1b7a9-9be5-4eb2-a5bc-b703b4e3c2e5"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A range of socio-political movements and ideologies that aim to define and establish the political, economic, personal, and social equality of the sexes.", "Феминизм (Feminism)", null, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 205 },
                    { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A distinctive school of thought that emerged in Russia in the 19th and early 20th centuries.", "Русская религиозная философия (Russian Religious Philosophy)", null, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 212 },
                    { new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Philosophy in Ancient Greece, from the 6th century BC to the Hellenistic period.", "Древнегреческая философия (Ancient Greek Philosophy)", null, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 214 },
                    { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A set of traditions of 19th and 20th-century philosophy from mainland Europe.", "Континентальная философия (Continental Philosophy)", null, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 216 },
                    { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Philosophy developed in the Western world during the early modern period (roughly 17th to 19th centuries).", "Философия Нового времени (Modern Philosophy)", null, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 215 },
                    { new Guid("f1cb027b-7f7e-4645-8668-b1526fdb7c86"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "The belief that reality exists independently of observers.", "Реализм (Realism)", null, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 220 }
                });

            migrationBuilder.InsertData(
                table: "RelatedNotion",
                columns: new[] { "NotionIdFrom", "NotionIdTo", "RelationshipType" },
                values: new object[,]
                {
                    { new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3"), new Guid("103d2dcf-1cfc-4b77-86b0-202f38ff702e"), "RelatedConcept" },
                    { new Guid("e403af49-1a31-4dd9-984e-43b1dce3b43f"), new Guid("f933e7d4-478f-442f-a1a5-8e2e0424375f"), "RelatedConcept" }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "CreatedAt", "Description", "ExternalUrl", "Name", "PrimaryAuthorId", "PublicationYear", "Type", "UpdatedAt", "WikipediaId" },
                values: new object[,]
                {
                    { new Guid("14a7d015-2ea1-4917-a67d-79050a8c2284"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A major work by Hannah Arendt discussing the vita activa (active life) in contrast to the vita contemplativa (contemplative life).", null, "Vita activa, или О деятельной жизни (The Human Condition)", new Guid("e93bb57f-c81d-4a4f-b5ae-fbcb3493c0e7"), 1958, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 119 },
                    { new Guid("2e994d2d-e383-470f-91c6-59ccbb4e5864"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A work concerning the foundation of human knowledge and understanding.", null, "Опыт о человеческом разумении (An Essay Concerning Human Understanding)", new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e"), 1689, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 108 },
                    { new Guid("34f19353-1d4f-4e3b-91e1-4e83b23e7b5c"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A major work of literary theory and analysis by Mikhail Bakhtin.", null, "Проблемы поэтики Достоевского (Problems of Dostoevsky's Poetics)", new Guid("9a1d2ebc-bd4b-4380-a665-9f28a2304dc3"), 1929, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 114 },
                    { new Guid("34f3e2e3-1639-4d68-b30c-7e25cf5bb158"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A philosophical novel exploring ideas like the 'death of God', the Übermensch, and the will to power.", null, "Так говорил Заратустра (Thus Spoke Zarathustra)", new Guid("d249f9e2-bb3c-4e30-8611-7b573bfa1a97"), 1883, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 104 },
                    { new Guid("3eb03c5e-d5a6-4704-833a-c7d41d223089"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Socratic dialogue concerning justice, the order and character of the just city-state, and the just man.", null, "Государство (The Republic)", new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0"), -375, WorkTypes.Interview, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 101 },
                    { new Guid("3f1b9e6a-39f1-4f33-9ea5-7b6a68a9e267"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "An analysis of the social and theoretical mechanisms behind the changes in Western penal systems during the modern age.", null, "Надзирать и наказывать (Discipline and Punish: The Birth of the Prison)", new Guid("25579215-4d3e-4205-981a-27ef7083a83c"), 1975, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 120 },
                    { new Guid("5c369d59-f8c4-40f0-9a41-d13015d3c3a6"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A key work by Aleksei Losev on the nature of myth and its relation to consciousness and reality.", null, "Диалектика мифа (The Dialectic of Myth)", new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77"), 1930, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 118 },
                    { new Guid("67a2c986-cb52-4cb1-8495-d98994db7ccf"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A book by Scottish philosopher David Hume, considered by many to be Hume's most important work and one of the most influential works in the history of philosophy.", null, "Трактат о человеческой природе (A Treatise of Human Nature)", new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2"), 1739, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 109 },
                    { new Guid("6ff8c3b7-e212-4a2d-b3f0-399b1c81350f"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "An essay on phenomenological ontology, considered a foundational text of existentialism.", null, "Бытие и ничто (Being and Nothingness)", new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0"), 1943, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 105 },
                    { new Guid("7ff2f8e7-e5f2-4ab0-ae2a-1801248f1ad3"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A philosophical work by Søren Kierkegaard, published in 1843 under the pseudonym Johannes de silentio.", null, "Страх и трепет (Fear and Trembling)", new Guid("06f2387c-b659-4ff7-8a10-161ec964c27d"), 1843, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 112 },
                    { new Guid("86b5e3f1-5b32-42f1-94b3-948c0623727e"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Aristotle's best-known work on ethics, the science of the good for human life.", null, "Никомахова этика (Nicomachean Ethics)", new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5"), -340, WorkTypes.Treatise, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 102 },
                    { new Guid("914d6b7c-3e4e-42a7-a8b4-33815a239764"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "The only book-length philosophical work by the Austrian philosopher Ludwig Wittgenstein that was published during his lifetime.", null, "Логико-философский трактат (Tractatus Logico-Philosophicus)", new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1"), 1921, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 113 },
                    { new Guid("985f8a06-b109-4a38-a4a5-b6d62a2d9e37"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "The central work of the German philosopher Arthur Schopenhauer.", null, "Мир как воля и представление (The World as Will and Representation)", new Guid("83cf4059-5701-417e-b508-f3cd23a27b6c"), 1818, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 111 },
                    { new Guid("a58f52a0-44c2-41bc-8928-29a99cf5d4cf"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A series of lectures outlining Solovyov's sophiology and concept of Godmanhood.", null, "Чтения о богочеловечестве (Lectures on Godmanhood)", new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e"), 1881, WorkTypes.Lecture, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 115 },
                    { new Guid("c6a32d79-d78c-4b5e-90aa-1a680d7fc130"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Explores the nature of human reason and its limits.", null, "Критика чистого разума (Critique of Pure Reason)", new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d"), 1781, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 103 },
                    { new Guid("d113c8d7-72b6-4bde-99ff-90aa9fa8c8f0"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Spinoza's magnum opus, a philosophical treatise written in Latin.", null, "Этика (Ethics, Demonstrated in Geometrical Order)", new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3"), 1677, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 110 },
                    { new Guid("e1ed7dd5-86d6-4c5d-8594-46e59aab6b8c"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A philosophical work contrasting Greek rationalism with Hebraic revelation.", null, "Афины и Иерусалим (Athens and Jerusalem)", new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f"), 1938, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 117 },
                    { new Guid("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A detailed analysis of women's oppression and a foundational tract of contemporary feminism.", null, "Второй пол (The Second Sex)", new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b"), 1949, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 106 },
                    { new Guid("fa5c4237-62b7-4fe9-bc29-e0498d7f5488"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "An essay on the philosophy of history by Nikolai Berdyaev.", null, "Смысл истории (The Meaning of History)", new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278"), 1923, WorkTypes.Essay, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 116 },
                    { new Guid("fcd0984e-3e80-4993-8e28-32bd843b1059"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A foundational text of modern philosophy, exploring epistemological certainty.", null, "Размышления о первой философии (Meditations on First Philosophy)", new Guid("008d29a5-5f43-4a7a-a425-726279154c08"), 1641, WorkTypes.Book, NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 107 }
                });

            migrationBuilder.InsertData(
                table: "CategorySchoolNotion",
                columns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                values: new object[] { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("72e3c381-693e-46ae-b6d4-c74ed0e03f30") });

            migrationBuilder.InsertData(
                table: "CategorySchoolPhilosopher",
                columns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                values: new object[,]
                {
                    { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("008d29a5-5f43-4a7a-a425-726279154c08") },
                    { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("25579215-4d3e-4205-981a-27ef7083a83c") },
                    { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77") },
                    { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f") },
                    { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278") },
                    { new Guid("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2"), new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b") },
                    { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b") },
                    { new Guid("8128a0e4-6c1b-49a2-9b11-2f1930a9ecdc"), new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1") },
                    { new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0") },
                    { new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5") },
                    { new Guid("f1cb027b-7f7e-4645-8668-b1526fdb7c86"), new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5") },
                    { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e") },
                    { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3") },
                    { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("e93bb57f-c81d-4a4f-b5ae-fbcb3493c0e7") },
                    { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0") },
                    { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e") },
                    { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2") }
                });

            migrationBuilder.InsertData(
                table: "CategorySchoolWork",
                columns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                values: new object[,]
                {
                    { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("34f19353-1d4f-4e3b-91e1-4e83b23e7b5c") },
                    { new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), new Guid("3eb03c5e-d5a6-4704-833a-c7d41d223089") },
                    { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("a58f52a0-44c2-41bc-8928-29a99cf5d4cf") },
                    { new Guid("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2"), new Guid("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862") }
                });

            migrationBuilder.InsertData(
                table: "CategorySchools",
                columns: new[] { "CategorySchoolId", "BranchId", "CreatedAt", "Description", "Name", "ParentCategorySchoolId", "UpdatedAt", "WikipediaId" },
                values: new object[,]
                {
                    { new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A philosophical movement that emerged in Germany in the late 18th and early 19th centuries.", "Немецкий идеализм (German Idealism)", new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 209 },
                    { new Guid("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A tradition of philosophy that takes its defining inspiration from the work of Aristotle.", "Аристотелизм (Aristotelianism)", new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 202 },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("73a1b7a9-9be5-4eb2-a5bc-b703b4e3c2e5"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A form of philosophical inquiry that explores the problem of human existence and centers on the lived experience of the thinking, feeling, acting individual.", "Экзистенциализм (Existentialism)", new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 204 },
                    { new Guid("84250e5a-f4e3-4d08-975f-fb68e879eae5"), new Guid("d4623a52-4e63-42e6-b8a3-8750ad264f7c"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A movement in Western philosophy whose central thesis was the verification principle.", "Логический позитивизм (Logical Positivism)", new Guid("8128a0e4-6c1b-49a2-9b11-2f1930a9ecdc"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 211 },
                    { new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "The philosophy of Plato and philosophical systems closely derived from it.", "Платонизм (Platonism)", new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 201 },
                    { new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"), new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A theory that states that knowledge comes only or primarily from sensory experience.", "Эмпиризм (Empiricism)", new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 207 },
                    { new Guid("ca9983b1-b143-4d0b-b6b7-5ed003efef59"), new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "The study of structures of consciousness as experienced from the first-person point of view.", "Феноменология (Phenomenology)", new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 210 },
                    { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A view appealing to reason as a source of knowledge or justification.", "Рационализм (Rationalism)", new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 206 },
                    { new Guid("f353cd4d-396e-4bd9-bb29-08a8c2fd3907"), new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A term for philosophical and literary forms of theory that both build upon and reject ideas established by structuralism.", "Постструктурализм (Post-structuralism)", new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 213 },
                    { new Guid("f8b35129-0e8c-4911-a8fd-b059cc41cf1f"), new Guid("73a1b7a9-9be5-4eb2-a5bc-b703b4e3c2e5"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "A school of Hellenistic philosophy founded by Zeno of Citium in Athens in the early 3rd century BC.", "Стоицизм (Stoicism)", new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 208 }
                });

            migrationBuilder.InsertData(
                table: "CategorySchoolNotion",
                columns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                values: new object[,]
                {
                    { new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"), new Guid("3cf7e7fd-fb56-42b9-bd2e-8c0bb0f2a057") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3") },
                    { new Guid("ca9983b1-b143-4d0b-b6b7-5ed003efef59"), new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3") },
                    { new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"), new Guid("b624a80b-2594-4f57-b300-35dfd470087e") },
                    { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("db90ef98-0a7e-4e7e-b730-9981e407d31d") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("e403af49-1a31-4dd9-984e-43b1dce3b43f") }
                });

            migrationBuilder.InsertData(
                table: "CategorySchoolPhilosopher",
                columns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                values: new object[,]
                {
                    { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("008d29a5-5f43-4a7a-a425-726279154c08") },
                    { new Guid("f353cd4d-396e-4bd9-bb29-08a8c2fd3907"), new Guid("25579215-4d3e-4205-981a-27ef7083a83c") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b") },
                    { new Guid("84250e5a-f4e3-4d08-975f-fb68e879eae5"), new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1") },
                    { new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"), new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0") },
                    { new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"), new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d") },
                    { new Guid("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb"), new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("d249f9e2-bb3c-4e30-8611-7b573bfa1a97") },
                    { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0") },
                    { new Guid("ca9983b1-b143-4d0b-b6b7-5ed003efef59"), new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0") },
                    { new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"), new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e") },
                    { new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"), new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2") }
                });

            migrationBuilder.InsertData(
                table: "CategorySchoolWork",
                columns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                values: new object[,]
                {
                    { new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"), new Guid("3eb03c5e-d5a6-4704-833a-c7d41d223089") },
                    { new Guid("f353cd4d-396e-4bd9-bb29-08a8c2fd3907"), new Guid("3f1b9e6a-39f1-4f33-9ea5-7b6a68a9e267") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("6ff8c3b7-e212-4a2d-b3f0-399b1c81350f") },
                    { new Guid("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb"), new Guid("86b5e3f1-5b32-42f1-94b3-948c0623727e") },
                    { new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"), new Guid("c6a32d79-d78c-4b5e-90aa-1a680d7fc130") },
                    { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862") },
                    { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("fcd0984e-3e80-4993-8e28-32bd843b1059") }
                });

            migrationBuilder.InsertData(
                table: "CategorySchools",
                columns: new[] { "CategorySchoolId", "BranchId", "CreatedAt", "Description", "Name", "ParentCategorySchoolId", "UpdatedAt", "WikipediaId" },
                values: new object[,]
                {
                    { new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"), new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "Philosophy of Immanuel Kant, a German philosopher.", "Кантианство (Kantianism)", new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 203 },
                    { new Guid("5a4b54cb-36b7-4f9e-a028-3347d7c38de0"), new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), "The group of metaphysical philosophies that assert that reality, or reality as humans can know it, is fundamentally mental, mentally constructed, or otherwise immaterial.", "Идеализм (Idealism)", new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"), NodaTime.Instant.FromUnixTimeTicks(17356896000000000L), 219 }
                });

            migrationBuilder.InsertData(
                table: "CategorySchoolNotion",
                columns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                values: new object[] { new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"), new Guid("8261284d-1b86-432f-bd91-b6c5d8f9f191") });

            migrationBuilder.InsertData(
                table: "CategorySchoolPhilosopher",
                columns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                values: new object[,]
                {
                    { new Guid("5a4b54cb-36b7-4f9e-a028-3347d7c38de0"), new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77") },
                    { new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"), new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d") },
                    { new Guid("5a4b54cb-36b7-4f9e-a028-3347d7c38de0"), new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e") }
                });

            migrationBuilder.InsertData(
                table: "CategorySchoolWork",
                columns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                values: new object[] { new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"), new Guid("c6a32d79-d78c-4b5e-90aa-1a680d7fc130") });

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchoolPhilosopher_CategorySchoolsCategorySchoolId",
                table: "CategorySchoolPhilosopher",
                column: "CategorySchoolsCategorySchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolNotion_CategorySchools_CategorySchoolsCategor~",
                table: "CategorySchoolNotion",
                column: "CategorySchoolsCategorySchoolId",
                principalTable: "CategorySchools",
                principalColumn: "CategorySchoolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolNotion_Notions_NotionsNotionId",
                table: "CategorySchoolNotion",
                column: "NotionsNotionId",
                principalTable: "Notions",
                principalColumn: "NotionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolPhilosopher_Philosophers_PhilosophersId",
                table: "CategorySchoolPhilosopher",
                column: "PhilosophersId",
                principalTable: "Philosophers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolWork_CategorySchools_CategorySchoolsCategoryS~",
                table: "CategorySchoolWork",
                column: "CategorySchoolsCategorySchoolId",
                principalTable: "CategorySchools",
                principalColumn: "CategorySchoolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolWork_Works_WorksId",
                table: "CategorySchoolWork",
                column: "WorksId",
                principalTable: "Works",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolNotion_CategorySchools_CategorySchoolsCategor~",
                table: "CategorySchoolNotion");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolNotion_Notions_NotionsNotionId",
                table: "CategorySchoolNotion");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolPhilosopher_Philosophers_PhilosophersId",
                table: "CategorySchoolPhilosopher");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolWork_CategorySchools_CategorySchoolsCategoryS~",
                table: "CategorySchoolWork");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySchoolWork_Works_WorksId",
                table: "CategorySchoolWork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorySchoolPhilosopher",
                table: "CategorySchoolPhilosopher");

            migrationBuilder.DropIndex(
                name: "IX_CategorySchoolPhilosopher_CategorySchoolsCategorySchoolId",
                table: "CategorySchoolPhilosopher");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("a19db7ce-cf0c-4dc1-bf2a-ec4f192d1240"));

            migrationBuilder.DeleteData(
                table: "CategorySchoolNotion",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                keyValues: new object[] { new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"), new Guid("3cf7e7fd-fb56-42b9-bd2e-8c0bb0f2a057") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolNotion",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolNotion",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                keyValues: new object[] { new Guid("ca9983b1-b143-4d0b-b6b7-5ed003efef59"), new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolNotion",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                keyValues: new object[] { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("72e3c381-693e-46ae-b6d4-c74ed0e03f30") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolNotion",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                keyValues: new object[] { new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"), new Guid("8261284d-1b86-432f-bd91-b6c5d8f9f191") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolNotion",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                keyValues: new object[] { new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"), new Guid("b624a80b-2594-4f57-b300-35dfd470087e") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolNotion",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                keyValues: new object[] { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("db90ef98-0a7e-4e7e-b730-9981e407d31d") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolNotion",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "NotionsNotionId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("e403af49-1a31-4dd9-984e-43b1dce3b43f") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("008d29a5-5f43-4a7a-a425-726279154c08") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("008d29a5-5f43-4a7a-a425-726279154c08") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("25579215-4d3e-4205-981a-27ef7083a83c") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("f353cd4d-396e-4bd9-bb29-08a8c2fd3907"), new Guid("25579215-4d3e-4205-981a-27ef7083a83c") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("5a4b54cb-36b7-4f9e-a028-3347d7c38de0"), new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2"), new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("8128a0e4-6c1b-49a2-9b11-2f1930a9ecdc"), new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("84250e5a-f4e3-4d08-975f-fb68e879eae5"), new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"), new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"), new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"), new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb"), new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("f1cb027b-7f7e-4645-8668-b1526fdb7c86"), new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("d249f9e2-bb3c-4e30-8611-7b573bfa1a97") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("5a4b54cb-36b7-4f9e-a028-3347d7c38de0"), new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("e93bb57f-c81d-4a4f-b5ae-fbcb3493c0e7") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("ca9983b1-b143-4d0b-b6b7-5ed003efef59"), new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"), new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"), new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"), new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolPhilosopher",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "PhilosophersId" },
                keyValues: new object[] { new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"), new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("34f19353-1d4f-4e3b-91e1-4e83b23e7b5c") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"), new Guid("3eb03c5e-d5a6-4704-833a-c7d41d223089") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"), new Guid("3eb03c5e-d5a6-4704-833a-c7d41d223089") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("f353cd4d-396e-4bd9-bb29-08a8c2fd3907"), new Guid("3f1b9e6a-39f1-4f33-9ea5-7b6a68a9e267") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("6ff8c3b7-e212-4a2d-b3f0-399b1c81350f") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb"), new Guid("86b5e3f1-5b32-42f1-94b3-948c0623727e") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"), new Guid("a58f52a0-44c2-41bc-8928-29a99cf5d4cf") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"), new Guid("c6a32d79-d78c-4b5e-90aa-1a680d7fc130") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"), new Guid("c6a32d79-d78c-4b5e-90aa-1a680d7fc130") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"), new Guid("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2"), new Guid("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862") });

            migrationBuilder.DeleteData(
                table: "CategorySchoolWork",
                keyColumns: new[] { "CategorySchoolsCategorySchoolId", "WorksId" },
                keyValues: new object[] { new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"), new Guid("fcd0984e-3e80-4993-8e28-32bd843b1059") });

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("14b3c490-6d37-4c8f-b0a2-d2e1e7d8ea64"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f8b35129-0e8c-4911-a8fd-b059cc41cf1f"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("0055f212-4e67-4aa5-a1a3-3f7c05d2125f"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("169ae31e-4083-4a0f-8ea0-06ccf1e2f502"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("8adac4c3-007b-48f4-b76f-4b02128255c8"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("c94fe294-924e-4d2d-9c5c-8c423924f01e"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("d18cc7a7-d229-4c5a-8ea1-b47a4e71c6a4"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("f5ce7bd6-3802-45ae-875b-24b729c42f15"));

            migrationBuilder.DeleteData(
                table: "RelatedNotion",
                keyColumns: new[] { "NotionIdFrom", "NotionIdTo" },
                keyValues: new object[] { new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3"), new Guid("103d2dcf-1cfc-4b77-86b0-202f38ff702e") });

            migrationBuilder.DeleteData(
                table: "RelatedNotion",
                keyColumns: new[] { "NotionIdFrom", "NotionIdTo" },
                keyValues: new object[] { new Guid("e403af49-1a31-4dd9-984e-43b1dce3b43f"), new Guid("f933e7d4-478f-442f-a1a5-8e2e0424375f") });

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("14a7d015-2ea1-4917-a67d-79050a8c2284"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("2e994d2d-e383-470f-91c6-59ccbb4e5864"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("34f3e2e3-1639-4d68-b30c-7e25cf5bb158"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5c369d59-f8c4-40f0-9a41-d13015d3c3a6"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("67a2c986-cb52-4cb1-8495-d98994db7ccf"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("7ff2f8e7-e5f2-4ab0-ae2a-1801248f1ad3"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("914d6b7c-3e4e-42a7-a8b4-33815a239764"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("985f8a06-b109-4a38-a4a5-b6d62a2d9e37"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("d113c8d7-72b6-4bde-99ff-90aa9fa8c8f0"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("e1ed7dd5-86d6-4c5d-8594-46e59aab6b8c"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fa5c4237-62b7-4fe9-bc29-e0498d7f5488"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("5a4b54cb-36b7-4f9e-a028-3347d7c38de0"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("84250e5a-f4e3-4d08-975f-fb68e879eae5"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("ca9983b1-b143-4d0b-b6b7-5ed003efef59"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f1cb027b-7f7e-4645-8668-b1526fdb7c86"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f353cd4d-396e-4bd9-bb29-08a8c2fd3907"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("103d2dcf-1cfc-4b77-86b0-202f38ff702e"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("3cf7e7fd-fb56-42b9-bd2e-8c0bb0f2a057"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("72e3c381-693e-46ae-b6d4-c74ed0e03f30"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("8261284d-1b86-432f-bd91-b6c5d8f9f191"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("b624a80b-2594-4f57-b300-35dfd470087e"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("db90ef98-0a7e-4e7e-b730-9981e407d31d"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("e403af49-1a31-4dd9-984e-43b1dce3b43f"));

            migrationBuilder.DeleteData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("f933e7d4-478f-442f-a1a5-8e2e0424375f"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("06f2387c-b659-4ff7-8a10-161ec964c27d"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("83cf4059-5701-417e-b508-f3cd23a27b6c"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d249f9e2-bb3c-4e30-8611-7b573bfa1a97"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("e93bb57f-c81d-4a4f-b5ae-fbcb3493c0e7"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("34f19353-1d4f-4e3b-91e1-4e83b23e7b5c"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("3eb03c5e-d5a6-4704-833a-c7d41d223089"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("3f1b9e6a-39f1-4f33-9ea5-7b6a68a9e267"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("6ff8c3b7-e212-4a2d-b3f0-399b1c81350f"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("86b5e3f1-5b32-42f1-94b3-948c0623727e"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("a58f52a0-44c2-41bc-8928-29a99cf5d4cf"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("c6a32d79-d78c-4b5e-90aa-1a680d7fc130"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fcd0984e-3e80-4993-8e28-32bd843b1059"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("73a1b7a9-9be5-4eb2-a5bc-b703b4e3c2e5"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("8128a0e4-6c1b-49a2-9b11-2f1930a9ecdc"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("008d29a5-5f43-4a7a-a425-726279154c08"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("25579215-4d3e-4205-981a-27ef7083a83c"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("9a1d2ebc-bd4b-4380-a665-9f28a2304dc3"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e"));

            migrationBuilder.DeleteData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("d4623a52-4e63-42e6-b8a3-8750ad264f7c"));

            migrationBuilder.DeleteData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"));

            migrationBuilder.RenameColumn(
                name: "CategorySchoolsCategorySchoolId",
                table: "CategorySchoolWork",
                newName: "WorkId");

            migrationBuilder.RenameColumn(
                name: "WorksId",
                table: "CategorySchoolWork",
                newName: "CategoriesSchoolsCategorySchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySchoolWork_CategorySchoolsCategorySchoolId",
                table: "CategorySchoolWork",
                newName: "IX_CategorySchoolWork_WorkId");

            migrationBuilder.RenameColumn(
                name: "PhilosophersId",
                table: "CategorySchoolPhilosopher",
                newName: "PhilosopherId");

            migrationBuilder.RenameColumn(
                name: "CategorySchoolsCategorySchoolId",
                table: "CategorySchoolNotion",
                newName: "NotionId");

            migrationBuilder.RenameColumn(
                name: "NotionsNotionId",
                table: "CategorySchoolNotion",
                newName: "CategoriesSchoolsCategorySchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySchoolNotion_CategorySchoolsCategorySchoolId",
                table: "CategorySchoolNotion",
                newName: "IX_CategorySchoolNotion_NotionId");

            migrationBuilder.AlterColumn<LocalDate>(
                name: "DeathDate",
                table: "Philosophers",
                type: "date",
                nullable: false,
                defaultValue: new NodaTime.LocalDate(1, 1, 1),
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<LocalDate>(
                name: "BirthDate",
                table: "Philosophers",
                type: "date",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorySchoolPhilosopher",
                table: "CategorySchoolPhilosopher",
                columns: new[] { "CategorySchoolsCategorySchoolId", "PhilosopherId" });

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchoolPhilosopher_PhilosopherId",
                table: "CategorySchoolPhilosopher",
                column: "PhilosopherId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolNotion_CategorySchools_CategoriesSchoolsCateg~",
                table: "CategorySchoolNotion",
                column: "CategoriesSchoolsCategorySchoolId",
                principalTable: "CategorySchools",
                principalColumn: "CategorySchoolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolNotion_Notions_NotionId",
                table: "CategorySchoolNotion",
                column: "NotionId",
                principalTable: "Notions",
                principalColumn: "NotionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolPhilosopher_Philosophers_PhilosopherId",
                table: "CategorySchoolPhilosopher",
                column: "PhilosopherId",
                principalTable: "Philosophers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolWork_CategorySchools_CategoriesSchoolsCategor~",
                table: "CategorySchoolWork",
                column: "CategoriesSchoolsCategorySchoolId",
                principalTable: "CategorySchools",
                principalColumn: "CategorySchoolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySchoolWork_Works_WorkId",
                table: "CategorySchoolWork",
                column: "WorkId",
                principalTable: "Works",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
