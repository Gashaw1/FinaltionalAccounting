using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccessLayer.DataAccess
{
    public class DA_BusinessOwner
    {
       // private string cs = ConfigurationManager.ConnectionStrings["DbContexts"].ConnectionString;
        //return all business info
        public DataSet ReturnBusinessOwner()
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection con = new SqlConnection(""))
            {
                SqlCommand cmd = new SqlCommand("SP_Return_All_Users", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
        //return all the data associates per user
        public DataSet ReturnBusinessOwner(int businessOwnerID) 
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection con = new SqlConnection(""))
            {
                SqlCommand cmd = new SqlCommand("Sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUserID = new SqlParameter("@", businessOwnerID);
                cmd.Parameters.Add(paramUserID);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
        //return  true if inserted
        public bool InsertBusinessOwner(string ownerType, string typeOfBusiness , string investementTypes, string dateTime)   
        {

            using (SqlConnection con = new SqlConnection(""))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_AddBusiness", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@UserName", ownerType);
                cmd.Parameters.Add(param);

                SqlParameter paramEmail = new SqlParameter("@UserEmail", typeOfBusiness);
                cmd.Parameters.Add(paramEmail);

                SqlParameter paramPassword = new SqlParameter("@UserPassword", investementTypes);
                cmd.Parameters.Add(paramPassword);

                SqlParameter paramDate = new SqlParameter("@UserDate", DateTime.Now.ToShortDateString());
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
        public bool UpdateBusinessOwner(int businessOwnerID, string ownerType, string typeOfBusiness, string investementTypes)  
        {
            using (SqlConnection con = new SqlConnection(""))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUserID = new SqlParameter("@", businessOwnerID);
                cmd.Parameters.Add(paramUserID);

                SqlParameter paramUsaerName = new SqlParameter("@", ownerType);
                cmd.Parameters.Add(paramUsaerName);

                SqlParameter paramPassword = new SqlParameter("@", typeOfBusiness);
                cmd.Parameters.Add(paramPassword);

                SqlParameter paramPasswords = new SqlParameter("@", investementTypes);   
                cmd.Parameters.Add(paramPassword);


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