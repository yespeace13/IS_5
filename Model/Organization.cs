using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IS_5.Model
{
    public class Organization
    {
        public string Name { get; set; }
        public string TaxIdenNum { get; set; }
        public string KPP { get; set; }
        public string Address { get; set; }
        public string TypeOrganization { get; set; }

        public string TypeOwnerOrganization { get; set; }

        public Organization(
            string name, string taxIdenNum, string kpp, string address, 
            string typeOrganizations, string typeOwnerOrganization) 
        {
            Name = name;
            TaxIdenNum = taxIdenNum;
            KPP = kpp;
            Address = address;
            TypeOrganization = typeOrganizations;
            TypeOwnerOrganization = typeOwnerOrganization;
        }
        
    }

    //public enum TypeOrganizations
    //{
        

    //}

    public static class TypeOrganizations
    {
        public static readonly string ReferenceValue 
            = "Значения справочника";
        public static readonly string ExecutiveBodyOfStatePower 
            = "Исполнительный орган государственной власти";
        public static readonly string LocalGovernment 
            = "Орган местного самоуправления";
        public static readonly string Shelter = "Приют";
        public static readonly string CapturingOrganization 
            = "Организация по отлову";
        public static readonly string CaptureOrganizationAndShelter 
            = "Организация по отлову и приют";
        public static readonly string TransportOrganization 
            = "Организация по транспортировке";
        public static readonly string VeterinaryClinicState 
            = "Ветеринарная клиника: государственная";
        public static readonly string VeterinaryClinicMunicipal 
            = "Ветеринарная клиника: муниципальная";
        public static readonly string VeterinaryClinicPrivate 
            = "Ветеринарная клиника: частная";
        public static readonly string CharitableFoundation 
            = "Благотворительный фонд";
        public static readonly string OrganizationsSelling 
            = "Организации по продаже товаров и предоставлению услуг для животных";
        public static readonly string Applicant 
            = "Заявитель (для регистрации представителя юридического лица, подающего заявку на отлов)";
    }

    //public enum TypeOfPred
    //{
    //    Individual,
    //    second
    //}

    public static class TypeOwnerOrganization
    {
        public static readonly string IndividualEntrepreneur = "Индивидуальный предприниматель";
        public static readonly string Entity = "Юридическое лицо";
    }
}
