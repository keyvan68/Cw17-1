using Cw17_1.Models;
using Cw17_1.Models.ViewModels;
using Cw17_1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cw17_1.Controllers
{
    public class AdrressController : Controller
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IUserRepository _userRepository;
        public AdrressController(IAddressRepository addressRepository, IUserRepository userRepository)
        {
            _addressRepository = addressRepository;
            _userRepository = userRepository;   
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            ViewBag.UserId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddressViewModel adrress)
        {
            _addressRepository.Create(adrress);
            return RedirectToAction("Index","User");
        }
    }
}
