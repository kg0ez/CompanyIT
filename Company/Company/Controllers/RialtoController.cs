using Company.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.Controllers
{
    public class RialtoController : Controller
    {
        ApplicationContext _db;
        public RialtoController(ApplicationContext context) =>
            _db = context;

        public IActionResult Index()=>
            View(_db.Rialtos.Include(x=>x.Company).AsNoTracking().ToList());
    }
}

