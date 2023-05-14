using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5.Controler
{
    
    public class OrganizationController
    {
        IOrganizationsView _view;
        Dictionary<int, Organization> organizations;
        Organization organization;
        public int CountElems { get { return organizations.Count; } }

        public OrganizationController(IOrganizationsView view)
        {
            _view = view;
            //this.organizations = organizations;
            organizations = new Dictionary<int, Organization>
            {
                { 1, new Organization("Организация1", "123", "123", "1234", TypeOrganizations.LocalGovernment, TypeOwnerOrganization.Entity) },
                { 2, new Organization("Организация2", "123", "123", "1234", TypeOrganizations.ExecutiveBodyOfStatePower, TypeOwnerOrganization.IndividualEntrepreneur) },
                { 3, new Organization("Организация3", "123", "123", "1234", TypeOrganizations.ReferenceValue, TypeOwnerOrganization.Entity) },
                { 4, new Organization("Организация4", "123", "123", "1234", TypeOrganizations.Applicant, TypeOwnerOrganization.IndividualEntrepreneur) },
                { 5, new Organization("Организация5", "123", "123", "1234", TypeOrganizations.LocalGovernment, TypeOwnerOrganization.Entity) },
                { 6, new Organization("Организация6", "123", "123", "1234", TypeOrganizations.Shelter, TypeOwnerOrganization.Entity) },
                { 7, new Organization("Организация7", "123", "123", "1234", TypeOrganizations.CaptureOrganizationAndShelter, TypeOwnerOrganization.IndividualEntrepreneur) },
                { 8, new Organization("Организация8", "123", "123", "1234", TypeOrganizations.CharitableFoundation, TypeOwnerOrganization.Entity) },
                { 9, new Organization("Организация9", "123", "123", "1234", TypeOrganizations.CharitableFoundation, TypeOwnerOrganization.Entity) },
                { 10, new Organization("Организация10", "123", "123", "1234", TypeOrganizations.VeterinaryClinicState, TypeOwnerOrganization.IndividualEntrepreneur) },
                { 11, new Organization("Организация11", "123", "123", "1234", TypeOrganizations.VeterinaryClinicPrivate, TypeOwnerOrganization.IndividualEntrepreneur) },
                { 12, new Organization("Организация12", "123", "123", "1234", TypeOrganizations.VeterinaryClinicMunicipal, TypeOwnerOrganization.IndividualEntrepreneur) },
                { 13, new Organization("Организация13", "123", "123", "1234", TypeOrganizations.TransportOrganization, TypeOwnerOrganization.Entity) },
                { 14, new Organization("Организация14", "123", "123", "1234", TypeOrganizations.ReferenceValue, TypeOwnerOrganization.Entity) },
                { 15, new Organization("Организация15", "123", "123", "1234", TypeOrganizations.CharitableFoundation, TypeOwnerOrganization.Entity) },
                { 16, new Organization("Организация16", "123", "123", "1234", TypeOrganizations.CharitableFoundation, TypeOwnerOrganization.Entity) },
                { 17, new Organization("Организация17", "123", "123", "1234", TypeOrganizations.LocalGovernment, TypeOwnerOrganization.Entity) },
                { 18, new Organization("Организация18", "123", "123", "1234", TypeOrganizations.LocalGovernment, TypeOwnerOrganization.Entity) },
                { 19, new Organization("Организация19", "123", "123", "1234", TypeOrganizations.Applicant, TypeOwnerOrganization.Entity) },
                { 20, new Organization("Организация20", "123", "123", "1234", TypeOrganizations.CharitableFoundation, TypeOwnerOrganization.Entity) }
            };
            //this.organization = organization;
            view.SetController(this);
        }

        public void LoadView(int sizePage = 15, int page = 1)
        {
            _view.ClearGrid();
            //foreach (var org in organizations)
            //    _view.AddOrganizationToGrid(org.Key, org.Value);
            int maxElem = sizePage * page < organizations.Count ? sizePage * page : organizations.Count;
            int minElem = sizePage * (page - 1);
            for (int i = minElem; i < maxElem; i++)
            {
                _view.AddOrganizationToGrid(organizations.ElementAt(i).Key, organizations.ElementAt(i).Value);
            }
        }

    }
}
