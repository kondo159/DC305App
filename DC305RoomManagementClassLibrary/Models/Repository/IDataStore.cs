﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models.Repository
{
    public interface IDataStore
    {
        List<Inventory> GetEquipment();
        int SaveEquipment(Equipment equipment);
        
        List<EquipmentType> GetETypes();
        int SaveEType(EquipmentType equipmentType);
    }
}
