using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;

namespace IS_5.Model
{ 
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Locality Locality { get; set; }
        public Organization Organization { get; set; }
        public UserPrivilege Privilege { get; set; }

        public User(string log, string pass, Locality locality, Organization organization, UserPrivilege privilege) 
        {
            Login = log;
            Password = pass;
            Locality = locality;
            Organization = organization;
            Privilege = privilege;
        }
    }
}