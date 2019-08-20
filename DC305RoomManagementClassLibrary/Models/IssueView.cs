using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models
{
    public class IssueView
    {
        public int IssueID { get; set; } = 0;
        public string Title { get; set; } = "None";
        public int RoomID { get; set; } = 0;
        public string RoomName { get; set; } = "None";
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ClosedAt { get; set; } = DateTime.MaxValue;
    }
}
