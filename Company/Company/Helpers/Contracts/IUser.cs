using Company.Models.DatabaseModels;

namespace Company.Helpers.Contracts
{
	public interface IUser
	{
		void SaveNew(AboutEmployees user);
		void UpdateData(AboutEmployees user);
		AboutEmployees Edit(Nullable<int> id);
	}
}

