using Microsoft.AspNetCore.Mvc;
using ProjectForShekelCompany.Classes;
using ProjectForShekelCompany.Managers;

namespace ProjectForShekelCompany.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerDbManager _customerDbManager;

        public CustomerController(ICustomerDbManager customerDbManager)
        {
            _customerDbManager = customerDbManager;
        }

        [HttpGet(Name = "GetCustomersGroups")]
        public IEnumerable<CustomersGroupsResponse> GetCustomersGroups() =>
            _customerDbManager.GetCustomersGroups();

        [HttpPost]
        public void AddCustomer(string customerId, string name, string address,
            string phone, int factoryCode, int groupCode) =>
        _customerDbManager.AddCustomer(customerId, name,
            address, phone, factoryCode, groupCode);

        [HttpPost]
        public void AddGroupToDb(int groupCode, string groupName) =>
            _customerDbManager.AddGroupToDb(groupCode, groupName);

        [HttpPost]
        public void AddFactoryToDb(int groupCode, int factoryCode, string factoryName) =>
            _customerDbManager.AddFactoryToDb(groupCode, factoryCode, factoryName);

        [HttpGet(Name = "GetGroups")]
        public IEnumerable<GroupResponse> GetGroups() =>
            _customerDbManager.GetGroups();

        [HttpGet(Name = "GetFactories")]
        public IEnumerable<FactoryResponse> GetFactories() =>
            _customerDbManager.GetFactories();

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<CustomerResponse> GetCustomers() =>
            _customerDbManager.GetCustomers();
    }
}