using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models
{
    public class Booking
    {
        public int BookingID { get; set; } = 0;
        public int ClassID { get; set; } = 0;
        public int RoomID { get; set; } = 0;
        public int UserID { get; set; } = 0;
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public Booking()
        {
        }

        public Booking(int classID, int roomID, int userID, DateTime startDT, DateTime endDT)
        {
            ClassID = classID;
            RoomID = roomID;
            UserID = userID;
            StartDateTime = startDT;
            EndDateTime = endDT;
        }

        public Booking(int bookingID, int classID, int roomID, int userID, DateTime startDT, DateTime endDT)
            :this(classID, roomID, userID, startDT, endDT)
        {
            BookingID = bookingID;
        }
    }
}
