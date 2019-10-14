using IdentityManagement.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomMVCIdentity.Controllers
{
    public class Auth
    {
        public ApplicationUser GetCurrentUser()
        {
            try
            {
                var id = System.Threading.Thread.CurrentPrincipal.Identity.GetUserId();
                var user = IdentityManagement.DAL.UserController.GetUser(id);
                return user;
            }
            catch
            {
                return null;
            }
        }
        public HttpContext GetCurrentContext()
        {
            return HttpContext.Current;
        }
        public List<string> GetCurrentRoles()
        {
            try
            {
                var user = GetCurrentUser();
                return IdentityManagement.DAL.UserRoleController.GetUserRoles(user.Id).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}