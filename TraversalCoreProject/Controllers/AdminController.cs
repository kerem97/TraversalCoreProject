using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialAppBrandDemo()
        {
            return PartialView();
        }

        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
