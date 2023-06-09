﻿using IS_5.Model;
using IS_5.View;
using System;
using System.Linq;

namespace IS_5.Service
{
    public class AuthorizationService
    {
        private AuthorizationRepository _authorizationRepository;
        public AuthorizationService() 
        {
            _authorizationRepository = new AuthorizationRepository();
        }
        public bool GetPrivilege(string log, string pass)
        {
            var users = _authorizationRepository.GetUsers();
            var user = users.Where(u => u.Login == log && u.Password == pass).FirstOrDefault();
            if(default(User) != user)
            {
                UserSession.User = user;
                return true;
            }
            else return false;
        }
    }
}