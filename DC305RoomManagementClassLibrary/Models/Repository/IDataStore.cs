using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models.Repository
{
    public interface IDataStore
    {
        DataTable GetEquipment();
        int SaveEquipment(Equipment equipment);

        DataTable GetETypes();
        int SaveEType(EquipmentType equipmentType);

        DataTable GetIssues();
        int SaveIssue(Issue issue);

        DataTable GetRooms();

        DataTable GetGroups();
        DataTable GetGroupMembers(int GroupID);
        int SaveGroup(Group group);
        void SaveGroupMember(int GroupID, int UserID);
        void RemoveGroupMember(int GroupID, int UserID);
    }
}