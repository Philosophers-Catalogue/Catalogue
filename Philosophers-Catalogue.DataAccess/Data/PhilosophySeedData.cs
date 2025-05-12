using NodaTime;
using Philosophers_Catalogue.Models;
using Philosophers_Catalogue.Models.Enums;

namespace Philosophers_Catalogue.Data;

public static class PhilosophySeedData
{
    // Определяем момент времени для CreatedAt/UpdatedAt
    private static readonly Instant DefaultTime = Instant.FromUtc(2025, 1, 1, 0, 0);

    // --- ID для ветвей ---
    private static readonly Guid AestheticsBranchId = new("a19db7ce-cf0c-4dc1-bf2a-ec4f192d1240");
    private static readonly Guid EpistemologyBranchId = new("9b99ebf2-d3f7-4421-a9df-3d6a8cfa8e11");
    private static readonly Guid EthicsBranchId = new("73a1b7a9-9be5-4eb2-a5bc-b703b4e3c2e5");
    private static readonly Guid LogicBranchId = new("d4623a52-4e63-42e6-b8a3-8750ad264f7c");
    private static readonly Guid MetaphysicsBranchId = new("9f04ed88-7f30-43ef-ae69-c3731b802496");

// --- ID для философов ---
    public static readonly Guid PlatoId = new("a228c5ef-ec5e-4eb0-b9a3-04ea1579fae0");
    public static readonly Guid AristotleId = new("c0a792dd-3495-42ea-8011-dcc1e3702cf5");
    public static readonly Guid KantId = new("a72d3eac-0d82-4225-8bb3-cbe47c154b6d");
    public static readonly Guid NietzscheId = new("d249f9e2-bb3c-4e30-8611-7b573bfa1a97");
    public static readonly Guid SartreId = new("f1fd91e2-f7b2-4050-9ef4-34510e8f55b0");
    public static readonly Guid DeBeauvoirId = new("7c6747a3-5d0c-4e60-9b3e-3205ee14e09b");
    public static readonly Guid DescartesId = new("008d29a5-5f43-4a7a-a425-726279154c08");
    public static readonly Guid LockeId = new("fa49f7a1-78db-41cf-9a71-d754a8509d3e");
    public static readonly Guid HumeId = new("fca2f46b-8a3f-4268-901f-3021c7a62df2");
    public static readonly Guid SpinozaId = new("d87ed2d5-24df-4054-b982-7640dc0e36c3");
    private static readonly Guid SchopenhauerId = new("83cf4059-5701-417e-b508-f3cd23a27b6c");
    private static readonly Guid KierkegaardId = new("06f2387c-b659-4ff7-8a10-161ec964c27d");
    public static readonly Guid WittgensteinId = new("a190be46-1e46-47e9-a6a2-b6d35cba17f1");
    private static readonly Guid BakhtinId = new("9a1d2ebc-bd4b-4380-a665-9f28a2304dc3");
    public static readonly Guid SolovyovId = new("d2854bb6-9f28-4c8a-a2a5-82c748c5d83e");
    public static readonly Guid BerdyaevId = new("529a3704-c1a1-4bcd-9af1-12676c07a278");
    public static readonly Guid ShestovId = new("4f789f71-7e29-49e2-8fc9-18334f09a97f");
    public static readonly Guid LosevId = new("4c6d4f23-3c60-4f4e-bbc0-0e70b83cfb77");
    public static readonly Guid ArendtId = new("e93bb57f-c81d-4a4f-b5ae-fbcb3493c0e7");
    public static readonly Guid FoucaultId = new("25579215-4d3e-4205-981a-27ef7083a83c");

// --- ID для работ ---
    public static readonly Guid RepublicId = new("3eb03c5e-d5a6-4704-833a-c7d41d223089");
    public static readonly Guid NicomacheanEthicsId = new("86b5e3f1-5b32-42f1-94b3-948c0623727e");
    public static readonly Guid CritiquePureReasonId = new("c6a32d79-d78c-4b5e-90aa-1a680d7fc130");
    public static readonly Guid ThusSpokeZarathustraId = new("34f3e2e3-1639-4d68-b30c-7e25cf5bb158");
    public static readonly Guid BeingAndNothingnessId = new("6ff8c3b7-e212-4a2d-b3f0-399b1c81350f");
    public static readonly Guid SecondSexId = new("f4ed4dc0-d69c-494f-a7a6-8f83de9cf862");
    public static readonly Guid MeditationsId = new("fcd0984e-3e80-4993-8e28-32bd843b1059");
    public static readonly Guid EssayConcerningHumanUnderstandingId = new("2e994d2d-e383-470f-91c6-59ccbb4e5864");
    public static readonly Guid TreatiseHumanNatureId = new("67a2c986-cb52-4cb1-8495-d98994db7ccf");
    public static readonly Guid SpinozaEthicsId = new("d113c8d7-72b6-4bde-99ff-90aa9fa8c8f0");
    public static readonly Guid WorldAsWillId = new("985f8a06-b109-4a38-a4a5-b6d62a2d9e37");
    public static readonly Guid FearAndTremblingId = new("7ff2f8e7-e5f2-4ab0-ae2a-1801248f1ad3");
    public static readonly Guid TractatusId = new("914d6b7c-3e4e-42a7-a8b4-33815a239764");
    public static readonly Guid DostoevskyPoeticsId = new("34f19353-1d4f-4e3b-91e1-4e83b23e7b5c");
    public static readonly Guid GodmanhoodId = new("a58f52a0-44c2-41bc-8928-29a99cf5d4cf");
    public static readonly Guid MeaningOfHistoryId = new("fa5c4237-62b7-4fe9-bc29-e0498d7f5488");
    public static readonly Guid AthensAndJerusalemId = new("e1ed7dd5-86d6-4c5d-8594-46e59aab6b8c");
    public static readonly Guid DialecticOfMythId = new("5c369d59-f8c4-40f0-9a41-d13015d3c3a6");
    public static readonly Guid HumanConditionId = new("14a7d015-2ea1-4917-a67d-79050a8c2284");
    public static readonly Guid DisciplineAndPunishId = new("3f1b9e6a-39f1-4f33-9ea5-7b6a68a9e267");

// --- ID для категорий/школ ---
    public static readonly Guid PlatonismId = new("a1a347a7-c12a-4eb7-a13c-72a623ff7a1e");
    public static readonly Guid AristotelianismId = new("43c03a85-8af5-4bc3-9a2c-7b34cabc8dbb");
    public static readonly Guid KantianismId = new("4c1c75a3-5bd2-4fcb-9a37-2a9912a6d63f");
    public static readonly Guid ExistentialismId = new("6f3b70c6-b1ef-4d91-b6f7-6aebda2c27b6");
    public static readonly Guid FeminismId = new("9fbed9f3-0307-4d1d-85e2-40e65b9d11e2");
    public static readonly Guid RationalismId = new("d269cbd7-c08f-4af4-86f1-340f8123b94b");
    public static readonly Guid EmpiricismId = new("a8e7dba9-05b2-4bb5-91ae-e40182b3cd44");
    public static readonly Guid StoicismId = new("f8b35129-0e8c-4911-a8fd-b059cc41cf1f");
    public static readonly Guid GermanIdealismId = new("1a6813df-3c87-4e00-b248-8a539ad6efb8");
    public static readonly Guid PhenomenologyId = new("ca9983b1-b143-4d0b-b6b7-5ed003efef59");
    public static readonly Guid LogicalPositivismId = new("84250e5a-f4e3-4d08-975f-fb68e879eae5");
    public static readonly Guid RussianReligiousPhilosophyId = new("a4f9ef38-9e4e-4050-8a1f-7bb6a0b2964e");
    public static readonly Guid PostStructuralismId = new("f353cd4d-396e-4bd9-bb29-08a8c2fd3907");
    public static readonly Guid AncientGreekPhilosophyId = new("d69a7582-51d4-42d9-b0ad-6c5c4cebc47a");
    public static readonly Guid ModernPhilosophyId = new("d9f7b18b-2523-46e5-a5c7-5df6d92fcf92");
    public static readonly Guid ContinentalPhilosophyId = new("d8c3503a-cffc-4031-aec5-3ae5e065c9db");
    public static readonly Guid AnalyticPhilosophyId = new("8128a0e4-6c1b-49a2-9b11-2f1930a9ecdc");
    public static readonly Guid ScholasticismId = new("14b3c490-6d37-4c8f-b0a2-d2e1e7d8ea64");
    public static readonly Guid IdealismId = new("5a4b54cb-36b7-4f9e-a028-3347d7c38de0");
    public static readonly Guid RealismId = new("f1cb027b-7f7e-4645-8668-b1526fdb7c86");

// --- ID для понятий ---
    public static readonly Guid FormsId = new("b624a80b-2594-4f57-b300-35dfd470087e");
    public static readonly Guid CategoricalImperativeId = new("8261284d-1b86-432f-bd91-b6c5d8f9f191");
    public static readonly Guid UbermenschId = new("e403af49-1a31-4dd9-984e-43b1dce3b43f");
    public static readonly Guid DaseinId = new("6d4db55d-8c51-4fcb-b2c4-2b25f75a9cc3");
    public static readonly Guid TabulaRasaId = new("3cf7e7fd-fb56-42b9-bd2e-8c0bb0f2a057");
    public static readonly Guid CogitoErgoSumId = new("db90ef98-0a7e-4e7e-b730-9981e407d31d");
    public static readonly Guid SocialContractId = new("d18cc7a7-d229-4c5a-8ea1-b47a4e71c6a4");
    public static readonly Guid WillToPowerId = new("f933e7d4-478f-442f-a1a5-8e2e0424375f");
    public static readonly Guid AlienationId = new("8adac4c3-007b-48f4-b76f-4b02128255c8");
    public static readonly Guid AuthenticityId = new("103d2dcf-1cfc-4b77-86b0-202f38ff702e");
    public static readonly Guid AporiaId = new("c94fe294-924e-4d2d-9c5c-8c423924f01e");
    public static readonly Guid SyllogismId = new("f5ce7bd6-3802-45ae-875b-24b729c42f15");
    public static readonly Guid MonadId = new("169ae31e-4083-4a0f-8ea0-06ccf1e2f502");
    public static readonly Guid NoemaId = new("0055f212-4e67-4aa5-a1a3-3f7c05d2125f");
    public static readonly Guid SobornostId = new("72e3c381-693e-46ae-b6d4-c74ed0e03f30"); // Русское понятие


    public static Branch[] GetBranches()
    {
        return
        [
            new Branch
            {
                Id = AestheticsBranchId, NameRu = "Эстетика", NameEn = "Aesthetics",
                DescriptionRu = "Философское учение о сущности и формах прекрасного в художественном творчестве, в природе и в жизни, об искусстве как особом виде общественной идеологии.",
                DescriptionEn = "Philosophical study of beauty and taste, and art as a special kind of social ideology."
            },
            new Branch
            {
                Id = EpistemologyBranchId, NameRu = "Эпистемология", NameEn = "Epistemology",
                DescriptionRu = "Теория познания, особенно в отношении его методов, достоверности и объема.",
                DescriptionEn = "Theory of knowledge, especially with regard to its methods, validity, and scope."
            },
            new Branch
            {
                Id = EthicsBranchId, NameRu = "Этика", NameEn = "Ethics",
                DescriptionRu = "Моральная философия, включает систематизацию, защиту и рекомендации концепций правильного и неправильного поведения.",
                DescriptionEn = "Moral philosophy, involves systematizing, defending, and recommending concepts of right and wrong conduct."
            },
            new Branch
            {
                Id = LogicBranchId, NameRu = "Логика", NameEn = "Logic",
                DescriptionRu = "Наука о законах и формах мышления, о методах рассуждения и доказательства.",
                DescriptionEn = "The study of reasoning and argument, and the science of the laws and forms of thought."
            },
            new Branch
            {
                Id = MetaphysicsBranchId, NameRu = "Метафизика", NameEn = "Metaphysics",
                DescriptionRu = "Раздел философии, исследующий фундаментальную природу реальности, включая отношения между разумом и материей, субстанцией и атрибутом, возможностью и действительностью.",
                DescriptionEn = "Branch of philosophy that examines the fundamental nature of reality, including the relationship between mind and matter, substance and attribute, potentiality and actuality."
            }
        ];
    }

    public static Philosopher[] GetPhilosophers()
    {
        return
        [
            new Philosopher
            {
                Id = PlatoId, NameRu = "Платон", NameEn = "Plato",
                BioRu = "Древнегреческий философ, основатель платонической школы мысли и Академии.",
                BioEn = "Ancient Greek philosopher, founder of the Platonist school of thought and the Academy.",
                BirthDate = -428, DeathDate = -348, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 1
            },
            new Philosopher
            {
                Id = AristotleId, NameRu = "Аристотель", NameEn = "Aristotle",
                BioRu = "Древнегреческий философ и ученый. Его труды охватывают множество предметов, включая физику, биологию, зоологию, метафизику, логику, этику, эстетику, поэзию, театр, музыку, риторику, психологию, лингвистику, экономику, политику и государственное управление.",
                BioEn = "Ancient Greek philosopher and scientist. His writings cover many subjects including physics, biology, zoology, metaphysics, logic, ethics, aesthetics, poetry, theatre, music, rhetoric, psychology, linguistics, economics, politics, and government.",
                BirthDate = -384, DeathDate = -322, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 2
            },
            new Philosopher
            {
                Id = KantId, NameRu = "Иммануил Кант", NameEn = "Immanuel Kant",
                BioRu = "Немецкий философ, центральная фигура современной философии. Утверждал, что человеческое понимание является источником общих законов природы, которые структурируют весь наш опыт.",
                BioEn = "German philosopher, a central figure in modern philosophy. Argued that human understanding is the source of the general laws of nature that structure all our experience.",
                BirthDate = 1724, DeathDate = 1804, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 3
            },
            new Philosopher
            {
                Id = NietzscheId, NameRu = "Фридрих Ницше", NameEn = "Friedrich Nietzsche",
                BioRu = "Немецкий философ, культурный критик, композитор, поэт, писатель и филолог, чьи работы оказали глубокое влияние на современную интеллектуальную историю.",
                BioEn = "German philosopher, cultural critic, composer, poet, writer, and philologist whose work has exerted a profound influence on modern intellectual history.",
                BirthDate = 1844, DeathDate = 1900, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 4
            },
            new Philosopher
            {
                Id = SartreId, NameRu = "Жан-Поль Сартр", NameEn = "Jean-Paul Sartre",
                BioRu = "Французский философ, драматург, романист, сценарист, политический активист, биограф и литературный критик. Он был одной из ключевых фигур в философии экзистенциализма и феноменологии.",
                BioEn = "French philosopher, playwright, novelist, screenwriter, political activist, biographer, and literary critic. He was one of the key figures in the philosophy of existentialism and phenomenology.",
                BirthDate = 1905, DeathDate = 1980, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 5
            },
            new Philosopher
            {
                Id = DeBeauvoirId, NameRu = "Симона де Бовуар", NameEn = "Simone de Beauvoir",
                BioRu = "Французская писательница, интеллектуалка, философ-экзистенциалист, политическая активистка, феминистка и социальный теоретик.",
                BioEn = "French writer, intellectual, existentialist philosopher, political activist, feminist, and social theorist.",
                BirthDate = 1908, DeathDate = 1986, IsFemale = true,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 6
            },
            new Philosopher
            {
                Id = DescartesId, NameRu = "Рене Декарт", NameEn = "René Descartes",
                BioRu = "Французский философ, математик и ученый. Считается отцом современной западной философии.",
                BioEn = "French philosopher, mathematician, and scientist. Dubbed the father of modern western philosophy.",
                BirthDate = 1596, DeathDate = 1650, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 7
            },
            new Philosopher
            {
                Id = LockeId, NameRu = "Джон Локк", NameEn = "John Locke",
                BioRu = "Английский философ и врач, широко признанный одним из самых влиятельных мыслителей Просвещения и известный как 'Отец либерализма'.",
                BioEn = "English philosopher and physician, widely regarded as one of the most influential of Enlightenment thinkers and commonly known as the 'Father of Liberalism'.",
                BirthDate = 1632, DeathDate = 1704, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 8
            },
            new Philosopher
            {
                Id = HumeId, NameRu = "Дэвид Юм", NameEn = "David Hume",
                BioRu = "Шотландский философ эпохи Просвещения, историк, экономист и эссеист, наиболее известный сегодня своей влиятельной системой философского эмпиризма, скептицизма и натурализма.",
                BioEn = "Scottish Enlightenment philosopher, historian, economist, and essayist, who is best known today for his highly influential system of philosophical empiricism, skepticism, and naturalism.",
                BirthDate = 1711, DeathDate = 1776, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 9
            },
            new Philosopher
            {
                Id = SpinozaId, NameRu = "Бенедикт Спиноза", NameEn = "Baruch Spinoza",
                BioRu = "Голландский философ португальско-сефардского происхождения. Один из ранних мыслителей Просвещения и современной библейской критики, включая современные концепции самости и вселенной.",
                BioEn = "Dutch philosopher of Portuguese Sephardi origin. One of the early thinkers of the Enlightenment and modern biblical criticism, including modern conceptions of the self and the universe.",
                BirthDate = 1632, DeathDate = 1677, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 10
            },
            new Philosopher
            {
                Id = SchopenhauerId, NameRu = "Артур Шопенгауэр", NameEn = "Arthur Schopenhauer",
                BioRu = "Немецкий философ. Наиболее известен своей работой 1818 года 'Мир как воля и представление'.",
                BioEn = "German philosopher. Best known for his 1818 work The World as Will and Representation.",
                BirthDate = 1788, DeathDate = 1860, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 11
            },
            new Philosopher
            {
                Id = KierkegaardId, NameRu = "Сёрен Кьеркегор", NameEn = "Søren Kierkegaard",
                BioRu = "Датский философ, теолог, поэт, социальный критик и религиозный автор, широко считающийся первым философом-экзистенциалистом.",
                BioEn = "Danish philosopher, theologian, poet, social critic and religious author who is widely considered to be the first existentialist philosopher.",
                BirthDate = 1813, DeathDate = 1855, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 12
            },
            new Philosopher
            {
                Id = WittgensteinId, NameRu = "Людвиг Витгенштейн", NameEn = "Ludwig Wittgenstein",
                BioRu = "Австрийско-британский философ, работавший преимущественно в области логики, философии математики, философии сознания и философии языка.",
                BioEn = "Austrian-British philosopher who worked primarily in logic, the philosophy of mathematics, the philosophy of mind, and the philosophy of language.",
                BirthDate = 1889, DeathDate = 1951, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 13
            },
            new Philosopher
            {
                Id = BakhtinId, NameRu = "Михаил Бахтин", NameEn = "Mikhail Bakhtin",
                BioRu = "Русский философ, литературовед и ученый, работавший над теорией литературы, этикой и философией языка.",
                BioEn = "Russian philosopher, literary critic and scholar who worked on literary theory, ethics, and the philosophy of language.",
                BirthDate = 1895, DeathDate = 1975, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 14
            },
            new Philosopher
            {
                Id = SolovyovId, NameRu = "Владимир Соловьёв", NameEn = "Vladimir Solovyov",
                BioRu = "Русский философ, богослов, поэт, публицист и литературный критик. Он сыграл значительную роль в развитии русской философии и поэзии конца XIX века и в духовном ренессансе начала XX века.",
                BioEn = "Russian philosopher, theologian, poet, pamphleteer, and literary critic. He played a significant role in the development of Russian philosophy and poetry at the end of the 19th century and in the spiritual renaissance of the early 20th century.",
                BirthDate = 1853, DeathDate = 1900, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 15
            },
            new Philosopher
            {
                Id = BerdyaevId, NameRu = "Николай Бердяев", NameEn = "Nikolai Berdyaev",
                BioRu = "Русский политический и христианский философ-экзистенциалист, подчеркивавший экзистенциальное духовное значение человеческой свободы и человеческой личности.",
                BioEn = "Russian political and Christian existentialist philosopher who emphasized the existential spiritual significance of human freedom and the human person.",
                BirthDate = 1874, DeathDate = 1948, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 16
            },
            new Philosopher
            {
                Id = ShestovId, NameRu = "Лев Шестов", NameEn = "Lev Shestov",
                BioRu = "Русский философ-экзистенциалист, известный своей 'философией отчаяния' и критикой рационализма.",
                BioEn = "Russian existentialist philosopher, known for his 'philosophy of despair' and his critique of rationalism.",
                BirthDate = 1866, DeathDate = 1938, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 17
            },
            new Philosopher
            {
                Id = LosevId, NameRu = "Алексей Лосев", NameEn = "Aleksei Losev",
                BioRu = "Русский философ, филолог и культуролог, одна из самых выдающихся фигур русской философской и религиозной мысли XX века.",
                BioEn = "Russian philosopher, philologist and culturologist, one of the most prominent figures in Russian philosophical and religious thought of the 20th century.",
                BirthDate = 1893, DeathDate = 1988, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 18
            },
            new Philosopher
            {
                Id = ArendtId, NameRu = "Ханна Арендт", NameEn = "Hannah Arendt",
                BioRu = "Американский политический теоретик немецкого происхождения. Её работы посвящены природе власти, а также вопросам политики, прямой демократии, авторитета и тоталитаризма.",
                BioEn = "German-born American political theorist. Her work deals with the nature of power, and the subjects of politics, direct democracy, authority, and totalitarianism.",
                BirthDate = 1906, DeathDate = 1975, IsFemale = true,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 19
            },
            new Philosopher
            {
                Id = FoucaultId, NameRu = "Мишель Фуко", NameEn = "Michel Foucault",
                BioRu = "Французский философ, историк идей, писатель, политический активист и литературный критик. Теории Фуко в основном касаются взаимосвязи между властью и знанием, и того, как они используются в качестве формы социального контроля через общественные институты.",
                BioEn = "French philosopher, historian of ideas, writer, political activist, and literary critic. Foucault's theories primarily address the relationship between power and knowledge, and how they are used as a form of social control through societal institutions.",
                BirthDate = 1926, DeathDate = 1984, IsFemale = false,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 20
            }
        ];
    }


    public static Work[] GetWorks()
    {
        return
        [
            new Work
            {
                Id = RepublicId, NameRu = "Государство", NameEn = "The Republic",
                DescriptionRu = "Сократический диалог о справедливости, порядке и характере справедливого города-государства и справедливого человека.",
                DescriptionEn = "Socratic dialogue concerning justice, the order and character of the just city-state, and the just man.",
                PublicationYear = -375, PrimaryAuthorId = PlatoId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Interview, WikipediaId = 101 // В вашем enum есть Interview, оставляю его
            },
            new Work
            {
                Id = NicomacheanEthicsId, NameRu = "Никомахова этика", NameEn = "Nicomachean Ethics",
                DescriptionRu = "Самая известная работа Аристотеля по этике, наука о благе для человеческой жизни.",
                DescriptionEn = "Aristotle's best-known work on ethics, the science of the good for human life.",
                PublicationYear = -340, PrimaryAuthorId = AristotleId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Treatise, WikipediaId = 102
            },
            new Work
            {
                Id = CritiquePureReasonId, NameRu = "Критика чистого разума", NameEn = "Critique of Pure Reason",
                DescriptionRu = "Исследует природу человеческого разума и его пределы.",
                DescriptionEn = "Explores the nature of human reason and its limits.",
                PublicationYear = 1781,
                PrimaryAuthorId = KantId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, Type = WorkTypes.Book,
                WikipediaId = 103
            },
            new Work
            {
                Id = ThusSpokeZarathustraId, NameRu = "Так говорил Заратустра", NameEn = "Thus Spoke Zarathustra",
                DescriptionRu = "Философский роман, исследующий такие идеи, как 'смерть Бога', Сверхчеловек и воля к власти.",
                DescriptionEn = "A philosophical novel exploring ideas like the 'death of God', the Übermensch, and the will to power.",
                PublicationYear = 1883, PrimaryAuthorId = NietzscheId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 104
            },
            new Work
            {
                Id = BeingAndNothingnessId, NameRu = "Бытие и ничто", NameEn = "Being and Nothingness",
                DescriptionRu = "Эссе по феноменологической онтологии, считающееся основополагающим текстом экзистенциализма.",
                DescriptionEn = "An essay on phenomenological ontology, considered a foundational text of existentialism.",
                PublicationYear = 1943, PrimaryAuthorId = SartreId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 105
            },
            new Work
            {
                Id = SecondSexId, NameRu = "Второй пол", NameEn = "The Second Sex",
                DescriptionRu = "Подробный анализ угнетения женщин и основополагающий трактат современного феминизма.",
                DescriptionEn = "A detailed analysis of women's oppression and a foundational tract of contemporary feminism.",
                PublicationYear = 1949, PrimaryAuthorId = DeBeauvoirId, CreatedAt = DefaultTime,
                UpdatedAt = DefaultTime, Type = WorkTypes.Book, WikipediaId = 106
            },
            new Work
            {
                Id = MeditationsId, NameRu = "Размышления о первой философии", NameEn = "Meditations on First Philosophy",
                DescriptionRu = "Основополагающий текст современной философии, исследующий эпистемологическую достоверность.",
                DescriptionEn = "A foundational text of modern philosophy, exploring epistemological certainty.",
                PublicationYear = 1641, PrimaryAuthorId = DescartesId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 107
            },
            new Work
            {
                Id = EssayConcerningHumanUnderstandingId, NameRu = "Опыт о человеческом разумении", NameEn = "An Essay Concerning Human Understanding",
                DescriptionRu = "Работа, посвященная основам человеческого знания и понимания.",
                DescriptionEn = "A work concerning the foundation of human knowledge and understanding.",
                PublicationYear = 1689, PrimaryAuthorId = LockeId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 108
            },
            new Work
            {
                Id = TreatiseHumanNatureId, NameRu = "Трактат о человеческой природе", NameEn = "A Treatise of Human Nature",
                DescriptionRu = "Книга шотландского философа Дэвида Юма, которую многие считают его самой важной работой и одним из самых влиятельных произведений в истории философии.",
                DescriptionEn = "A book by Scottish philosopher David Hume, considered by many to be Hume's most important work and one of the most influential works in the history of philosophy.",
                PublicationYear = 1739, PrimaryAuthorId = HumeId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 109
            },
            new Work
            {
                Id = SpinozaEthicsId, NameRu = "Этика", NameEn = "Ethics, Demonstrated in Geometrical Order",
                DescriptionRu = "Главный труд Спинозы, философский трактат, написанный на латыни.",
                DescriptionEn = "Spinoza's magnum opus, a philosophical treatise written in Latin.",
                PublicationYear = 1677, PrimaryAuthorId = SpinozaId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 110
            },
            new Work
            {
                Id = WorldAsWillId, NameRu = "Мир как воля и представление", NameEn = "The World as Will and Representation",
                DescriptionRu = "Центральная работа немецкого философа Артура Шопенгауэра.",
                DescriptionEn = "The central work of the German philosopher Arthur Schopenhauer.",
                PublicationYear = 1818,
                PrimaryAuthorId = SchopenhauerId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 111
            },
            new Work
            {
                Id = FearAndTremblingId, NameRu = "Страх и трепет", NameEn = "Fear and Trembling",
                DescriptionRu = "Философская работа Сёрена Кьеркегора, опубликованная в 1843 году под псевдонимом Йоханнес де Силенцио.",
                DescriptionEn = "A philosophical work by Søren Kierkegaard, published in 1843 under the pseudonym Johannes de silentio.",
                PublicationYear = 1843, PrimaryAuthorId = KierkegaardId, CreatedAt = DefaultTime,
                UpdatedAt = DefaultTime, Type = WorkTypes.Book, WikipediaId = 112
            },
            new Work
            {
                Id = TractatusId, NameRu = "Логико-философский трактат", NameEn = "Tractatus Logico-Philosophicus",
                DescriptionRu = "Единственная философская работа австрийского философа Людвига Витгенштейна, опубликованная при его жизни.",
                DescriptionEn = "The only book-length philosophical work by the Austrian philosopher Ludwig Wittgenstein that was published during his lifetime.",
                PublicationYear = 1921, PrimaryAuthorId = WittgensteinId, CreatedAt = DefaultTime,
                UpdatedAt = DefaultTime, Type = WorkTypes.Book, WikipediaId = 113
            },
            new Work
            {
                Id = DostoevskyPoeticsId, NameRu = "Проблемы поэтики Достоевского", NameEn = "Problems of Dostoevsky's Poetics",
                DescriptionRu = "Крупная работа Михаила Бахтина по теории и анализу литературы.",
                DescriptionEn = "A major work of literary theory and analysis by Mikhail Bakhtin.",
                PublicationYear = 1929, PrimaryAuthorId = BakhtinId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 114
            },
            new Work
            {
                Id = GodmanhoodId, NameRu = "Чтения о богочеловечестве", NameEn = "Lectures on Godmanhood",
                DescriptionRu = "Серия лекций, излагающих софиологию Соловьева и концепцию Богочеловечества.",
                DescriptionEn = "A series of lectures outlining Solovyov's sophiology and concept of Godmanhood.",
                PublicationYear = 1881, PrimaryAuthorId = SolovyovId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Lecture, WikipediaId = 115
            },
            new Work
            {
                Id = MeaningOfHistoryId, NameRu = "Смысл истории", NameEn = "The Meaning of History",
                DescriptionRu = "Эссе Николая Бердяева по философии истории.",
                DescriptionEn = "An essay on the philosophy of history by Nikolai Berdyaev.",
                PublicationYear = 1923,
                PrimaryAuthorId = BerdyaevId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, Type = WorkTypes.Essay,
                WikipediaId = 116
            },
            new Work
            {
                Id = AthensAndJerusalemId, NameRu = "Афины и Иерусалим", NameEn = "Athens and Jerusalem",
                DescriptionRu = "Философская работа, противопоставляющая греческий рационализм иудейскому откровению.",
                DescriptionEn = "A philosophical work contrasting Greek rationalism with Hebraic revelation.",
                PublicationYear = 1938, PrimaryAuthorId = ShestovId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 117
            },
            new Work
            {
                Id = DialecticOfMythId, NameRu = "Диалектика мифа", NameEn = "The Dialectic of Myth",
                DescriptionRu = "Ключевая работа Алексея Лосева о природе мифа и его связи с сознанием и реальностью.",
                DescriptionEn = "A key work by Aleksei Losev on the nature of myth and its relation to consciousness and reality.",
                PublicationYear = 1930, PrimaryAuthorId = LosevId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 118
            },
            new Work
            {
                Id = HumanConditionId, NameRu = "Vita activa, или О деятельной жизни", NameEn = "The Human Condition",
                DescriptionRu = "Крупная работа Ханны Арендт, обсуждающая vita activa (деятельную жизнь) в противоположность vita contemplativa (созерцательной жизни).",
                DescriptionEn = "A major work by Hannah Arendt discussing the vita activa (active life) in contrast to the vita contemplativa (contemplative life).",
                PublicationYear = 1958, PrimaryAuthorId = ArendtId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 119
            },
            new Work
            {
                Id = DisciplineAndPunishId, NameRu = "Надзирать и наказывать", NameEn = "Discipline and Punish: The Birth of the Prison",
                DescriptionRu = "Анализ социальных и теоретических механизмов, стоящих за изменениями в западных пенитенциарных системах в современную эпоху.",
                DescriptionEn = "An analysis of the social and theoretical mechanisms behind the changes in Western penal systems during the modern age.",
                PublicationYear = 1975, PrimaryAuthorId = FoucaultId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                Type = WorkTypes.Book, WikipediaId = 120
            }
        ];
    }

    public static CategorySchool[] GetCategorySchools()
    {
        return
        [
            new CategorySchool
            {
                CategorySchoolId = PlatonismId, NameRu = "Платонизм", NameEn = "Platonism",
                DescriptionRu = "Философия Платона и тесно связанные с ней философские системы.",
                DescriptionEn = "The philosophy of Plato and philosophical systems closely derived from it.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = AncientGreekPhilosophyId, WikipediaId = 201
            },
            new CategorySchool
            {
                CategorySchoolId = AristotelianismId, NameRu = "Аристотелизм", NameEn = "Aristotelianism",
                DescriptionRu = "Философская традиция, черпающая свое определяющее вдохновение из работ Аристотеля.",
                DescriptionEn = "A tradition of philosophy that takes its defining inspiration from the work of Aristotle.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = AncientGreekPhilosophyId, WikipediaId = 202
            },
            new CategorySchool
            {
                CategorySchoolId = KantianismId, NameRu = "Кантианство", NameEn = "Kantianism",
                DescriptionRu = "Философия Иммануила Канта, немецкого философа.",
                DescriptionEn = "Philosophy of Immanuel Kant, a German philosopher.",
                BranchId = EpistemologyBranchId,
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, ParentCategorySchoolId = GermanIdealismId,
                WikipediaId = 203
            },
            new CategorySchool
            {
                CategorySchoolId = ExistentialismId, NameRu = "Экзистенциализм", NameEn = "Existentialism",
                DescriptionRu = "Форма философского исследования, которая исследует проблему человеческого существования и фокусируется на жизненном опыте мыслящего, чувствующего, действующего индивида.",
                DescriptionEn = "A form of philosophical inquiry that explores the problem of human existence and centers on the lived experience of the thinking, feeling, acting individual.",
                BranchId = EthicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = ContinentalPhilosophyId, WikipediaId = 204
            },
            new CategorySchool
            {
                CategorySchoolId = FeminismId, NameRu = "Феминизм", NameEn = "Feminism",
                DescriptionRu = "Ряд социально-политических движений и идеологий, направленных на определение и установление политического, экономического, личного и социального равенства полов.",
                DescriptionEn = "A range of socio-political movements and ideologies that aim to define and establish the political, economic, personal, and social equality of the sexes.",
                BranchId = EthicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 205
            },
            new CategorySchool
            {
                CategorySchoolId = RationalismId, NameRu = "Рационализм", NameEn = "Rationalism",
                DescriptionRu = "Взгляд, апеллирующий к разуму как источнику знания или оправдания.",
                DescriptionEn = "A view appealing to reason as a source of knowledge or justification.",
                BranchId = EpistemologyBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = ModernPhilosophyId, WikipediaId = 206
            },
            new CategorySchool
            {
                CategorySchoolId = EmpiricismId, NameRu = "Эмпиризм", NameEn = "Empiricism",
                DescriptionRu = "Теория, согласно которой знание происходит только или преимущественно из чувственного опыта.",
                DescriptionEn = "A theory that states that knowledge comes only or primarily from sensory experience.",
                BranchId = EpistemologyBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = ModernPhilosophyId, WikipediaId = 207
            },
            new CategorySchool
            {
                CategorySchoolId = StoicismId, NameRu = "Стоицизм", NameEn = "Stoicism",
                DescriptionRu = "Школа эллинистической философии, основанная Зеноном из Китиона в Афинах в начале III века до н.э.",
                DescriptionEn = "A school of Hellenistic philosophy founded by Zeno of Citium in Athens in the early 3rd century BC.",
                BranchId = EthicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = AncientGreekPhilosophyId, WikipediaId = 208
            },
            new CategorySchool
            {
                CategorySchoolId = GermanIdealismId, NameRu = "Немецкий идеализм", NameEn = "German Idealism",
                DescriptionRu = "Философское движение, возникшее в Германии в конце XVIII - начале XIX веков.",
                DescriptionEn = "A philosophical movement that emerged in Germany in the late 18th and early 19th centuries.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = ModernPhilosophyId, WikipediaId = 209
            },
            new CategorySchool
            {
                CategorySchoolId = PhenomenologyId, NameRu = "Феноменология", NameEn = "Phenomenology",
                DescriptionRu = "Исследование структур сознания, переживаемых с точки зрения первого лица.",
                DescriptionEn = "The study of structures of consciousness as experienced from the first-person point of view.",
                BranchId = EpistemologyBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = ContinentalPhilosophyId, WikipediaId = 210
            },
            new CategorySchool
            {
                CategorySchoolId = LogicalPositivismId, NameRu = "Логический позитивизм", NameEn = "Logical Positivism",
                DescriptionRu = "Движение в западной философии, центральным тезисом которого был принцип верификации.",
                DescriptionEn = "A movement in Western philosophy whose central thesis was the verification principle.",
                BranchId = LogicBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = AnalyticPhilosophyId, WikipediaId = 211
            },
            new CategorySchool
            {
                CategorySchoolId = RussianReligiousPhilosophyId, NameRu = "Русская религиозная философия", NameEn = "Russian Religious Philosophy",
                DescriptionRu = "Самобытная школа мысли, возникшая в России в XIX - начале XX веков.",
                DescriptionEn = "A distinctive school of thought that emerged in Russia in the 19th and early 20th centuries.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 212
            },
            new CategorySchool
            {
                CategorySchoolId = PostStructuralismId, NameRu = "Постструктурализм", NameEn = "Post-structuralism",
                DescriptionRu = "Термин для философских и литературных форм теории, которые одновременно основываются на идеях структурализма и отвергают их.",
                DescriptionEn = "A term for philosophical and literary forms of theory that both build upon and reject ideas established by structuralism.",
                BranchId = EpistemologyBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = ContinentalPhilosophyId, WikipediaId = 213
            },
            new CategorySchool
            {
                CategorySchoolId = AncientGreekPhilosophyId, NameRu = "Древнегреческая философия", NameEn = "Ancient Greek Philosophy",
                DescriptionRu = "Философия в Древней Греции, с VI века до н.э. до эллинистического периода.",
                DescriptionEn = "Philosophy in Ancient Greece, from the 6th century BC to the Hellenistic period.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 214
            },
            new CategorySchool
            {
                CategorySchoolId = ModernPhilosophyId, NameRu = "Философия Нового времени", NameEn = "Modern Philosophy",
                DescriptionRu = "Философия, развивавшаяся в западном мире в ранний современный период (примерно XVII-XIX века).",
                DescriptionEn = "Philosophy developed in the Western world during the early modern period (roughly 17th to 19th centuries).",
                BranchId = EpistemologyBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 215
            },
            new CategorySchool
            {
                CategorySchoolId = ContinentalPhilosophyId, NameRu = "Континентальная философия", NameEn = "Continental Philosophy",
                DescriptionRu = "Совокупность традиций философии XIX и XX веков из континентальной Европы.",
                DescriptionEn = "A set of traditions of 19th and 20th-century philosophy from mainland Europe.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 216
            },
            new CategorySchool
            {
                CategorySchoolId = AnalyticPhilosophyId, NameRu = "Аналитическая философия", NameEn = "Analytic Philosophy",
                DescriptionRu = "Традиция философии, характеризующаяся акцентом на ясность, аргументацию и формальную логику.",
                DescriptionEn = "A tradition of philosophy characterized by an emphasis on clarity, argument, and formal logic.",
                BranchId = LogicBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 217
            },
            new CategorySchool
            {
                CategorySchoolId = ScholasticismId, NameRu = "Схоластика", NameEn = "Scholasticism",
                DescriptionRu = "Метод критического мышления, который доминировал в преподавании академиков (схоластов, или школяров) средневековых университетов Европы примерно с 1100 по 1700 год.",
                DescriptionEn = "A method of critical thought which dominated teaching by the academics (scholastics, or schoolmen) of medieval universities in Europe from about 1100 to 1700.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 218
            },
            new CategorySchool
            {
                CategorySchoolId = IdealismId, NameRu = "Идеализм", NameEn = "Idealism",
                DescriptionRu = "Группа метафизических философий, утверждающих, что реальность, или реальность, какой ее могут познать люди, фундаментально ментальна, ментально сконструирована или иным образом нематериальна.",
                DescriptionEn = "The group of metaphysical philosophies that assert that reality, or reality as humans can know it, is fundamentally mental, mentally constructed, or otherwise immaterial.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime,
                ParentCategorySchoolId = GermanIdealismId, WikipediaId = 219
            },
            new CategorySchool
            {
                CategorySchoolId = RealismId, NameRu = "Реализм", NameEn = "Realism",
                DescriptionRu = "Убеждение, что реальность существует независимо от наблюдателей.",
                DescriptionEn = "The belief that reality exists independently of observers.",
                BranchId = MetaphysicsBranchId, CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 220
            }
        ];
    }

    public static Notion[] GetNotions()
    {
        return
        [
            new Notion
            {
                NotionId = FormsId, NameRu = "Теория форм", NameEn = "Theory of Forms",
                DescriptionRu = "Теория Платона о том, что физический мир не так реален или истинен, как вневременные, абсолютные, неизменные идеи.",
                DescriptionEn = "Plato's theory that the physical world is not as real or true as timeless, absolute, unchangeable ideas.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 301
            },
            new Notion
            {
                NotionId = CategoricalImperativeId, NameRu = "Категорический императив", NameEn = "Categorical Imperative",
                DescriptionRu = "Центральное философское понятие Канта в его деонтологической моральной философии.",
                DescriptionEn = "Kant's central philosophical concept in his deontological moral philosophy.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 302
            },
            new Notion
            {
                NotionId = UbermenschId, NameRu = "Сверхчеловек", NameEn = "Übermensch",
                DescriptionRu = "Концепция Ницше о цели, которую человечество должно поставить перед собой.",
                DescriptionEn = "Nietzsche's concept of a goal for humanity to set for itself.",
                CreatedAt = DefaultTime,
                UpdatedAt = DefaultTime, WikipediaId = 303
            },
            new Notion
            {
                NotionId = DaseinId, NameRu = "Дазайн", NameEn = "Dasein",
                DescriptionRu = "Термин Хайдеггера для 'бытия-здесь' или 'присутствия', относящийся к человеческому способу бытия.",
                DescriptionEn = "Heidegger's term for 'being-there' or 'presence', referring to the human way of being.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 304
            },
            new Notion
            {
                NotionId = TabulaRasaId, NameRu = "Чистая доска", NameEn = "Tabula Rasa",
                DescriptionRu = "Теория Локка о том, что индивиды рождаются без встроенного ментального содержания, и поэтому все знания приходят из опыта или восприятия.",
                DescriptionEn = "Locke's theory that individuals are born without built-in mental content and that therefore all knowledge comes from experience or perception.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 305
            },
            new Notion
            {
                NotionId = CogitoErgoSumId, NameRu = "Мыслю, следовательно, существую", NameEn = "Cogito, ergo sum",
                DescriptionRu = "Знаменитое философское утверждение Декарта: 'Я мыслю, следовательно, я существую'.",
                DescriptionEn = "Descartes' famous philosophical proposition: 'I think, therefore I am'.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 306
            },
            new Notion
            {
                NotionId = SocialContractId, NameRu = "Общественный договор", NameEn = "Social Contract",
                DescriptionRu = "Теория или модель, возникшая в эпоху Просвещения и обычно касающаяся легитимности власти государства над индивидом.",
                DescriptionEn = "A theory or model that originated during the Age of Enlightenment and usually concerns the legitimacy of the authority of the state over the individual.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 307
            },
            new Notion
            {
                NotionId = WillToPowerId, NameRu = "Воля к власти", NameEn = "Will to Power",
                DescriptionRu = "Выдающаяся концепция в философии Фридриха Ницше, описывающая то, что он считал главной движущей силой в людях.",
                DescriptionEn = "A prominent concept in the philosophy of Friedrich Nietzsche, describing what he believed to be the main driving force in humans.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 308
            },
            new Notion
            {
                NotionId = AlienationId, NameRu = "Отчуждение", NameEn = "Alienation",
                DescriptionRu = "Состояние в социальных отношениях, отражающееся низкой степенью интеграции или общих ценностей и высокой степенью дистанции или изоляции между индивидами, или между индивидом и группой людей в сообществе или рабочей среде.",
                DescriptionEn = "A condition in social relationships reflected by a low degree of integration or common values and a high degree of distance or isolation between individuals, or between an individual and a group of people in a community or work environment.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 309
            },
            new Notion
            {
                NotionId = AuthenticityId, NameRu = "Аутентичность", NameEn = "Authenticity",
                DescriptionRu = "Понятие в психологии, экзистенциальной философии и эстетике, касающееся степени, в которой действия индивида соответствуют его убеждениям и желаниям, несмотря на внешнее давление.",
                DescriptionEn = "A concept in psychology, existentialist philosophy and aesthetics concerning the degree to which an individual's actions are congruent with their beliefs and desires, despite external pressures.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 310
            },
            new Notion
            {
                NotionId = AporiaId, NameRu = "Апория", NameEn = "Aporia",
                DescriptionRu = "В философии — неразрешимое внутреннее противоречие или логическая дизъюнкция в тексте, аргументе или теории.",
                DescriptionEn = "In philosophy, an irresolvable internal contradiction or logical disjunction in a text, argument, or theory.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 311
            },
            new Notion
            {
                NotionId = SyllogismId, NameRu = "Силлогизм", NameEn = "Syllogism",
                DescriptionRu = "Вид логического аргумента, который применяет дедуктивное рассуждение для получения вывода на основе двух или более утверждений, которые утверждаются или предполагаются истинными.",
                DescriptionEn = "A kind of logical argument that applies deductive reasoning to arrive at a conclusion based on two or more propositions that are asserted or assumed to be true.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 312
            },
            new Notion
            {
                NotionId = MonadId, NameRu = "Монада", NameEn = "Monad",
                DescriptionRu = "В философии Лейбница — элементарная индивидуальная субстанция, которая отражает вселенную с определенной точки зрения и подчиняется своим собственным внутренним законам развития.",
                DescriptionEn = "In Leibniz's philosophy, an elementary individual substance that reflects the universe from a specific viewpoint and is subject to its own internal laws of development.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 313
            },
            new Notion
            {
                NotionId = NoemaId, NameRu = "Ноэма", NameEn = "Noema",
                DescriptionRu = "В феноменологии Гуссерля — объект или содержание мысли, суждения или восприятия, но как оно подразумевается или имеется в виду в этой мысли.",
                DescriptionEn = "In Husserl's phenomenology, the object or content of a thought, judgment, or perception, but as it is meant or intended in that thought.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 314
            },
            new Notion
            {
                NotionId = SobornostId, NameRu = "Соборность", NameEn = "Sobornost",
                DescriptionRu = "Духовная общность многих совместно живущих людей, ключевое понятие в русской религиозной философии.",
                DescriptionEn = "A spiritual community of many jointly living people, a key concept in Russian religious philosophy.",
                CreatedAt = DefaultTime, UpdatedAt = DefaultTime, WikipediaId = 315
            }
        ];
    }

    public static RelatedNotion[] GetRelatedNotions()
    {
        return
        [
            new RelatedNotion
                { NotionIdFrom = UbermenschId, NotionIdTo = WillToPowerId, RelationshipType = "RelatedConcept" },
            new RelatedNotion
                { NotionIdFrom = DaseinId, NotionIdTo = AuthenticityId, RelationshipType = "RelatedConcept" },
        ];
    }
}
