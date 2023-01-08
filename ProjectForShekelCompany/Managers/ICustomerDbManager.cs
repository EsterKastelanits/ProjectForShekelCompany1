using ProjectForShekelCompany.Classes;

namespace ProjectForShekelCompany.Managers
{
    public interface ICustomerDbManager
    {
        IEnumerable<CustomersGroupsResponse> GetCustomersGroups();
        void AddCustomer(string customerId, string name, string address,
            string phone, int factoryCode, int groupCode);
        void AddGroupToDb(int groupCode, string groupName);
        void AddFactoryToDb(int groupCode, int factoryCode, string factoryName);
        IEnumerable<FactoryResponse> GetFactories();
        IEnumerable<CustomerResponse> GetCustomers();
        IEnumerable<GroupResponse> GetGroups();
    }
}
