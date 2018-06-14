using System.Web.Mvc;

namespace AMA.ERegister.WebApi.Areas.AdminPage
{
    public class AdminPageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminPage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminPage_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "AMA.ERegister.WebApi.Areas.AdminPage.Controllers" }
            );
        }
    }
}