using Microsoft.AspNetCore.Http;
using SalesSystem.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace SalesSystem.Api.Extensions
{
    public class AspNetUser : IUser
    {
        private readonly IHttpContextAccessor _accessor;

        public AspNetUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Name => _accessor.HttpContext.User.Identity.Name;

        public Guid GetUserId()
        {
            return IsAuthenticated() ? Guid.Parse(_accessor.HttpContext.User.GetUserId()) : Guid.Empty;
        }

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            throw new NotImplementedException();
        }

        public string GetUserEmail()
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
