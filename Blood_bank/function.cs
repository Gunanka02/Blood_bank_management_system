using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_bank
{
    internal class function
    {
       
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =GUNANKA_RAJ\\SQLEXPRESS;database = bloodbank;integrated security =True";
            return con;
        }
        public DataSet getData(String query) // get data from database
        {

            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine("Error in getData: " + ex.Message);
            }

            return ds;
        }
        public void setData(String query) //insertion deletion updation
        { 
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Processed Successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
        }

    }
}
