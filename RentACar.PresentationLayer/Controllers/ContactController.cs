﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Controllers
{
    [AllowAnonymous]

    public class ContactController : Controller
    {
        private readonly IGenericService<Message> _messageService;

        public ContactController(IGenericService<Message> messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {

            if (message.Name != null && message.Subject != null && message.Email != null && message.MessageBody != null)
            {

                ViewBag.message = "Model is valid";
                message.MessageDate = DateTime.Now;
                _messageService.TInsert(message);
                return NoContent();
            }

            return NoContent();
        }



    }
}
