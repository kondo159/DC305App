using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagement
{
    class RoomEquip
    {
        private int equipId;
        private string name;
        private int quantity;
        private string desc;
        public RoomEquip()
        {
            this.EquipId = 0;
        }
        public RoomEquip(int equipId, string name, int quantity, string desc)
        {
            this.EquipId = equipId;
            this.Name = name;
            this.Quantity = quantity;
            this.Desc = desc;
        }
        public string Desc { get => desc; set => desc = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Name { get => name; set => name = value; }
        public int EquipId { get => equipId; set => equipId = value; }
    }
}
