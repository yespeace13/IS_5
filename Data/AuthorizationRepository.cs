using IS_5.Model;
using System;
using System.Collections.Generic;

namespace IS_5
{
    public class AuthorizationRepository
    {
        public Dictionary<int, User> GetUsers()
        {
            return TestData.Users;
        }
    }
}