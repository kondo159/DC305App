namespace DC305RoomManagementClassLibrary.Models
{
    public class EquipmentType
    {
        public int ETypeID { get; set; } = 0;
        public string ETypeName { get; set; }

        public EquipmentType()
        {
            ETypeName = "None";
        }

        public EquipmentType(string equipmentTypeName)
        {
            ETypeName = equipmentTypeName;
        }

        public EquipmentType(int equipmentTypeID, string equipmentTypeName) : this(equipmentTypeName)
        {
            ETypeID = equipmentTypeID;
        }


    }
}
