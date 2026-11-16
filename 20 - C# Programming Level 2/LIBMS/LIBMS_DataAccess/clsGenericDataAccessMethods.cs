using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBMS_DataAccess
{
    public class clsGenericDataAccessMethods
    {
        public DataTable ExecuteGetData(string spName, SqlParameter[] sqlParameter = null)
        {
            DataTable dtGetData = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (sqlParameter != null)
                    {
                        command.Parameters.AddRange(sqlParameter);
                    }
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtGetData.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string sourceName = "Exception";
                        if (!EventLog.SourceExists(sourceName))
                        {
                            EventLog.CreateEventSource(sourceName, "Application");
                        }

                        EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
                    }
                }
            }
            return dtGetData;
        }

        public int ExecuteInsert(string spName, SqlParameter[] sqlParameter = null)
        {
            int LastPersonID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (sqlParameter != null)
                    {
                        command.Parameters.AddRange(sqlParameter);
                    }
                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();
                        int ResultID = -1;
                        if (Result != null && int.TryParse(Result.ToString(), out ResultID))
                        {
                            LastPersonID = ResultID;
                        }

                    }
                    catch (Exception ex)
                    {
                        string sourceName = "Exception";
                        if (!EventLog.SourceExists(sourceName))
                        {
                            EventLog.CreateEventSource(sourceName, "Application");
                        }

                        EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
                    }
                }
            }
            return LastPersonID;
        }

        public bool ExecuteUpdate(string spName, SqlParameter[] sqlParameter = null)
        {
            int EffectRow = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (sqlParameter != null)
                    {
                        command.Parameters.AddRange(sqlParameter);
                    }
                    try
                    {
                        connection.Open();
                        EffectRow = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string sourceName = "Exception";
                        if (!EventLog.SourceExists(sourceName))
                        {
                            EventLog.CreateEventSource(sourceName, "Application");
                        }

                        EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
                    }
                }
            }
            return (EffectRow > 0);
        }

        public bool ExecuteDelete(string spName, SqlParameter[] sqlParameter = null)
        {
            int EffectRow = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (sqlParameter != null)
                    {
                        command.Parameters.AddRange(sqlParameter);
                    }
                    try
                    {
                        connection.Open();

                        EffectRow = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            return (EffectRow > 0);
        }

        public bool IsRecordExists(string spName, SqlParameter[] sqlParameter = null)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (sqlParameter != null)
                    {
                        command.Parameters.AddRange(sqlParameter);
                    }
                    SqlParameter ValueParameter = new SqlParameter();
                    ValueParameter.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(ValueParameter);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        int result = (int)ValueParameter.Value;
                        IsFound = (result == 1);
                    }
                    catch (Exception ex)
                    {
                        string sourceName = "Exception";
                        if (!EventLog.SourceExists(sourceName))
                        {
                            EventLog.CreateEventSource(sourceName, "Application");
                        }

                        EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
                    }
                }
            }
            return IsFound;
        }


        public int ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters)
        {
            int LastPersonID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();
                        int ResultID = -1;
                        if (Result != null && int.TryParse(Result.ToString(), out ResultID))
                        {
                            LastPersonID = ResultID;
                        }
                    }
                    catch(Exception ex)
                    {
                        string sourceName = "Exception";
                        if (!EventLog.SourceExists(sourceName))
                        {
                            EventLog.CreateEventSource(sourceName, "Application");
                        }

                        EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
                    }
                }
            }
            return LastPersonID;
        }

    }
}
