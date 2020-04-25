using SalesSystem.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace SalesSystem.Api.Extensions
{
    public class AspNetUser : IUser
    {
        public string Name => throw new NotImplementedException();

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            throw new NotImplementedException();
        }

        public string GetUserEmail()
        {
            throw new NotImplementedException();
        }

        public Guid GetUserId()
        {
            throw new NotImplementedException();
        }

        public bool IsAuthenticated()
        {
            throw new NotImplementedException();
        }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}
