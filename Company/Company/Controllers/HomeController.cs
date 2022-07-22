using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Company.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.Controllers;

public class HomeController : Controller
{
    private ApplicationContext _db;

    public HomeController(ApplicationContext context)=>
        _db = context;

    public IActionResult Index()=>
        View(_db.Companies.Include(x=>x.AboutCompany).AsNoTracking().ToList());

    public IActionResult Create()=>
        View();

    [HttpPost]
    public async Task<IActionResult> Create(Models.DatabaseModels.Company company)
    {
        _db.Companies.Add(company);
        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Nullable<int> id)
    {
        if (id.HasValue)
        {
            Models.DatabaseModels.Company? company = await _db.Companies.FirstOrDefaultAsync(x => x.Id == id);
            if (company!=null)
            {
                _db.Companies.Remove(company);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        return NotFound();
    }
    public async Task<IActionResult> Edit(Nullable<int> id)
    {
        if (id.HasValue)
        {
            Models.DatabaseModels.Company? company = await _db.Companies.Include(x=>x.AboutCompany).FirstOrDefaultAsync(x => x.Id == id);
            if (company != null)
                return View(company);
        }
        return NotFound();
    }
    [HttpPost]
    public async Task<IActionResult> Edit(Models.DatabaseModels.Company company)
    {
        _db.Companies.Update(company);
        _db.AboutCompanies.Update(company.AboutCompany);
        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
    }
}

