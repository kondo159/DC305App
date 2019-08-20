using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models
{
    public class Issue
    {
        public int IssueID { get; set; } = 0;
        public string Title { get; set; } = "None";
        public int RoomID { get; set; } = 0;
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ClosedAt { get; set; } = DateTime.MaxValue;

        public Issue()
        {
            CreatedAt = DateTime.Now;
        }

        public Issue(string title, string status, string description, int roomID):this()
        {
            Title = title;
            Status = status;
            Description = description;
            RoomID = roomID;
        }

        public Issue(int issueID, string title, string status, string description, int roomID) 
            : this(title, status, description, roomID)
        {
            IssueID = issueID;
        }
    }

    public class Room
    {
        public int RoomId { get; set; } = 1;
        public string RoomName { get; set; } = "None";

        public Room()
        {

        }

        public Room(int roomID, string roomName)
        {
            RoomId = roomID;
            RoomName = roomName;
        }
    }
}
