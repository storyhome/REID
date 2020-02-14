using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REID.APPL.Models;
using REID.APPL.Services;

namespace REID.APPL.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMailService _mailService;

        public ContactController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("treid@aol.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
               ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            
            return View();
        }
    }
}