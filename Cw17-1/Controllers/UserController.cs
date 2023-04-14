using Cw17_1.Models;
using Cw17_1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cw17_1.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            var user = _userRepository.GetUsers();
            return View(user);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _userRepository.Create(user);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _userRepository.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _userRepository.GetUser(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            _userRepository.Edit(user);
            return RedirectToAction("Index");
        }
    }
}
