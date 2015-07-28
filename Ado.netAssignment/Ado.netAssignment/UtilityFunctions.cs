using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
namespace Ado.netAssignment
{
    public static class UtilityFunctions
    {
        public static string connection;

        public static Dictionary<int, string> GetAllStreams()
        {
            connection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    Dictionary<int, string> dictionary = new Dictionary<int, string>();
                    string query = "select * from Stream";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            dictionary.Add(Convert.ToInt32(dr["Id"]), dr["Name"].ToString());
                        }
                        return dictionary;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Dictionary<int, string> GetAllStates()
        {
            connection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            try
            {

                using (SqlConnection con = new SqlConnection(connection))
                {
                    Dictionary<int, string> dictionary = new Dictionary<int, string>();
                    string query = "select * from State";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            dictionary.Add(Convert.ToInt32(dr["Id"]), dr["Name"].ToString());
                        }
                        return dictionary;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string GetStateName(int stateID)
        {
            connection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = "select Name from State where Id=" + stateID;
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            return dr["Name"].ToString();
                        }
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string GetStreamName(int streamID)
        {
            connection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = "select Name from Stream where Id=" + streamID;
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            return dr["Name"].ToString();
                        }
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void LogToEvent(Exception e)
        {
            EventLog.WriteEntry("an error occured", e.Message + "Trace" + e.StackTrace, EventLogEntryType.Error, 121, short.MaxValue);  
        }

    }
}

       

        
 