using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DC305RoomManagementClassLibrary.Models.Repository
{
    public class Repository : IDataStore
    {
        /// <summary>
        /// The name of the connection to the database
        /// </summary>
        static string ConnectionName = "DC305RoomManagementDB";

        /// <summary>
        /// Gets data from the database
        /// </summary>
        /// <param name="StoredProcedure">Stored Procedure using to get data from the database</param>
        /// <returns>A DataTable containing requested data</returns>
        public DataTable GetData(string StoredProcedure, params SqlParameter[] StoredProcedureParams)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(StoredProcedure, connection);
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (StoredProcedureParams != null)
                {
                    foreach (SqlParameter param in StoredProcedureParams)
                    {
                        sqlData.SelectCommand.Parameters.Add(param);
                    }
                }

                try
                {
                    sqlData.Fill(dataTable);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return dataTable;
        }

        /// <summary>
        /// Gets all the equipment from the database
        /// </summary>
        /// <returns>A DataTable containing requested data</returns>
        public DataTable GetEquipment()
        {
            return GetData("spEquipment_GetAll");
        }

        /// <summary>
        /// Saves data of the equipment to the database
        /// </summary>
        /// <param name="equipment">Data of the Equipment</param>
        /// <returns>Returns int ID of saved record</returns>
        public int SaveEquipment(Equipment equipment)
        {
            return ExecSqlQueryScalar(ConnectionName, "spEquipment_Save",
                        new SqlParameter("@EquipmentId", equipment.EquipmentID),
                        new SqlParameter("@EquipmentName", equipment.EquipmentName),
                        new SqlParameter("@ETypeID", equipment.ETypeID),
                        //new SqlParameter("@ETypeName", equipment.EType.ETypeName),
                        new SqlParameter("@Quantity", equipment.Quantity),
                        new SqlParameter("@Description", equipment.Description),
                        new SqlParameter("@Active", equipment.Active)
                   );
        }

        /// <summary>
        /// Gets all Equipment Types
        /// </summary>
        /// <returns>A DataTable containing requested data</returns>
        public DataTable GetETypes()
        {
            return GetData("spEType_GetAll");
        }

        /// <summary>
        /// Saves data of the Equipment Type to the database
        /// </summary>
        /// <param name="equipmentType">Data of the Equipment Type</param>
        /// <returns>Returns int ID of saved record</returns>
        public int SaveEType(EquipmentType equipmentType)
        {
            return ExecSqlQueryScalar(ConnectionName, "spEType_Save",
                        new SqlParameter("@ETypeID", equipmentType.ETypeID),
                        new SqlParameter("@ETypeName", equipmentType.ETypeName)
                   );
        }

        /// <summary>
        /// Gets all issues from the database
        /// </summary>
        /// <returns>A DataTable containing of the Issues</returns>
        public DataTable GetIssues()
        {
            return GetData("spIssue_GetAll");
        }

        /// <summary>
        /// Saves the Issue to the database
        /// </summary>
        /// <param name="issue">Issue object containing data for saving to the database</param>
        /// <returns>Integer number of ID of saved record</returns>
        public int SaveIssue(Issue issue)
        {
            return ExecSqlQueryScalar(ConnectionName, "spIssue_Save",
                    new SqlParameter("@IssueID", issue.IssueID),
                    new SqlParameter("@IssueName", issue.Title),
                    new SqlParameter("@Status", issue.Status),
                    new SqlParameter("@Description", issue.Description),
                    new SqlParameter("@CreatedDate", issue.CreatedAt),
                    new SqlParameter("@ClosedDate", issue.ClosedAt),
                    new SqlParameter("@RoomID", issue.RoomID)
                );
        }

        /// <summary>
        /// Gets all rooms from database
        /// </summary>
        /// <returns>A DataTable containing of the Rooms</returns>
        public DataTable GetRooms()
        {
            return GetData("spRoom_GetAll");
        }

        /// <summary>
        /// Gets all groups from database
        /// </summary>
        /// <returns>A DataTable containing of the Groups</returns>
        public DataTable GetGroups()
        {
            return GetData("spGroup_GetAll");
        }

        /// <summary>
        /// Saves the Group to the database
        /// </summary>
        /// <param name="group">Group object containing data for saving to the database</param>
        /// <returns>Integer number of ID of saved record</returns>
        public int SaveGroup(Group group)
        {
            return ExecSqlQueryScalar(ConnectionName, "spGroup_Save",
                    new SqlParameter("@GroupID", group.GroupID),
                    new SqlParameter("@GroupName", group.GroupName),
                    new SqlParameter("@Description", group.Description),
                    new SqlParameter("@Active", group.Active)
                );
        }

        /// <summary>
        /// Get Group Members by Group ID
        /// </summary>
        /// <param name="GroupID">int GroupID</param>
        /// <returns>A DataTable containing of the Members</returns>
        public DataTable GetGroupMembers(int GroupID)
        {
            return GetData("spGroupMembers_GetAll", new SqlParameter("@GroupID", GroupID));
        }

        /// <summary>
        /// Saves the Group Member for group identified by GroupID
        /// </summary>
        /// <param name="GroupID">int GroupID</param>
        /// <param name="UserID">int UserID</param>
        public void SaveGroupMember(int GroupID, int UserID)
        {
            ExecSqlQueryScalar(ConnectionName, "spGroupOfStudents_Save",
                    new SqlParameter("@GroupID", GroupID),
                    new SqlParameter("@UserID", UserID)
                );
        }

        /// <summary>
        /// Removes the Group Member from group identified by GroupID
        /// </summary>
        /// <param name="GroupID">int GroupID</param>
        /// <param name="UserID">int UserID</param>
        public void RemoveGroupMember(int GroupID, int UserID)
        {
            ExecSqlQueryScalar(ConnectionName, "spGroupOfStudents_Remove",
                    new SqlParameter("@GroupID", GroupID),
                    new SqlParameter("@UserID", UserID)
                );
        }

        /// <summary>
        /// Gets Users from the database
        /// </summary>
        /// <param name="RoleID">int RoleID</param>
        /// <returns>If RoleID <> 0 all user will be returned 
        /// in the other case user having specified role will be returned</returns>
        public DataTable GetUsers(int RoleID = 0)
        {
            return GetData("spUsers_GetAll", new SqlParameter("@RoleID", RoleID));
        }

        /// <summary>
        /// Gets all Courses from the database
        /// </summary>
        /// <returns></returns>
        public DataTable GetCourses()
        {
            return GetData("spCourses_GetAll");
        }

        /// <summary>
        /// Saves the Course into the database
        /// </summary>
        /// <param name="course">Course object contained data</param>
        /// <returns>int Saving record ID</returns>
        public int SaveCourse(Course course)
        {
            return ExecSqlQueryScalar(ConnectionName, "spCourses_Save",
                    new SqlParameter("@CourseID", course.CourseID),
                    new SqlParameter("@CourseName", course.CourseName),
                    new SqlParameter("@Description", course.Description),
                    new SqlParameter("@Duration", course.Duration),
                    new SqlParameter("@Level", course.Level)
                );
        }

        /// <summary>
        /// Gets all Classes
        /// </summary>
        /// <returns>A DataTable containing the Classes</returns>
        public DataTable GetClasses()
        {
            return GetData("spClass_GetAll");
        }

        /// <summary>
        /// Saves the ClassEvent into the database
        /// </summary>
        /// <param name="classEvent">ClassEvent object contained data</param>
        /// <returns>int Saving record ID</returns>
        public int SaveClass(ClassEvent classEvent)
        {
            return ExecSqlQueryScalar(ConnectionName, "spClass_Save",
                    new SqlParameter("@ClassID", classEvent.ClassID),
                    new SqlParameter("@ClassName", classEvent.ClassName),
                    new SqlParameter("@CourseID", classEvent.CourseID),
                    new SqlParameter("@StaffID", classEvent.StaffID),
                    new SqlParameter("@GroupID", classEvent.GroupID)
                );
        }


        /// <summary>
        /// Execute StoredProcedure with Parameters
        /// </summary>
        /// <param name="ConnectionName">Name of the connection to the database</param>
        /// <param name="StoredProcedureName">Name of the Stored Procedure in the database</param>
        /// <param name="StoredProcedureParams">Set of params for Stored Procedure</param>
        /// <returns>Returns int ID of saved record</returns>
        private int ExecSqlQueryScalar(string ConnectionName, string StoredProcedureName, params SqlParameter[] StoredProcedureParams)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(
                ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString)
            )
            {
                try
                {
                    SqlCommand cmd = prepareSqlCmd(connection, StoredProcedureName, StoredProcedureParams);
                    
                    connection.Open();
                    string recordID = cmd.ExecuteScalar().ToString();

                    return int.Parse(recordID);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Creates the SqlCommand and sets parameters for the SqlCommand
        /// </summary>
        /// <param name="Connection">An SqlConnection that will be used in SqlCommand</param>
        /// <param name="StoredProcedureName">A Stored Procedure that will be used for getting data</param>
        /// <param name="StoredProcedureParams">Parameters for the Store Procedure</param>
        /// <returns></returns>
        private SqlCommand prepareSqlCmd(SqlConnection Connection, string StoredProcedureName, params SqlParameter[] StoredProcedureParams)
        {
            SqlCommand cmd = new SqlCommand(StoredProcedureName, Connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            if (StoredProcedureParams != null)
            {
                foreach (SqlParameter param in StoredProcedureParams)
                {
                    cmd.Parameters.Add(param);
                }
            }
            return cmd;
        }
        
    }
}
