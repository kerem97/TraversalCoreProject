using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;
        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TInsert(new ContactUs()
                {
                    Content = model.MessageBody,
                    Mail = model.Mail,
                    Status = true,
                    Name = model.Name,
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index", "Default");
            }
            return View(model);
        }
    }
}
