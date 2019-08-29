namespace DC305RoomManagementClassLibrary.Models
{
    public class Group
    {
        public int GroupID { get; set; } = 0;
        public string GroupName { get; set; } = "None";
        public string Description { get; set; }
        public bool Active { get; set; } = true;
    }
}
