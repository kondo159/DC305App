using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models
{
    public class ClassEvent
    {
        public int ClassID { get; set; } = 0;
        public string ClassName { get; set; } = "None";
        public int CourseID { get; set; }
        public int StaffID { get; set; }
        public int GroupID { get; set; }

        public ClassEvent()
        {
            //
        }

        public ClassEvent(string className, int courseID, int staffID, int groupID)
        {
            ClassName = className;
            CourseID = courseID;
            StaffID = staffID;
            GroupID = groupID;
        }

        public ClassEvent(int classID, string className, int courseID, int staffID, int groupID)
            :this(className, courseID, staffID, groupID)
        {
            ClassID = classID;
        }
    }
}
