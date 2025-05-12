using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NpgsqlTypes;

#nullable disable

namespace Philosophers_Catalogue.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Philosophers_Name",
                table: "Philosophers");

            migrationBuilder.DropIndex(
                name: "IX_CategorySchools_Name",
                table: "CategorySchools");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Notions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CategorySchools");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Works",
                newName: "NameRu");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Works",
                newName: "DescriptionRu");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Philosophers",
                newName: "NameRu");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Philosophers",
                newName: "BioRu");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Notions",
                newName: "NameRu");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CategorySchools",
                newName: "DescriptionRu");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Branches",
                newName: "NameRu");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Branches",
                newName: "DescriptionRu");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Works",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Works",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<NpgsqlTsVector>(
                name: "Embeddings",
                table: "Works",
                type: "tsvector",
                nullable: false,
                oldClrType: typeof(NpgsqlTsVector),
                oldType: "tsvector")
                .Annotation("Npgsql:TsVectorConfig", "english")
                .Annotation("Npgsql:TsVectorProperties", new[] { "NameEn", "DescriptionEn" });

            migrationBuilder.AddColumn<string>(
                name: "BioEn",
                table: "Philosophers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Philosophers",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Notions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionRu",
                table: "Notions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Notions",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "CategorySchools",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "CategorySchools",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameRu",
                table: "CategorySchools",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Branches",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Branches",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("73a1b7a9-9be5-4eb2-a5bc-b703b4e3c2e5"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn" },
                values: new object[] { "Moral philosophy, involves systematizing, defending, and recommending concepts of right and wrong conduct.", "Моральная философия, включает систематизацию, защиту и рекомендации концепций правильного и неправильного поведения.", "Ethics" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn" },
                values: new object[] { "Theory of knowledge, especially with regard to its methods, validity, and scope.", "Теория познания, особенно в отношении его методов, достоверности и объема.", "Epistemology" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn" },
                values: new object[] { "Branch of philosophy that examines the fundamental nature of reality, including the relationship between mind and matter, substance and attribute, potentiality and actuality.", "Раздел философии, исследующий фундаментальную природу реальности, включая отношения между разумом и материей, субстанцией и атрибутом, возможностью и действительностью.", "Metaphysics" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("a19db7ce-cf0c-4dc1-bf2a-ec4f192d1240"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn" },
                values: new object[] { "Philosophical study of beauty and taste, and art as a special kind of social ideology.", "Философское учение о сущности и формах прекрасного в художественном творчестве, в природе и в жизни, об искусстве как особом виде общественной идеологии.", "Aesthetics" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("d4623a52-4e63-42e6-b8a3-8750ad264f7c"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn" },
                values: new object[] { "The study of reasoning and argument, and the science of the laws and forms of thought.", "Наука о законах и формах мышления, о методах рассуждения и доказательства.", "Logic" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("14b3c490-6d37-4c8f-b0a2-d2e1e7d8ea64"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A method of critical thought which dominated teaching by the academics (scholastics, or schoolmen) of medieval universities in Europe from about 1100 to 1700.", "Метод критического мышления, который доминировал в преподавании академиков (схоластов, или школяров) средневековых университетов Европы примерно с 1100 по 1700 год.", "Scholasticism", "Схоластика" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A philosophical movement that emerged in Germany in the late 18th and early 19th centuries.", "Философское движение, возникшее в Германии в конце XVIII - начале XIX веков.", "German Idealism", "Немецкий идеализм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A tradition of philosophy that takes its defining inspiration from the work of Aristotle.", "Философская традиция, черпающая свое определяющее вдохновение из работ Аристотеля.", "Aristotelianism", "Аристотелизм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Philosophy of Immanuel Kant, a German philosopher.", "Философия Иммануила Канта, немецкого философа.", "Kantianism", "Кантианство" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("5a4b54cb-36b7-4f9e-a028-3347d7c38de0"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "The group of metaphysical philosophies that assert that reality, or reality as humans can know it, is fundamentally mental, mentally constructed, or otherwise immaterial.", "Группа метафизических философий, утверждающих, что реальность, или реальность, какой ее могут познать люди, фундаментально ментальна, ментально сконструирована или иным образом нематериальна.", "Idealism", "Идеализм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A form of philosophical inquiry that explores the problem of human existence and centers on the lived experience of the thinking, feeling, acting individual.", "Форма философского исследования, которая исследует проблему человеческого существования и фокусируется на жизненном опыте мыслящего, чувствующего, действующего индивида.", "Existentialism", "Экзистенциализм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("8128a0e4-6c1b-49a2-9b11-2f1930a9ecdc"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A tradition of philosophy characterized by an emphasis on clarity, argument, and formal logic.", "Традиция философии, характеризующаяся акцентом на ясность, аргументацию и формальную логику.", "Analytic Philosophy", "Аналитическая философия" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("84250e5a-f4e3-4d08-975f-fb68e879eae5"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A movement in Western philosophy whose central thesis was the verification principle.", "Движение в западной философии, центральным тезисом которого был принцип верификации.", "Logical Positivism", "Логический позитивизм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A range of socio-political movements and ideologies that aim to define and establish the political, economic, personal, and social equality of the sexes.", "Ряд социально-политических движений и идеологий, направленных на определение и установление политического, экономического, личного и социального равенства полов.", "Feminism", "Феминизм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "The philosophy of Plato and philosophical systems closely derived from it.", "Философия Платона и тесно связанные с ней философские системы.", "Platonism", "Платонизм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A distinctive school of thought that emerged in Russia in the 19th and early 20th centuries.", "Самобытная школа мысли, возникшая в России в XIX - начале XX веков.", "Russian Religious Philosophy", "Русская религиозная философия" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A theory that states that knowledge comes only or primarily from sensory experience.", "Теория, согласно которой знание происходит только или преимущественно из чувственного опыта.", "Empiricism", "Эмпиризм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("ca9983b1-b143-4d0b-b6b7-5ed003efef59"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "The study of structures of consciousness as experienced from the first-person point of view.", "Исследование структур сознания, переживаемых с точки зрения первого лица.", "Phenomenology", "Феноменология" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A view appealing to reason as a source of knowledge or justification.", "Взгляд, апеллирующий к разуму как источнику знания или оправдания.", "Rationalism", "Рационализм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Philosophy in Ancient Greece, from the 6th century BC to the Hellenistic period.", "Философия в Древней Греции, с VI века до н.э. до эллинистического периода.", "Ancient Greek Philosophy", "Древнегреческая философия" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A set of traditions of 19th and 20th-century philosophy from mainland Europe.", "Совокупность традиций философии XIX и XX веков из континентальной Европы.", "Continental Philosophy", "Континентальная философия" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Philosophy developed in the Western world during the early modern period (roughly 17th to 19th centuries).", "Философия, развивавшаяся в западном мире в ранний современный период (примерно XVII-XIX века).", "Modern Philosophy", "Философия Нового времени" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f1cb027b-7f7e-4645-8668-b1526fdb7c86"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "The belief that reality exists independently of observers.", "Убеждение, что реальность существует независимо от наблюдателей.", "Realism", "Реализм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f353cd4d-396e-4bd9-bb29-08a8c2fd3907"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A term for philosophical and literary forms of theory that both build upon and reject ideas established by structuralism.", "Термин для философских и литературных форм теории, которые одновременно основываются на идеях структурализма и отвергают их.", "Post-structuralism", "Постструктурализм" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f8b35129-0e8c-4911-a8fd-b059cc41cf1f"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A school of Hellenistic philosophy founded by Zeno of Citium in Athens in the early 3rd century BC.", "Школа эллинистической философии, основанная Зеноном из Китиона в Афинах в начале III века до н.э.", "Stoicism", "Стоицизм" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("0055f212-4e67-4aa5-a1a3-3f7c05d2125f"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "In Husserl's phenomenology, the object or content of a thought, judgment, or perception, but as it is meant or intended in that thought.", "В феноменологии Гуссерля — объект или содержание мысли, суждения или восприятия, но как оно подразумевается или имеется в виду в этой мысли.", "Noema", "Ноэма" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("103d2dcf-1cfc-4b77-86b0-202f38ff702e"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A concept in psychology, existentialist philosophy and aesthetics concerning the degree to which an individual's actions are congruent with their beliefs and desires, despite external pressures.", "Понятие в психологии, экзистенциальной философии и эстетике, касающееся степени, в которой действия индивида соответствуют его убеждениям и желаниям, несмотря на внешнее давление.", "Authenticity", "Аутентичность" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("169ae31e-4083-4a0f-8ea0-06ccf1e2f502"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "In Leibniz's philosophy, an elementary individual substance that reflects the universe from a specific viewpoint and is subject to its own internal laws of development.", "В философии Лейбница — элементарная индивидуальная субстанция, которая отражает вселенную с определенной точки зрения и подчиняется своим собственным внутренним законам развития.", "Monad", "Монада" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("3cf7e7fd-fb56-42b9-bd2e-8c0bb0f2a057"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Locke's theory that individuals are born without built-in mental content and that therefore all knowledge comes from experience or perception.", "Теория Локка о том, что индивиды рождаются без встроенного ментального содержания, и поэтому все знания приходят из опыта или восприятия.", "Tabula Rasa", "Чистая доска" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Heidegger's term for 'being-there' or 'presence', referring to the human way of being.", "Термин Хайдеггера для 'бытия-здесь' или 'присутствия', относящийся к человеческому способу бытия.", "Dasein", "Дазайн" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("72e3c381-693e-46ae-b6d4-c74ed0e03f30"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A spiritual community of many jointly living people, a key concept in Russian religious philosophy.", "Духовная общность многих совместно живущих людей, ключевое понятие в русской религиозной философии.", "Sobornost", "Соборность" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("8261284d-1b86-432f-bd91-b6c5d8f9f191"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Kant's central philosophical concept in his deontological moral philosophy.", "Центральное философское понятие Канта в его деонтологической моральной философии.", "Categorical Imperative", "Категорический императив" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("8adac4c3-007b-48f4-b76f-4b02128255c8"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A condition in social relationships reflected by a low degree of integration or common values and a high degree of distance or isolation between individuals, or between an individual and a group of people in a community or work environment.", "Состояние в социальных отношениях, отражающееся низкой степенью интеграции или общих ценностей и высокой степенью дистанции или изоляции между индивидами, или между индивидом и группой людей в сообществе или рабочей среде.", "Alienation", "Отчуждение" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("b624a80b-2594-4f57-b300-35dfd470087e"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Plato's theory that the physical world is not as real or true as timeless, absolute, unchangeable ideas.", "Теория Платона о том, что физический мир не так реален или истинен, как вневременные, абсолютные, неизменные идеи.", "Theory of Forms", "Теория форм" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("c94fe294-924e-4d2d-9c5c-8c423924f01e"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "In philosophy, an irresolvable internal contradiction or logical disjunction in a text, argument, or theory.", "В философии — неразрешимое внутреннее противоречие или логическая дизъюнкция в тексте, аргументе или теории.", "Aporia", "Апория" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("d18cc7a7-d229-4c5a-8ea1-b47a4e71c6a4"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A theory or model that originated during the Age of Enlightenment and usually concerns the legitimacy of the authority of the state over the individual.", "Теория или модель, возникшая в эпоху Просвещения и обычно касающаяся легитимности власти государства над индивидом.", "Social Contract", "Общественный договор" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("db90ef98-0a7e-4e7e-b730-9981e407d31d"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Descartes' famous philosophical proposition: 'I think, therefore I am'.", "Знаменитое философское утверждение Декарта: 'Я мыслю, следовательно, я существую'.", "Cogito, ergo sum", "Мыслю, следовательно, существую" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("e403af49-1a31-4dd9-984e-43b1dce3b43f"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Nietzsche's concept of a goal for humanity to set for itself.", "Концепция Ницше о цели, которую человечество должно поставить перед собой.", "Übermensch", "Сверхчеловек" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("f5ce7bd6-3802-45ae-875b-24b729c42f15"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A kind of logical argument that applies deductive reasoning to arrive at a conclusion based on two or more propositions that are asserted or assumed to be true.", "Вид логического аргумента, который применяет дедуктивное рассуждение для получения вывода на основе двух или более утверждений, которые утверждаются или предполагаются истинными.", "Syllogism", "Силлогизм" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("f933e7d4-478f-442f-a1a5-8e2e0424375f"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A prominent concept in the philosophy of Friedrich Nietzsche, describing what he believed to be the main driving force in humans.", "Выдающаяся концепция в философии Фридриха Ницше, описывающая то, что он считал главной движущей силой в людях.", "Will to Power", "Воля к власти" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("008d29a5-5f43-4a7a-a425-726279154c08"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "French philosopher, mathematician, and scientist. Dubbed the father of modern western philosophy.", "Французский философ, математик и ученый. Считается отцом современной западной философии.", "René Descartes", "Рене Декарт" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("06f2387c-b659-4ff7-8a10-161ec964c27d"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Danish philosopher, theologian, poet, social critic and religious author who is widely considered to be the first existentialist philosopher.", "Датский философ, теолог, поэт, социальный критик и религиозный автор, широко считающийся первым философом-экзистенциалистом.", "Søren Kierkegaard", "Сёрен Кьеркегор" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("25579215-4d3e-4205-981a-27ef7083a83c"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "French philosopher, historian of ideas, writer, political activist, and literary critic. Foucault's theories primarily address the relationship between power and knowledge, and how they are used as a form of social control through societal institutions.", "Французский философ, историк идей, писатель, политический активист и литературный критик. Теории Фуко в основном касаются взаимосвязи между властью и знанием, и того, как они используются в качестве формы социального контроля через общественные институты.", "Michel Foucault", "Мишель Фуко" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Russian philosopher, philologist and culturologist, one of the most prominent figures in Russian philosophical and religious thought of the 20th century.", "Русский философ, филолог и культуролог, одна из самых выдающихся фигур русской философской и религиозной мысли XX века.", "Aleksei Losev", "Алексей Лосев" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Russian existentialist philosopher, known for his 'philosophy of despair' and his critique of rationalism.", "Русский философ-экзистенциалист, известный своей 'философией отчаяния' и критикой рационализма.", "Lev Shestov", "Лев Шестов" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Russian political and Christian existentialist philosopher who emphasized the existential spiritual significance of human freedom and the human person.", "Русский политический и христианский философ-экзистенциалист, подчеркивавший экзистенциальное духовное значение человеческой свободы и человеческой личности.", "Nikolai Berdyaev", "Николай Бердяев" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "French writer, intellectual, existentialist philosopher, political activist, feminist, and social theorist.", "Французская писательница, интеллектуалка, философ-экзистенциалист, политическая активистка, феминистка и социальный теоретик.", "Simone de Beauvoir", "Симона де Бовуар" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("83cf4059-5701-417e-b508-f3cd23a27b6c"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "German philosopher. Best known for his 1818 work The World as Will and Representation.", "Немецкий философ. Наиболее известен своей работой 1818 года 'Мир как воля и представление'.", "Arthur Schopenhauer", "Артур Шопенгауэр" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("9a1d2ebc-bd4b-4380-a665-9f28a2304dc3"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Russian philosopher, literary critic and scholar who worked on literary theory, ethics, and the philosophy of language.", "Русский философ, литературовед и ученый, работавший над теорией литературы, этикой и философией языка.", "Mikhail Bakhtin", "Михаил Бахтин" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Austrian-British philosopher who worked primarily in logic, the philosophy of mathematics, the philosophy of mind, and the philosophy of language.", "Австрийско-британский философ, работавший преимущественно в области логики, философии математики, философии сознания и философии языка.", "Ludwig Wittgenstein", "Людвиг Витгенштейн" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Ancient Greek philosopher, founder of the Platonist school of thought and the Academy.", "Древнегреческий философ, основатель платонической школы мысли и Академии.", "Plato", "Платон" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "German philosopher, a central figure in modern philosophy. Argued that human understanding is the source of the general laws of nature that structure all our experience.", "Немецкий философ, центральная фигура современной философии. Утверждал, что человеческое понимание является источником общих законов природы, которые структурируют весь наш опыт.", "Immanuel Kant", "Иммануил Кант" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Ancient Greek philosopher and scientist. His writings cover many subjects including physics, biology, zoology, metaphysics, logic, ethics, aesthetics, poetry, theatre, music, rhetoric, psychology, linguistics, economics, politics, and government.", "Древнегреческий философ и ученый. Его труды охватывают множество предметов, включая физику, биологию, зоологию, метафизику, логику, этику, эстетику, поэзию, театр, музыку, риторику, психологию, лингвистику, экономику, политику и государственное управление.", "Aristotle", "Аристотель" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d249f9e2-bb3c-4e30-8611-7b573bfa1a97"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "German philosopher, cultural critic, composer, poet, writer, and philologist whose work has exerted a profound influence on modern intellectual history.", "Немецкий философ, культурный критик, композитор, поэт, писатель и филолог, чьи работы оказали глубокое влияние на современную интеллектуальную историю.", "Friedrich Nietzsche", "Фридрих Ницше" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Russian philosopher, theologian, poet, pamphleteer, and literary critic. He played a significant role in the development of Russian philosophy and poetry at the end of the 19th century and in the spiritual renaissance of the early 20th century.", "Русский философ, богослов, поэт, публицист и литературный критик. Он сыграл значительную роль в развитии русской философии и поэзии конца XIX века и в духовном ренессансе начала XX века.", "Vladimir Solovyov", "Владимир Соловьёв" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Dutch philosopher of Portuguese Sephardi origin. One of the early thinkers of the Enlightenment and modern biblical criticism, including modern conceptions of the self and the universe.", "Голландский философ португальско-сефардского происхождения. Один из ранних мыслителей Просвещения и современной библейской критики, включая современные концепции самости и вселенной.", "Baruch Spinoza", "Бенедикт Спиноза" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("e93bb57f-c81d-4a4f-b5ae-fbcb3493c0e7"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "German-born American political theorist. Her work deals with the nature of power, and the subjects of politics, direct democracy, authority, and totalitarianism.", "Американский политический теоретик немецкого происхождения. Её работы посвящены природе власти, а также вопросам политики, прямой демократии, авторитета и тоталитаризма.", "Hannah Arendt", "Ханна Арендт" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "French philosopher, playwright, novelist, screenwriter, political activist, biographer, and literary critic. He was one of the key figures in the philosophy of existentialism and phenomenology.", "Французский философ, драматург, романист, сценарист, политический активист, биограф и литературный критик. Он был одной из ключевых фигур в философии экзистенциализма и феноменологии.", "Jean-Paul Sartre", "Жан-Поль Сартр" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "English philosopher and physician, widely regarded as one of the most influential of Enlightenment thinkers and commonly known as the 'Father of Liberalism'.", "Английский философ и врач, широко признанный одним из самых влиятельных мыслителей Просвещения и известный как 'Отец либерализма'.", "John Locke", "Джон Локк" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2"),
                columns: new[] { "BioEn", "BioRu", "NameEn", "NameRu" },
                values: new object[] { "Scottish Enlightenment philosopher, historian, economist, and essayist, who is best known today for his highly influential system of philosophical empiricism, skepticism, and naturalism.", "Шотландский философ эпохи Просвещения, историк, экономист и эссеист, наиболее известный сегодня своей влиятельной системой философского эмпиризма, скептицизма и натурализма.", "David Hume", "Дэвид Юм" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("14a7d015-2ea1-4917-a67d-79050a8c2284"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A major work by Hannah Arendt discussing the vita activa (active life) in contrast to the vita contemplativa (contemplative life).", "Крупная работа Ханны Арендт, обсуждающая vita activa (деятельную жизнь) в противоположность vita contemplativa (созерцательной жизни).", "The Human Condition", "Vita activa, или О деятельной жизни" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("2e994d2d-e383-470f-91c6-59ccbb4e5864"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A work concerning the foundation of human knowledge and understanding.", "Работа, посвященная основам человеческого знания и понимания.", "An Essay Concerning Human Understanding", "Опыт о человеческом разумении" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("34f19353-1d4f-4e3b-91e1-4e83b23e7b5c"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A major work of literary theory and analysis by Mikhail Bakhtin.", "Крупная работа Михаила Бахтина по теории и анализу литературы.", "Problems of Dostoevsky's Poetics", "Проблемы поэтики Достоевского" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("34f3e2e3-1639-4d68-b30c-7e25cf5bb158"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A philosophical novel exploring ideas like the 'death of God', the Übermensch, and the will to power.", "Философский роман, исследующий такие идеи, как 'смерть Бога', Сверхчеловек и воля к власти.", "Thus Spoke Zarathustra", "Так говорил Заратустра" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("3eb03c5e-d5a6-4704-833a-c7d41d223089"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Socratic dialogue concerning justice, the order and character of the just city-state, and the just man.", "Сократический диалог о справедливости, порядке и характере справедливого города-государства и справедливого человека.", "The Republic", "Государство" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("3f1b9e6a-39f1-4f33-9ea5-7b6a68a9e267"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "An analysis of the social and theoretical mechanisms behind the changes in Western penal systems during the modern age.", "Анализ социальных и теоретических механизмов, стоящих за изменениями в западных пенитенциарных системах в современную эпоху.", "Discipline and Punish: The Birth of the Prison", "Надзирать и наказывать" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5c369d59-f8c4-40f0-9a41-d13015d3c3a6"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A key work by Aleksei Losev on the nature of myth and its relation to consciousness and reality.", "Ключевая работа Алексея Лосева о природе мифа и его связи с сознанием и реальностью.", "The Dialectic of Myth", "Диалектика мифа" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("67a2c986-cb52-4cb1-8495-d98994db7ccf"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A book by Scottish philosopher David Hume, considered by many to be Hume's most important work and one of the most influential works in the history of philosophy.", "Книга шотландского философа Дэвида Юма, которую многие считают его самой важной работой и одним из самых влиятельных произведений в истории философии.", "A Treatise of Human Nature", "Трактат о человеческой природе" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("6ff8c3b7-e212-4a2d-b3f0-399b1c81350f"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "An essay on phenomenological ontology, considered a foundational text of existentialism.", "Эссе по феноменологической онтологии, считающееся основополагающим текстом экзистенциализма.", "Being and Nothingness", "Бытие и ничто" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("7ff2f8e7-e5f2-4ab0-ae2a-1801248f1ad3"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A philosophical work by Søren Kierkegaard, published in 1843 under the pseudonym Johannes de silentio.", "Философская работа Сёрена Кьеркегора, опубликованная в 1843 году под псевдонимом Йоханнес де Силенцио.", "Fear and Trembling", "Страх и трепет" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("86b5e3f1-5b32-42f1-94b3-948c0623727e"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Aristotle's best-known work on ethics, the science of the good for human life.", "Самая известная работа Аристотеля по этике, наука о благе для человеческой жизни.", "Nicomachean Ethics", "Никомахова этика" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("914d6b7c-3e4e-42a7-a8b4-33815a239764"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "The only book-length philosophical work by the Austrian philosopher Ludwig Wittgenstein that was published during his lifetime.", "Единственная философская работа австрийского философа Людвига Витгенштейна, опубликованная при его жизни.", "Tractatus Logico-Philosophicus", "Логико-философский трактат" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("985f8a06-b109-4a38-a4a5-b6d62a2d9e37"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "The central work of the German philosopher Arthur Schopenhauer.", "Центральная работа немецкого философа Артура Шопенгауэра.", "The World as Will and Representation", "Мир как воля и представление" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("a58f52a0-44c2-41bc-8928-29a99cf5d4cf"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A series of lectures outlining Solovyov's sophiology and concept of Godmanhood.", "Серия лекций, излагающих софиологию Соловьева и концепцию Богочеловечества.", "Lectures on Godmanhood", "Чтения о богочеловечестве" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("c6a32d79-d78c-4b5e-90aa-1a680d7fc130"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Explores the nature of human reason and its limits.", "Исследует природу человеческого разума и его пределы.", "Critique of Pure Reason", "Критика чистого разума" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("d113c8d7-72b6-4bde-99ff-90aa9fa8c8f0"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "Spinoza's magnum opus, a philosophical treatise written in Latin.", "Главный труд Спинозы, философский трактат, написанный на латыни.", "Ethics, Demonstrated in Geometrical Order", "Этика" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("e1ed7dd5-86d6-4c5d-8594-46e59aab6b8c"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A philosophical work contrasting Greek rationalism with Hebraic revelation.", "Философская работа, противопоставляющая греческий рационализм иудейскому откровению.", "Athens and Jerusalem", "Афины и Иерусалим" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A detailed analysis of women's oppression and a foundational tract of contemporary feminism.", "Подробный анализ угнетения женщин и основополагающий трактат современного феминизма.", "The Second Sex", "Второй пол" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fa5c4237-62b7-4fe9-bc29-e0498d7f5488"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "An essay on the philosophy of history by Nikolai Berdyaev.", "Эссе Николая Бердяева по философии истории.", "The Meaning of History", "Смысл истории" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fcd0984e-3e80-4993-8e28-32bd843b1059"),
                columns: new[] { "DescriptionEn", "DescriptionRu", "NameEn", "NameRu" },
                values: new object[] { "A foundational text of modern philosophy, exploring epistemological certainty.", "Основополагающий текст современной философии, исследующий эпистемологическую достоверность.", "Meditations on First Philosophy", "Размышления о первой философии" });

            migrationBuilder.CreateIndex(
                name: "IX_Philosophers_NameEn",
                table: "Philosophers",
                column: "NameEn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchools_NameEn",
                table: "CategorySchools",
                column: "NameEn",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Philosophers_NameEn",
                table: "Philosophers");

            migrationBuilder.DropIndex(
                name: "IX_CategorySchools_NameEn",
                table: "CategorySchools");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "BioEn",
                table: "Philosophers");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Philosophers");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Notions");

            migrationBuilder.DropColumn(
                name: "DescriptionRu",
                table: "Notions");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Notions");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "CategorySchools");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "CategorySchools");

            migrationBuilder.DropColumn(
                name: "NameRu",
                table: "CategorySchools");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Branches");

            migrationBuilder.RenameColumn(
                name: "NameRu",
                table: "Works",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DescriptionRu",
                table: "Works",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "NameRu",
                table: "Philosophers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BioRu",
                table: "Philosophers",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "NameRu",
                table: "Notions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DescriptionRu",
                table: "CategorySchools",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "NameRu",
                table: "Branches",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DescriptionRu",
                table: "Branches",
                newName: "Description");

            migrationBuilder.AlterColumn<NpgsqlTsVector>(
                name: "Embeddings",
                table: "Works",
                type: "tsvector",
                nullable: false,
                oldClrType: typeof(NpgsqlTsVector),
                oldType: "tsvector")
                .Annotation("Npgsql:TsVectorConfig", "russian")
                .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                .OldAnnotation("Npgsql:TsVectorConfig", "english")
                .OldAnnotation("Npgsql:TsVectorProperties", new[] { "NameEn", "DescriptionEn" });

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Notions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CategorySchools",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("73a1b7a9-9be5-4eb2-a5bc-b703b4e3c2e5"),
                column: "Description",
                value: "Moral philosophy, involves systematizing, defending, and recommending concepts of right and wrong conduct.");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11"),
                column: "Description",
                value: "Theory of knowledge, especially with regard to its methods, validity, and scope.");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("9f04ed88-7f30-43ef-ae69-c3731b802496"),
                column: "Description",
                value: "Branch of philosophy that examines the fundamental nature of reality, including the relationship between mind and matter, substance and attribute, potentiality and actuality.");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("a19db7ce-cf0c-4dc1-bf2a-ec4f192d1240"),
                column: "Description",
                value: "Philosophical study of beauty and taste.");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("d4623a52-4e63-42e6-b8a3-8750ad264f7c"),
                column: "Description",
                value: "Study of reasoning and argument.");

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("14b3c490-6d37-4c8f-b0a2-d2e1e7d8ea64"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A method of critical thought which dominated teaching by the academics (scholastics, or schoolmen) of medieval universities in Europe from about 1100 to 1700.", "Схоластика (Scholasticism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("1a6813df-3c87-4e00-b248-8a539ad6efb8"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A philosophical movement that emerged in Germany in the late 18th and early 19th centuries.", "Немецкий идеализм (German Idealism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A tradition of philosophy that takes its defining inspiration from the work of Aristotle.", "Аристотелизм (Aristotelianism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Philosophy of Immanuel Kant, a German philosopher.", "Кантианство (Kantianism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("5a4b54cb-36b7-4f9e-a028-3347d7c38de0"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The group of metaphysical philosophies that assert that reality, or reality as humans can know it, is fundamentally mental, mentally constructed, or otherwise immaterial.", "Идеализм (Idealism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A form of philosophical inquiry that explores the problem of human existence and centers on the lived experience of the thinking, feeling, acting individual.", "Экзистенциализм (Existentialism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("8128a0e4-6c1b-49a2-9b11-2f1930a9ecdc"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A tradition of philosophy characterized by an emphasis on clarity, argument, and formal logic.", "Аналитическая философия (Analytic Philosophy)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("84250e5a-f4e3-4d08-975f-fb68e879eae5"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A movement in Western philosophy whose central thesis was the verification principle.", "Логический позитивизм (Logical Positivism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A range of socio-political movements and ideologies that aim to define and establish the political, economic, personal, and social equality of the sexes.", "Феминизм (Feminism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The philosophy of Plato and philosophical systems closely derived from it.", "Платонизм (Platonism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A distinctive school of thought that emerged in Russia in the 19th and early 20th centuries.", "Русская религиозная философия (Russian Religious Philosophy)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A theory that states that knowledge comes only or primarily from sensory experience.", "Эмпиризм (Empiricism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("ca9983b1-b143-4d0b-b6b7-5ed003efef59"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The study of structures of consciousness as experienced from the first-person point of view.", "Феноменология (Phenomenology)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d269cbd7-c08f-4af4-86f1-340f8123b94b"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A view appealing to reason as a source of knowledge or justification.", "Рационализм (Rationalism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Philosophy in Ancient Greece, from the 6th century BC to the Hellenistic period.", "Древнегреческая философия (Ancient Greek Philosophy)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d8c3503a-cffc-4031-aec5-3ae5e065c9db"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A set of traditions of 19th and 20th-century philosophy from mainland Europe.", "Континентальная философия (Continental Philosophy)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Philosophy developed in the Western world during the early modern period (roughly 17th to 19th centuries).", "Философия Нового времени (Modern Philosophy)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f1cb027b-7f7e-4645-8668-b1526fdb7c86"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The belief that reality exists independently of observers.", "Реализм (Realism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f353cd4d-396e-4bd9-bb29-08a8c2fd3907"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A term for philosophical and literary forms of theory that both build upon and reject ideas established by structuralism.", "Постструктурализм (Post-structuralism)" });

            migrationBuilder.UpdateData(
                table: "CategorySchools",
                keyColumn: "CategorySchoolId",
                keyValue: new Guid("f8b35129-0e8c-4911-a8fd-b059cc41cf1f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A school of Hellenistic philosophy founded by Zeno of Citium in Athens in the early 3rd century BC.", "Стоицизм (Stoicism)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("0055f212-4e67-4aa5-a1a3-3f7c05d2125f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "In Husserl's phenomenology, the object or content of a thought, judgment, or perception, but as it is meant or intended in that thought.", "Ноэма (Noema)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("103d2dcf-1cfc-4b77-86b0-202f38ff702e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A concept in psychology, existentialist philosophy and aesthetics concerning the degree to which an individual's actions are congruent with their beliefs and desires, despite external pressures.", "Аутентичность (Authenticity)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("169ae31e-4083-4a0f-8ea0-06ccf1e2f502"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "In Leibniz's philosophy, an elementary individual substance that reflects the universe from a specific viewpoint and is subject to its own internal laws of development.", "Монада (Monad)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("3cf7e7fd-fb56-42b9-bd2e-8c0bb0f2a057"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Locke's theory that individuals are born without built-in mental content and that therefore all knowledge comes from experience or perception.", "Чистая доска (Tabula Rasa)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Heidegger's term for 'being-there' or 'presence', referring to the human way of being.", "Дазайн (Dasein)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("72e3c381-693e-46ae-b6d4-c74ed0e03f30"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A spiritual community of many jointly living people, a key concept in Russian religious philosophy.", "Соборность (Sobornost)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("8261284d-1b86-432f-bd91-b6c5d8f9f191"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kant's central philosophical concept in his deontological moral philosophy.", "Категорический императив (Categorical Imperative)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("8adac4c3-007b-48f4-b76f-4b02128255c8"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A condition in social relationships reflected by a low degree of integration or common values and a high degree of distance or isolation between individuals, or between an individual and a group of people in a community or work environment.", "Отчуждение (Alienation)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("b624a80b-2594-4f57-b300-35dfd470087e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plato's theory that the physical world is not as real or true as timeless, absolute, unchangeable ideas.", "Теория форм (Theory of Forms)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("c94fe294-924e-4d2d-9c5c-8c423924f01e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "In philosophy, an irresolvable internal contradiction or logical disjunction in a text, argument, or theory.", "Апория (Aporia)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("d18cc7a7-d229-4c5a-8ea1-b47a4e71c6a4"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A theory or model that originated during the Age of Enlightenment and usually concerns the legitimacy of the authority of the state over the individual.", "Общественный договор (Social Contract)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("db90ef98-0a7e-4e7e-b730-9981e407d31d"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Descartes' famous philosophical proposition: 'I think, therefore I am'.", "Мыслю, следовательно, существую (Cogito, ergo sum)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("e403af49-1a31-4dd9-984e-43b1dce3b43f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Nietzsche's concept of a goal for humanity to set for itself.", "Сверхчеловек (Übermensch)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("f5ce7bd6-3802-45ae-875b-24b729c42f15"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A kind of logical argument that applies deductive reasoning to arrive at a conclusion based on two or more propositions that are asserted or assumed to be true.", "Силлогизм (Syllogism)" });

            migrationBuilder.UpdateData(
                table: "Notions",
                keyColumn: "NotionId",
                keyValue: new Guid("f933e7d4-478f-442f-a1a5-8e2e0424375f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A prominent concept in the philosophy of Friedrich Nietzsche, describing what he believed to be the main driving force in humans.", "Воля к власти (Will to Power)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("008d29a5-5f43-4a7a-a425-726279154c08"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "French philosopher, mathematician, and scientist. Dubbed the father of modern western philosophy.", "Рене Декарт (René Descartes)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("06f2387c-b659-4ff7-8a10-161ec964c27d"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Danish philosopher, theologian, poet, social critic and religious author who is widely considered to be the first existentialist philosopher.", "Сёрен Кьеркегор (Søren Kierkegaard)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("25579215-4d3e-4205-981a-27ef7083a83c"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "French philosopher, historian of ideas, writer, political activist, and literary critic. Foucault's theories primarily address the relationship between power and knowledge, and how they are used as a form of social control through societal institutions.", "Мишель Фуко (Michel Foucault)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Russian philosopher, philologist and culturologist, one of the most prominent figures in Russian philosophical and religious thought of the 20th century.", "Алексей Лосев (Aleksei Losev)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("4f789f71-7e29-49e2-8fc9-18334f09a97f"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Russian existentialist philosopher, known for his 'philosophy of despair' and his critique of rationalism.", "Лев Шестов (Lev Shestov)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("529a3704-c1a1-4bcd-9af1-12676c07a278"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Russian political and Christian existentialist philosopher who emphasized the existential spiritual significance of human freedom and the human person.", "Николай Бердяев (Nikolai Berdyaev)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "French writer, intellectual, existentialist philosopher, political activist, feminist, and social theorist.", "Симона де Бовуар (Simone de Beauvoir)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("83cf4059-5701-417e-b508-f3cd23a27b6c"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "German philosopher. Best known for his 1818 work The World as Will and Representation.", "Артур Шопенгауэр (Arthur Schopenhauer)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("9a1d2ebc-bd4b-4380-a665-9f28a2304dc3"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Russian philosopher, literary critic and scholar who worked on literary theory, ethics, and the philosophy of language.", "Михаил Бахтин (Mikhail Bakhtin)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a190be46-1e46-47e9-a6a2-b6d35cba17f1"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Austrian-British philosopher who worked primarily in logic, the philosophy of mathematics, the philosophy of mind, and the philosophy of language.", "Людвиг Витгенштейн (Ludwig Wittgenstein)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Ancient Greek philosopher, founder of the Platonist school of thought and the Academy.", "Платон (Plato)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("a72d3eac-0d82-4225-8bb3-cbe47c154b6d"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "German philosopher, a central figure in modern philosophy. Argued that the human understanding is the source of the general laws of nature that structure all our experience.", "Иммануил Кант (Immanuel Kant)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("c0a792dd-3495-42ea-8011-dcc1e3702cf5"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Ancient Greek philosopher and scientist. His writings cover many subjects including physics, biology, zoology, metaphysics, logic, ethics, aesthetics, poetry, theatre, music, rhetoric, psychology, linguistics, economics, politics, and government.", "Аристотель (Aristotle)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d249f9e2-bb3c-4e30-8611-7b573bfa1a97"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "German philosopher, cultural critic, composer, poet, writer, and philologist whose work has exerted a profound influence on modern intellectual history.", "Фридрих Ницше (Friedrich Nietzsche)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Russian philosopher, theologian, poet, pamphleteer, and literary critic. He played a significant role in the development of Russian philosophy and poetry at the end of the 19th century and in the spiritual renaissance of the early 20th century.", "Владимир Соловьёв (Vladimir Solovyov)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("d87ed2d5-24df-4054-b982-7640dc0e36c3"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Dutch philosopher of Portuguese Sephardi origin. One of the early thinkers of the Enlightenment and modern biblical criticism, including modern conceptions of the self and the universe.", "Бенедикт Спиноза (Baruch Spinoza)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("e93bb57f-c81d-4a4f-b5ae-fbcb3493c0e7"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "German-born American political theorist. Her work deals with the nature of power, and the subjects of politics, direct democracy, authority, and totalitarianism.", "Ханна Арендт (Hannah Arendt)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "French philosopher, playwright, novelist, screenwriter, political activist, biographer, and literary critic. He was one of the key figures in the philosophy of existentialism and phenomenology.", "Жан-Поль Сартр (Jean-Paul Sartre)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("fa49f7a1-78db-41cf-9a71-d754a8509d3e"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "English philosopher and physician, widely regarded as one of the most influential of Enlightenment thinkers and commonly known as the 'Father of Liberalism'.", "Джон Локк (John Locke)" });

            migrationBuilder.UpdateData(
                table: "Philosophers",
                keyColumn: "Id",
                keyValue: new Guid("fca2f46b-8a3f-4268-901f-3021c7a62df2"),
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Scottish Enlightenment philosopher, historian, economist, and essayist, who is best known today for his highly influential system of philosophical empiricism, skepticism, and naturalism.", "Дэвид Юм (David Hume)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("14a7d015-2ea1-4917-a67d-79050a8c2284"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A major work by Hannah Arendt discussing the vita activa (active life) in contrast to the vita contemplativa (contemplative life).", "Vita activa, или О деятельной жизни (The Human Condition)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("2e994d2d-e383-470f-91c6-59ccbb4e5864"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A work concerning the foundation of human knowledge and understanding.", "Опыт о человеческом разумении (An Essay Concerning Human Understanding)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("34f19353-1d4f-4e3b-91e1-4e83b23e7b5c"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A major work of literary theory and analysis by Mikhail Bakhtin.", "Проблемы поэтики Достоевского (Problems of Dostoevsky's Poetics)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("34f3e2e3-1639-4d68-b30c-7e25cf5bb158"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A philosophical novel exploring ideas like the 'death of God', the Übermensch, and the will to power.", "Так говорил Заратустра (Thus Spoke Zarathustra)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("3eb03c5e-d5a6-4704-833a-c7d41d223089"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Socratic dialogue concerning justice, the order and character of the just city-state, and the just man.", "Государство (The Republic)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("3f1b9e6a-39f1-4f33-9ea5-7b6a68a9e267"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "An analysis of the social and theoretical mechanisms behind the changes in Western penal systems during the modern age.", "Надзирать и наказывать (Discipline and Punish: The Birth of the Prison)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5c369d59-f8c4-40f0-9a41-d13015d3c3a6"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A key work by Aleksei Losev on the nature of myth and its relation to consciousness and reality.", "Диалектика мифа (The Dialectic of Myth)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("67a2c986-cb52-4cb1-8495-d98994db7ccf"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A book by Scottish philosopher David Hume, considered by many to be Hume's most important work and one of the most influential works in the history of philosophy.", "Трактат о человеческой природе (A Treatise of Human Nature)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("6ff8c3b7-e212-4a2d-b3f0-399b1c81350f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "An essay on phenomenological ontology, considered a foundational text of existentialism.", "Бытие и ничто (Being and Nothingness)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("7ff2f8e7-e5f2-4ab0-ae2a-1801248f1ad3"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A philosophical work by Søren Kierkegaard, published in 1843 under the pseudonym Johannes de silentio.", "Страх и трепет (Fear and Trembling)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("86b5e3f1-5b32-42f1-94b3-948c0623727e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Aristotle's best-known work on ethics, the science of the good for human life.", "Никомахова этика (Nicomachean Ethics)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("914d6b7c-3e4e-42a7-a8b4-33815a239764"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The only book-length philosophical work by the Austrian philosopher Ludwig Wittgenstein that was published during his lifetime.", "Логико-философский трактат (Tractatus Logico-Philosophicus)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("985f8a06-b109-4a38-a4a5-b6d62a2d9e37"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "The central work of the German philosopher Arthur Schopenhauer.", "Мир как воля и представление (The World as Will and Representation)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("a58f52a0-44c2-41bc-8928-29a99cf5d4cf"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A series of lectures outlining Solovyov's sophiology and concept of Godmanhood.", "Чтения о богочеловечестве (Lectures on Godmanhood)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("c6a32d79-d78c-4b5e-90aa-1a680d7fc130"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explores the nature of human reason and its limits.", "Критика чистого разума (Critique of Pure Reason)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("d113c8d7-72b6-4bde-99ff-90aa9fa8c8f0"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Spinoza's magnum opus, a philosophical treatise written in Latin.", "Этика (Ethics, Demonstrated in Geometrical Order)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("e1ed7dd5-86d6-4c5d-8594-46e59aab6b8c"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A philosophical work contrasting Greek rationalism with Hebraic revelation.", "Афины и Иерусалим (Athens and Jerusalem)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A detailed analysis of women's oppression and a foundational tract of contemporary feminism.", "Второй пол (The Second Sex)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fa5c4237-62b7-4fe9-bc29-e0498d7f5488"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "An essay on the philosophy of history by Nikolai Berdyaev.", "Смысл истории (The Meaning of History)" });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fcd0984e-3e80-4993-8e28-32bd843b1059"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A foundational text of modern philosophy, exploring epistemological certainty.", "Размышления о первой философии (Meditations on First Philosophy)" });

            migrationBuilder.CreateIndex(
                name: "IX_Philosophers_Name",
                table: "Philosophers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategorySchools_Name",
                table: "CategorySchools",
                column: "Name",
                unique: true);
        }
    }
}
