using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TInsert(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())


                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetByID(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnnocuncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetByID(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnocuncement(AnnouncementUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {

                    AnnouncementID = model.AnnouncementID,
                    Content = model.Content,
                    Title = model.Title,
                    AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())

                });
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
