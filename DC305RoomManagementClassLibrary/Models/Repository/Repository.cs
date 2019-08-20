﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DC305RoomManagementClassLibrary.Models.Repository
{
    public class Repository : IDataStore
    {
        /// <summary>
        /// The name of the connection to the database
        /// </summary>
        static string ConnectionName = "rms";

        /// <summary>
        /// Gets data from the database
        /// </summary>
        /// <param name="StoredProcedure">Stored Procedure using to get data from the database</param>
        /// <returns>A DataTable containing requested data</returns>
        public DataTable GetData(string StoredProcedure)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(StoredProcedure, connection);
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlData.Fill(dataTable);
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
                catch (Exception err)
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
