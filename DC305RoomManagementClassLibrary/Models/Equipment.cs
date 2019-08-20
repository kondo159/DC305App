using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models
{
    public class Equipment
    {
        public int EquipmentID { get; set; } = 0;
        public EquipmentType EType { get; set; }
        public int ETypeID { get; set; }
        public string EquipmentName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; } = false;

        public Equipment()
        {
            // Default Constructor
        }

        public Equipment(string equipmentName, int equipmentQuantity, string equipmentDescription, bool equipmentActive)
        {
            EquipmentName = equipmentName;
            Quantity = equipmentQuantity;
            Description = equipmentDescription;
            Active = equipmentActive;
        }

        public Equipment(int equipmentID, string equipmentName, int equipmentQuantity, string equipmentDescription, bool equipmentActive)
            : this(equipmentName, equipmentQuantity, equipmentDescription, equipmentActive)
        {
            EquipmentID = equipmentID;
        }
    }
}
