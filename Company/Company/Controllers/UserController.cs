using Company.Helpers.Implementations;
using Company.Models;
using Company.Models.DatabaseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.Controllers
{
    public class UserController : Controller
    {
        private ApplicationContext _db;
        private UserActions _userActions;

        public UserController(ApplicationContext context)
        {
            _db = context;
            _userActions = new UserActions(_db);
        }
        public IActionResult Index()
        {
            return View(_db.AboutEmployees.Include(x=>x.User).AsNoTracking().ToList());
        }
        public IActionResult Create() =>
        View();

        [HttpPost]
        public IActionResult Create(AboutEmployees employees)
        {
            _userActions.SaveNew(employees);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Nullable<int> id)=>
            _userActions.Delete(id) ? RedirectToAction("Index") : NotFound();

        public IActionResult Edit(Nullable<int> id)
        {
            AboutEmployees user = _userActions.Edit(id);
            return user != null ? View(user) : NotFound();
        }

        [HttpPost]
        public IActionResult Edit(AboutEmployees user)
        {
            _userActions.UpdateData(user);
            return RedirectToAction("Index");
        }
    }
}

