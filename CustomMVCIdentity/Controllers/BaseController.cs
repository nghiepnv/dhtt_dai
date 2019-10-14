using IdentityManagement.Entities;
using IdentityManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace CustomMVCIdentity.Controllers
{

    public class BaseController : Controller
    {
        #region --Load from web.config--
        public string SupperAdminAccount = WebConfigurationManager.AppSettings["SupperAdminAccount"];
        #endregion       
        #region GetCurrent
        public ApplicationUser CurrentUser
        {
            get
            {
                return new Auth().GetCurrentUser();
            }
        }
        public List<string> CurrentRoles
        {
            get
            {
                return new Auth().GetCurrentRoles();
            }
        }
        #endregion
        #region Message - After reload page -
        public void ShowMessageSuccess(string msg)
        {
            msg = HttpUtility.UrlEncode(msg);
            var cookie = new HttpCookie("MessageSuccess");
            cookie.Value = msg;
            Response.Cookies.Add(cookie);
        }
        public void ShowMessageError(string msg)
        {
            msg = HttpUtility.UrlEncode(msg);
            var cookie = new HttpCookie("MessageError");
            cookie.Value = msg;
            Response.Cookies.Add(cookie);
        }
        public void RemoveMessage()
        {
            var cookie = new HttpCookie("MessageSuccess");
            cookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(cookie);

            var cookie2 = new HttpCookie("MessageError");
            cookie2.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(cookie2);
        }
        #endregion
        #region ViewBase
        public ActionResult NotFound()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
        public ActionResult AccessDenied()
        {
            return View("~/Views/Shared/AccessDenied.cshtml");
        }
        #endregion
        #region Auth
        public bool CheckSupperAdmin()
        {
            if (CurrentUser == null)
            {
                return false;
            }
            if (CurrentRoles.Contains(RoleList.SuperAdmin) || CurrentUser.Email.Equals(SupperAdminAccount))
            {
                return true;
            }
            else
                return false;
        }
        public bool CheckContentAdmin()
        {
            if (CurrentUser == null)
            {
                return false;
            }
            if (CurrentRoles.Contains(RoleList.ContentAdmin))
            {
                return true;
            }
            else
                return false;
        }
        #endregion
        protected void HandleApplicationException(ApplicationException ex)
        {
            ViewBag.Exception = ex;
            RedirectToAction("NotFound", "Base");
        }
        protected void HandleException(Exception ex)
        {
            ViewBag.Exception = ex;
            RedirectToAction("NotFound", "Base");
        }
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            return base.BeginExecuteCore(callback, state);
        }
    }
}