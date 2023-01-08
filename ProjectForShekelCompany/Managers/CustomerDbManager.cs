using DBEntityFramework;
using ProjectForShekelCompany.Classes;

namespace ProjectForShekelCompany.Managers
{
    public class CustomerDbManager : ICustomerDbManager
    {
        public IEnumerable<CustomersGroupsResponse> GetCustomersGroups()
        {
            return ShekelTestService.GetGroupsWithCustomers().Select(cg =>
                new CustomersGroupsResponse(cg.Group.groupCode, cg.Group.groupName, cg.Customer.customerId,
                    cg.Customer.name));
        }

        public void AddCustomer(string customerId, string name, string address,
            string phone, int factoryCode, int groupCode) =>
            ShekelTestService.AddCustomerToDb(customerId, name, address, phone, factoryCode, groupCode);

        public void AddGroupToDb(int groupCode, string groupName) =>
            ShekelTestService.AddGroupToDb(groupCode, groupName);

        public void AddFactoryToDb(int groupCode, int factoryCode, string factoryName) =>
            ShekelTestService.AddFactoryToDb(groupCode, factoryCode, factoryName);

        public IEnumerable<FactoryResponse> GetFactories() =>
            ShekelTestService.GetFactories().Select(f => new FactoryResponse(f.groupCode, f.factoryCode, f.factoryName));

        public IEnumerable<CustomerResponse> GetCustomers() =>
            ShekelTestService.GetCustomers().Select(c => new CustomerResponse(c.customerId, c.name, c.address, c.phone));

        public IEnumerable<GroupResponse> GetGroups() =>
            ShekelTestService.GetGroups().Select(g => new GroupResponse(g.groupCode, g.groupName));
    }
}
