namespace Company.Helpers.Contracts
{
	public interface ICompany
	{
		void SaveNew(Models.DatabaseModels.Company company);
		void UpdateData(Models.DatabaseModels.Company company);
		Models.DatabaseModels.Company Edit(Nullable<int> id);
	}
}

