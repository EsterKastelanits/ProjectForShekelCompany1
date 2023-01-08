namespace ProjectForShekelCompany.Classes
{
    public class CustomerResponse
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public CustomerResponse(string customerId, string name, string address, string phone)
        {
            CustomerId = customerId;
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
