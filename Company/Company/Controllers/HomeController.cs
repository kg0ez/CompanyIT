using Microsoft.AspNetCore.Mvc;
using Company.Models;
using Microsoft.EntityFrameworkCore;
using Company.Helpers.Implementations;

namespace Company.Controllers;

public class HomeController : Controller
{
    private ApplicationContext _db;
    private CompanyActions _company;

    public HomeController(ApplicationContext context) {
        _db = context;
        _company = new CompanyActions(_db);
    }

    public IActionResult Index()=>
        View(_db.Companies.Include(x => x.AboutCompany).AsNoTracking().ToList());

    public IActionResult Create()=>
        View();

    [HttpPost]
    public IActionResult Create(Models.DatabaseModels.Company company)
    {
       _company.SaveNew(company);
            return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Delete(Nullable<int> id)=>
        _company.Delete(id) ? RedirectToAction("Index") : NotFound();

    public IActionResult Edit(Nullable<int> id)
    {
        Models.DatabaseModels.Company? company = _company.Edit(id);
        return company!=null ? View(company):NotFound();
    }

    [HttpPost]
    public IActionResult Edit(Models.DatabaseModels.Company company)
    {
        _company.UpdateData(company);
        return RedirectToAction("Index");
    }

    
}

