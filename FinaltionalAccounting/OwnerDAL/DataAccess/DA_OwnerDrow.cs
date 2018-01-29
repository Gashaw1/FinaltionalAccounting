using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccessLayer.DataAccess
{
    public class DA_OwnerDrow
    {
        //private string cs = ConfigurationManager.ConnectionStrings["DbContexts"].ConnectionString;
        //return all business info
        public DataSet ReturnOwnerDrow()    
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection con = new SqlConnection(""))
            {
                SqlCommand cmd = new SqlCommand("SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
        //return all the data associates per user
        public DataSet ReturnOwnerDrow(int OwnerDrowId) 
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection con = new SqlConnection(""))
            {
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUserID = new SqlParameter("@", OwnerDrowId);
                cmd.Parameters.Add(paramUserID);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
        //return  true if inserted
        public bool InsertOwnerDrow(double drowamount) 
        {

            using (SqlConnection con = new SqlConnection(""))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@", drowamount);
                cmd.Parameters.Add(param);

                SqlParameter paramDate = new SqlParameter("@", DateTime.Now.ToShortDateString());
                cmd.Parameters.Add(paramDate);

                int rowInserted = cmd.ExecuteNonQuery();
                if (rowInserted == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //Update user by user id
        public bool UpdateExpesne(int OwnerDrowID, double drowamount, string expenseType, string Items)
        {
            using (SqlConnection con = new SqlConnection(""))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUserID = new SqlParameter("@", OwnerDrowID);
                cmd.Parameters.Add(paramUserID);

                SqlParameter paramUsaerName = new SqlParameter("@", drowamount);
                cmd.Parameters.Add(paramUsaerName);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}