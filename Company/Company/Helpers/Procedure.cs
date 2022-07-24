using Company.Models;
using Company.Models.DatabaseModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Company.Helpers
{
	public class Procedure
	{
        public List<User>? UsersFromCompany(ApplicationContext db)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                SqlParameter sqlParameter = new SqlParameter("@name", "Valve");
                var user = db.Users.FromSqlRaw("UsersFromCompany @name", sqlParameter).AsNoTracking().ToList();
                if (user != null)
                    return user;
            }
            return new List<User>();
        }
    }
}

