using Company.Helpers.Contracts;
using Company.Models;
using Company.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Company.Helpers.Implementations
{
	public class UserActions:IUser,IGeneralRules
	{
        ApplicationContext _db;
		public UserActions(ApplicationContext context)=>
            _db = context;

        public bool Delete(Nullable<int> id)
        {
            if (id.HasValue)
            {
                User? user = _db.Users.FirstOrDefault(x => x.Id == id.Value);
                if (user!=null)
                {
                    _db.Users.Remove(user);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public void SaveNew(AboutEmployees user)
        {
            _db.AboutEmployees.Add(user);
            _db.SaveChanges();
        }

        public void UpdateData(AboutEmployees user)
        {
            _db.AboutEmployees.Update(user);
            _db.SaveChanges();
        }
        public AboutEmployees Edit(Nullable<int> id)
        {
            AboutEmployees? user;
            if (id.HasValue)
            {
                user = _db.AboutEmployees.Include(x => x.User).FirstOrDefault(x => x.Id == id.Value);
                return user;
            }
            return null;
        }
    }
}

