using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = dm.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            dm.TInsert(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = dm.TGetByID(id);
            dm.TDelete(values); 
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = dm.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            dm.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
