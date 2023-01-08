namespace ProjectForShekelCompany.Classes
{
    public class CustomersGroupsResponse
    {
        public int GroupCode { get; set; }
        public string GroupName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }

        public CustomersGroupsResponse(int groupCode, string groupName, string customerId, string customerName)
        {
            GroupCode = groupCode;
            GroupName = groupName;
            CustomerId = customerId;
            CustomerName = customerName;
        }
    }
}