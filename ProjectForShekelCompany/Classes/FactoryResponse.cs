namespace ProjectForShekelCompany.Classes
{
    public class FactoryResponse
    {
        public int GroupCode { get; set; }
        public int FactoryCode { get; set; }
        public string FactoryName { get; set; }

        public FactoryResponse(int groupCode, int factoryCode, string factoryName)
        {
            GroupCode = groupCode;
            FactoryCode = factoryCode;
            FactoryName = factoryName;
        }
    }
}
