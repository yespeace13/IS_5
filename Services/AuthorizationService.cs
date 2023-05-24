using IS_5.Model;
using IS_5.View;
using System;

namespace IS_5.Service
{
    public class AuthorizationService
    {
        private AuthorizationRepository _authorizationRepository;
        public AuthorizationService() 
        {
            _authorizationRepository = new AuthorizationRepository();
        }
        public User GetPrivilege(string log, string pass)
        {
            var users = _authorizationRepository.GetUsers();
            User user = null;
            foreach (var u in users) 
            {
                if(log == u.Value.Login && pass == u.Value.Password)
                    user = u.Value;
            }
            return user;
        }
    }
}