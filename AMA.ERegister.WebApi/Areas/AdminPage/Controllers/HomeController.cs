namespace AMA.ERegister.WebApi.Areas.AdminPage.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    [Authorize(Roles = "SupperAdmin")]
    public class HomeController : AdminBaseController
    {
        // GET: AdminPage/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}