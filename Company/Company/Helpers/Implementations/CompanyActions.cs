using Company.Helpers.Contracts;
using Company.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.Helpers.Implementations
{
	public class CompanyActions:IGeneralRules,ICompany
	{
        private ApplicationContext _db;

		public CompanyActions(ApplicationContext db)=>
            _db = db;

        public void SaveNew(Models.DatabaseModels.Company company)
        {
            _db.Companies.Add(company);
            _db.SaveChanges();
        }

        public bool Delete(Nullable<int> id)
        {
            if (id.HasValue)
            {
                Models.DatabaseModels.Company? company = _db.Companies.FirstOrDefault(x => x.Id == id.Value);
                if (company != null)
                {
                    _db.Companies.Remove(company);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Models.DatabaseModels.Company Edit(Nullable<int> id)
        {
            Models.DatabaseModels.Company? company;
            if (id.HasValue)
            {
                company = _db.Companies.Include(x => x.AboutCompany).FirstOrDefault(x => x.Id == id.Value);
                return company;
            }
            return null;
        }

        public void UpdateData(Models.DatabaseModels.Company company)
        {
            _db.Companies.Update(company);
            _db.SaveChanges();
        }
    }
}

