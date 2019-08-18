using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        /// Getting the List of the all equipment from database
        /// </summary>
        /// <returns>List of all equipment</returns>
        public List<Inventory> GetEquipment()
        {
            List<Inventory> items = new List<Inventory>();
            items = ExecSqlQuery<Inventory>(ConnectionName, "spEquipment_GetAll", null);

            return items;
        }

        /// <summary>
        /// Save data of the equipment to the database
        /// </summary>
        /// <param name="equipment">Data of the Equipment</param>
        /// <returns>Returns ID of new record</returns>
        public int SaveEquipment(Equipment equipment)
        {
            return ExecSqlQueryScalar(ConnectionName, "spEquipment_Save",
                        new SqlParameter("@EquipmentId", equipment.EquipmentID),
                        new SqlParameter("@EquipmentName", equipment.EquipmentName),
                        new SqlParameter("@ETypeID", equipment.EType.ETypeID),
                        new SqlParameter("@ETypeName", equipment.EType.ETypeName),
                        new SqlParameter("@Quantity", equipment.Quantity),
                        new SqlParameter("@Description", equipment.Description),
                        new SqlParameter("@Active", equipment.Active)
                   );
        }

        public List<EquipmentType> GetETypes()
        {
            List<EquipmentType> items = new List<EquipmentType>();
            items = ExecSqlQuery<EquipmentType>(ConnectionName, "spEType_GetAll", null);

            return items;
        }
        public int SaveEType(EquipmentType equipmentType)
        {
            return ExecSqlQueryScalar(ConnectionName, "spEType_Save",
                        new SqlParameter("@ETypeID", equipmentType.ETypeID),
                        new SqlParameter("@ETypeName", equipmentType.ETypeName)
                   );
        }

        /// <summary>
        /// Execute StoredProcedure with Parameters
        /// </summary>
        /// <param name="ConnectionName">Name of the connection to the database</param>
        /// <param name="StoredProcedureName">Name of the Stored Procedure in the database</param>
        /// <param name="StoredProcedureParams">Set of params for Stored Procedure</param>
        /// <returns></returns>
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
                    //
                }
            }
        }

        private List<T> SqlQuery<T>(SqlCommand cmd, SqlConnection conn) where T : new()
        {
            List<T> result = new List<T>();

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                T t = new T();

                for (int inc = 0; inc < reader.FieldCount; inc++)
                {
                    Type type = t.GetType();
                    PropertyInfo prop = type.GetProperty(reader.GetName(inc));
                    prop.SetValue(t, reader.GetValue(inc), null);
                }

                result.Add(t);
            }
            reader.Close();
            conn.Close();
            return result;

        }

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

        private List<T> ExecSqlQuery<T>(string ConnectionName, string StoredProcedureName, params SqlParameter[] StoredProcedureParams) where T : new()
        {
            List<T> items = new List<T>();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(
                ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString)
            )
            {
                try
                {
                    SqlCommand cmd = prepareSqlCmd(connection, StoredProcedureName, StoredProcedureParams);
                    items = SqlQuery<T>(cmd, connection);
                    return items;
                }
                catch (Exception err)
                {
                    return items;
                }
            }
        }

        private List<EquipmentType> ReaderToETypeList(SqlDataReader reader)
        {
            List<EquipmentType> equipmentTypes = new List<EquipmentType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    equipmentTypes.Add(new EquipmentType(reader.GetInt32(0), reader.GetString(1)));
                }
            }
            return equipmentTypes;
        }
    }
}
