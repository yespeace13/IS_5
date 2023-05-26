using IS_5.Model;
using IS_5.Service;
using IS_5.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5.Controler
{
    public class AuthorizationController
    {
        private AuthorizationService _service;
        public AuthorizationController() 
        {
            _service = new AuthorizationService();
        }
        public bool GetPrivilege(string log, string pass)
        {
            return _service.GetPrivilege(log, pass);
        }
    }
}
