using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models
{
    public class Course
    {
        public int CourseID { get; set; } = 0;
        public string CourseName { get; set; } = "None";
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Level { get; set; }

        public Course()
        {

        }

        public Course(string courseName, string description, string duration, string level)
        {
            CourseName = courseName;
            Description = description;
            Duration = duration;
            Level = level;
        }

        public Course(int courseID, string courseName, string description, string duration, string level)
            :this(courseName, description, duration, level)
        {
            CourseID = courseID;
        }
    }
}
