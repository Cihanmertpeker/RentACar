using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.DtoLayer.DTOs.ContactDtos;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class ContactController : Controller
    {
        private readonly IGenericService<Contact> _contactService;
        private readonly IMapper _mapper;

        public ContactController(IGenericService<Contact> contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var contacts = _contactService.TGetList();
            var values = _mapper.Map<List<ContactDto>>(contacts);
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            _contactService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(ContactDto contactDto)
        {
            var newContact = _mapper.Map<Contact>(contactDto);
            _contactService.TInsert(newContact);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateContact(int id)
        {
            var contact = _contactService.TGetByID(id);
            var value = _mapper.Map<ContactDto>(contact);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(ContactDto contactDto)
        {
            var updateContact = _mapper.Map<Contact>(contactDto);
            _contactService.TUpdate(updateContact);
            return RedirectToAction("Index");
        }
    }
}
