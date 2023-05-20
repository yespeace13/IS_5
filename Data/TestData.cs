using IS_5.Model;
using System.Collections.Generic;

namespace IS_5
{
    public static class TestData
    {
        public static Dictionary<int, Organization> Organizations { get; set; }
        public static Dictionary<int, TypeOrganization> TypeOrganizations { get; set; }
        public static Dictionary<int, TypeOwnerOrganization> TypeOwnerOrganizations { get; set; }

        private static void CreateTypeOwnerOrganizations()
        {
            TypeOwnerOrganizations = new Dictionary<int, TypeOwnerOrganization>
            {
                {1, new TypeOwnerOrganization("Индивидуальный предприниматель") },
                {2, new TypeOwnerOrganization("Юридическое лицо")}
            };
        }
        static TestData()
        {
            CreateTypeOrganizations();
            CreateTypeOwnerOrganizations();
            CreateOrganizations();
        }

        private static void CreateTypeOrganizations()
        {
            TypeOrganizations = new Dictionary<int, TypeOrganization>
            {
                { 1, new TypeOrganization("Значения справочника")},
                { 2, new TypeOrganization("Исполнительный орган государственной власти")},
                { 3, new TypeOrganization("Орган местного самоуправления")},
                { 4, new TypeOrganization("Организация по отлову")},
                { 5, new TypeOrganization("Организация по отлову и приют")},
                { 6, new TypeOrganization("Организация по транспортировке")},
                { 7, new TypeOrganization("Ветеринарная клиника: государственная")},
                { 8, new TypeOrganization("Ветеринарная клиника: муниципальная")},
                { 9, new TypeOrganization("Ветеринарная клиника: частная")},
                { 10, new TypeOrganization("Благотворительный фонд")},
                { 11, new TypeOrganization("Организации по продаже товаров и предоставлению услуг для животных")},
                { 12, new TypeOrganization("Заявитель (для регистрации представителя юридического лица, подающего заявку на отлов)")}
            };
        }

        private static void CreateOrganizations()
        {
            Organizations = new Dictionary<int, Organization>
            {
                { 1, new Organization("Организация1", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[1]) },
                { 2, new Organization("Организация2", "123", "123", "1234", TypeOrganizations[2], TypeOwnerOrganizations[2]) },
                { 3, new Organization("Организация3", "123", "123", "1234", TypeOrganizations[3], TypeOwnerOrganizations[1]) },
                { 4, new Organization("Организация4", "123", "123", "1234", TypeOrganizations[4], TypeOwnerOrganizations[2]) },
                { 5, new Organization("Организация5", "123", "123", "1234", TypeOrganizations[5], TypeOwnerOrganizations[1]) },
                { 6, new Organization("Организация6", "123", "123", "1234", TypeOrganizations[9], TypeOwnerOrganizations[1]) },
                { 7, new Organization("Организация7", "123", "123", "1234", TypeOrganizations[8], TypeOwnerOrganizations[2]) },
                { 8, new Organization("Организация8", "123", "123", "1234", TypeOrganizations[2], TypeOwnerOrganizations[1]) },
                { 9, new Organization("Организация9", "123", "123", "1234", TypeOrganizations[6], TypeOwnerOrganizations[1]) },
                { 10, new Organization("Организация10", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[2]) },
                { 11, new Organization("Организация11", "123", "123", "1234", TypeOrganizations[6], TypeOwnerOrganizations[1]) },
                { 12, new Organization("Организация12", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[1]) },
                { 13, new Organization("Организация13", "123", "123", "1234", TypeOrganizations[5], TypeOwnerOrganizations[1]) },
                { 14, new Organization("Организация14", "123", "123", "1234", TypeOrganizations[7], TypeOwnerOrganizations[1]) },
                { 15, new Organization("Организация15", "123", "123", "1234", TypeOrganizations[11], TypeOwnerOrganizations[1]) },
                { 16, new Organization("Организация16", "123", "123", "1234", TypeOrganizations[10], TypeOwnerOrganizations[2]) },
                { 17, new Organization("Организация17", "123", "123", "1234", TypeOrganizations[11], TypeOwnerOrganizations[2]) },
                { 18, new Organization("Организация18", "123", "123", "1234", TypeOrganizations[1], TypeOwnerOrganizations[1]) },
                { 19, new Organization("Организация19", "123", "123", "1234", TypeOrganizations[5], TypeOwnerOrganizations[1]) },
                { 20, new Organization("Организация20", "123", "123", "1234", TypeOrganizations[6], TypeOwnerOrganizations[2]) }
            };
        }
    }
}
