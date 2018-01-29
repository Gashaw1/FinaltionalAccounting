using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccessLayer.DataAccess
{
    public class DA_Expense
    {
        private string cs = "";
        //return all business info
        public DataSet ReturnExpense()
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
        //return all the data associates per user
        public DataSet ReturnBusinessOwner(int expenseID)   
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUserID = new SqlParameter("@UserID", expenseID);
                cmd.Parameters.Add(paramUserID);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
        //return  true if inserted
        public bool InsertExpesne(double expenseAmount, string expenseType, string Items)
        {
                
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@UserName", expenseAmount);
                cmd.Parameters.Add(param);

                SqlParameter paramEmail = new SqlParameter("@UserEmail", expenseType);
                cmd.Parameters.Add(paramEmail);

                SqlParameter paramPassword = new SqlParameter("@UserPassword", Items);
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
        public bool UpdateExpesne(int ExpenseID, string expenseAmount, string expenseType, string Items)
        {
            using (SqlConnection con = new SqlConnection(cs))   
            {   
                con.Open();
                SqlCommand cmd = new SqlCommand("SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUserID = new SqlParameter("@", ExpenseID);
                cmd.Parameters.Add(paramUserID);

                SqlParameter paramUsaerName = new SqlParameter("@", expenseAmount);
                cmd.Parameters.Add(paramUsaerName);

                SqlParameter paramPassword = new SqlParameter("@", expenseType);
                cmd.Parameters.Add(paramPassword);

                SqlParameter paramPasswords = new SqlParameter("@", Items);
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