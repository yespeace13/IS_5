using IS_5.Model;
using System;
using System.Collections.Generic;

namespace IS_5
{
    public static class TestData
    {
        public static List<Organization> Organizations { get; set; }
        public static List<TypeOrganization> TypeOrganizations { get; set; }
        public static List<TypeOwnerOrganization> TypeOwnerOrganizations { get; set; }
        public static List<User> Users { get; set; }
        public static List<Locality> Localitys { get; set; }
        public static List<Role> Roles { get; set; }

        public static List<Act> Acts { get; set; }
        public static List<Contract> Contracts { get; set; }

        public static List<Plan> Plans { get; set; }
        public static List<List<ContentPlan>> ContentPlans { get; set; }

        static TestData()
        {
            CreateTypeOrganizations();
            CreateTypeOwnerOrganizations();
            CreateLocalitys();
            CreateOrganizations();
            CreateRoles();
            CreateUsers();
            CreateContracts();
            CreateContentPlans();
            CreatePlans();
            CreateActs();
        }

        private static void CreateActs()
        {
            var animals = new List<Animal>
            {
                new Animal(1, "category", true, "breed", 45, "wool", null, null, null, null, "fdfds", "125623", Localitys[0], null)
            };

            Acts = new List<Act>
            {
                new Act(1, animals, Organizations[5], new DateTime(2022,11,28), null)
            };
            Contracts[0].Acts.Add(Acts[0]);
        }

        private static void CreateContracts()
        {
            Contracts = new List<Contract>
            {
                new Contract(1, "1234", DateTime.Now, new DateTime(2023, 12, 31), Organizations[1], Organizations[2],
                    new List<Localityprice>()
                    {
                        new Localityprice(1, Localitys[0], 5000),
                        new Localityprice(2, Localitys[1], 25000),
                        new Localityprice(3, Localitys[2], 10000)
                    },
                    new List<Scan>()
                    {
                        new Scan(1, "C:\\Users\\1\\Desktop\\img.jpg"),
                        new Scan(2, "C:\\Users\\1\\Desktop\\-с-руководителем-1-ba6d559b.png")
                    }),
                new Contract(2, "5468864", new DateTime(2022, 12, 31), new DateTime(2023, 12, 31), Organizations[7], Organizations[5],
                    new List<Localityprice>()
                    {
                        new Localityprice(1, Localitys[0], 5000),
                        new Localityprice(2, Localitys[2], 25000),
                        new Localityprice(3, Localitys[1], 10000)
                    },
                    new List<Scan>()
                    {
                        new Scan(1, "C:\\Users\\1\\Desktop\\img.jpg"),
                        new Scan(2, "C:\\Users\\1\\Desktop\\-с-руководителем-1-ba6d559b.png")
                    })
            };
        }

        private static void CreateLocalitys()
        {
            Localitys = new List<Locality>
            {
                { new Locality(1, "Тюменский муниципальный район") },
                { new Locality(2, "Сорокинский муниципальный район") },
                { new Locality(3, "Ялуторовский муниципальный район") }
            };
        }
        private static void CreateRoles()
        {
            Roles = new List<Role>
            {
                {
                    new Role(1, "Куратор ВетСлужбы",
                        new Tuple<Restrictions, Possibilities[]>(
                            //Что будет отображать датагрид
                            Restrictions.All,
                            //Что он может делать на форме
                            new Possibilities[] {Possibilities.OpenAndEdit}),
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.All, null),
                        new Tuple<Restrictions, Possibilities[], int[]>(Restrictions.All, null, null),
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.All, null))
                },
                {
                    new Role(2, "Оператор ВетСлужбы",
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.All,
                            new Possibilities[] {Possibilities.OpenAndEdit}),
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.All, null),
                        new Tuple<Restrictions, Possibilities[], int[]>(Restrictions.All,
                            new Possibilities[]
                            {
                                Possibilities.Add, Possibilities.Delete, Possibilities.Change,
                                Possibilities.AddFile, Possibilities.DelFile
                            },
                            new int[]{ 2, 3, 7}),
                        new Tuple<Restrictions, Possibilities[]>(
                            Restrictions.All, null))
                },
                {
                    new Role(3, "Оператор ОМСУ",
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.Locality,
                            new Possibilities[] { Possibilities.OpenAndEdit }),
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.Locality, null),
                        new Tuple<Restrictions, Possibilities[], int[]>(Restrictions.Locality,
                            new Possibilities[]
                            {
                                Possibilities.Add, Possibilities.Delete, Possibilities.Change,
                                Possibilities.AddFile, Possibilities.DelFile
                            },
                            new int[]{ 4, 5, 6, 7, 9, 10, 11}),
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.Locality,
                            new Possibilities[]
                            {
                                Possibilities.Add, Possibilities.Change, Possibilities.Delete,
                                Possibilities.AddFile, Possibilities.DelFile
                            }))
                },
                {
                    new Role(4, "Оператор по отлову",
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.Locality,
                            new Possibilities[] { Possibilities.OpenAndEdit, Possibilities.Add, Possibilities.Delete }),
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.Locality, new Possibilities[]
                        {
                            Possibilities.Add, Possibilities.Delete, Possibilities.Change,
                                Possibilities.AddFile, Possibilities.DelFile
                            }))
                    
                        }),
                        new Tuple<Restrictions, Possibilities[], int[]>(Restrictions.None, null, null),
                        new Tuple<Restrictions, Possibilities[]>(Restrictions.None, null))
                }

            };
        }

        private static void CreateUsers()
        {
            Users = new List<User>
            {
                { new User(1, "User1", "1234", Localitys[0], null, Roles[0]) },
                { new User(2, "User2", "1234", null, null, Roles[1])},
                { new User(3, "User3", "1234", Localitys[2], null, Roles[2])},
                { new User(4, "User4", "1234", null, Organizations[5], Roles[3])}
            };
        }

        private static void CreateTypeOrganizations()
        {
            TypeOrganizations = new List<TypeOrganization>
            {
                { new TypeOrganization(1, "Значения справочника")},
                { new TypeOrganization(2, "Исполнительный орган государственной власти")},
                { new TypeOrganization(3, "Орган местного самоуправления") },
                { new TypeOrganization(4, "Организация по отлову") },
                { new TypeOrganization(5, "Организация по отлову и приют") },
                { new TypeOrganization(6, "Организация по транспортировке") },
                { new TypeOrganization(7, "Ветеринарная клиника: государственная")},
                { new TypeOrganization(8, "Ветеринарная клиника: муниципальная")},
                { new TypeOrganization(9, "Ветеринарная клиника: частная")},
                { new TypeOrganization(10, "Благотворительный фонд")},
                { new TypeOrganization(11, "Организации по продаже товаров и предоставлению услуг для животных")},
                { new TypeOrganization(12, "Заявитель (для регистрации представителя юридического лица, подающего заявку на отлов)")}
            };
        }

        private static void CreateOrganizations()
        {
            Organizations = new List<Organization>
            {
                { new Organization(1, "Организация1", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[0], Localitys[1])},
                { new Organization(2, "Организация2", "123", "123", "1234", TypeOrganizations[2], TypeOwnerOrganizations[1], Localitys[0]) },
                { new Organization(3, "Организация3", "123", "123", "1234", TypeOrganizations[3], TypeOwnerOrganizations[1], Localitys[2]) },
                { new Organization(4, "Организация4", "123", "123", "1234", TypeOrganizations[4], TypeOwnerOrganizations[0], Localitys[0]) },
                { new Organization(5, "Организация5", "123", "123", "1234", TypeOrganizations[5], TypeOwnerOrganizations[0], Localitys[2]) },
                { new Organization(6, "Организация6", "123", "123", "1234", TypeOrganizations[9], TypeOwnerOrganizations[1], Localitys[1]) },
                { new Organization(7, "Организация7", "123", "123", "1234", TypeOrganizations[0], TypeOwnerOrganizations[0], Localitys[0]) },
                { new Organization(8, "Организация8", "123", "123", "1234", TypeOrganizations[2], TypeOwnerOrganizations[1], Localitys[2]) },
                { new Organization(9, "Организация9", "123", "123", "1234", TypeOrganizations[6], TypeOwnerOrganizations[1], Localitys[1]) },
                { new Organization(10, "Организация10", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[0], Localitys[1]) },
                { new Organization(11,"Организация11", "123", "123", "1234", TypeOrganizations[6], TypeOwnerOrganizations[1], Localitys[0]) },
                { new Organization(12, "Организация12", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[0], Localitys[2]) },
                { new Organization(13,"Организация13", "123", "123", "1234", TypeOrganizations[5], TypeOwnerOrganizations[1], Localitys[2]) },
                { new Organization(14, "Организация14", "123", "123", "1234", TypeOrganizations[7], TypeOwnerOrganizations[1], Localitys[2]) },
                { new Organization(15, "Организация15", "123", "123", "1234", TypeOrganizations[0], TypeOwnerOrganizations[1], Localitys[2]) },
                { new Organization(16, "Организация16", "123", "123", "1234", TypeOrganizations[10], TypeOwnerOrganizations[0], Localitys[0]) },
                { new Organization(17, "Организация17", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[0], Localitys[1]) },
                { new Organization(18, "Организация18", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[1], Localitys[2]) },
                { new Organization(19, "Организация19", "123", "123", "1234", TypeOrganizations[5], TypeOwnerOrganizations[1], Localitys[1]) },
                { new Organization(20, "Организация20", "123", "123", "1234", TypeOrganizations[6], TypeOwnerOrganizations[0], Localitys[2]) }
            };
        }
        private static void CreateTypeOwnerOrganizations()
        {
            TypeOwnerOrganizations = new List<TypeOwnerOrganization>
            {
                { new TypeOwnerOrganization(1, "Индивидуальный предприниматель") },
                { new TypeOwnerOrganization(2, "Юридическое лицо") }
            };
        }

        private static void CreateContentPlans()
        {
            ContentPlans = new List<List<ContentPlan>>
            {
                new List<ContentPlan>
                {
                    {new ContentPlan(1, Localitys[0], "Республики 120",false)},
                    {new ContentPlan(2, Localitys[0],"Республики 160",true)}
                },
                new List<ContentPlan>
                {
                    {new ContentPlan(1, Localitys[0], "Ленина 120",true)},
                    {new ContentPlan(2, Localitys[0],"Ленина 160", false)}
                }
            };
        }

        private static void CreatePlans()
        {

            Plans = new List<Plan>
            {
                {new Plan(1,2,2023,ContentPlans[0])},
                {new Plan(3,4,2022,ContentPlans[0])},
                {new Plan(2,3,2023,ContentPlans[1])}
            };
        }
    }    
}
