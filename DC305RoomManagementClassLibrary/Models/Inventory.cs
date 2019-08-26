namespace DC305RoomManagementClassLibrary.Models
{
    public class Inventory
    {

        public int EquipmentID { get; set; } = 0;
        public int ETypeID { get; set; } = 0;
        public string ETypeName { get; set; }
        public string EquipmentName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; } = false;
    }
}
