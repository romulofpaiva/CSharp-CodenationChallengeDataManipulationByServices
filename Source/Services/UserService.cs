using System;
using System.Linq;
using System.Collections.Generic;
using Codenation.Challenge.Models;

namespace Codenation.Challenge.Services
{
    public class UserService : IUserService
    {
        CodenationContext codenationContext;

        public UserService(CodenationContext context)
        {
            codenationContext = context;
        }

        public IList<User> FindByAccelerationName(string name)
        {
            throw new System.NotImplementedException();
        }

        public IList<User> FindByCompanyId(int companyId)
        {
            throw new System.NotImplementedException();

            // return codenationContext.Users
            //     .Where(  )
            //     .ToList();
        }

        public User FindById(int id)
        {
            return codenationContext.Users.Find(id);
        }

        public User Save(User user)
        {
            codenationContext.Users.Add(user);
            codenationContext.SaveChanges();

            return user;
        }
    }
}
