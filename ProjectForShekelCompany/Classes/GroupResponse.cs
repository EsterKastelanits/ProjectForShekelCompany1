namespace ProjectForShekelCompany.Classes
{
    public class GroupResponse
    {
        public int GroupCode { get; set; }
        public string GroupName { get; set; }
        public GroupResponse(int groupCode, string groupName)
        {
            GroupCode = groupCode;
            GroupName = groupName;
        }
    }
}
