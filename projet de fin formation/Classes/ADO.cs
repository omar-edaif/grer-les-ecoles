using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;




namespace projet_de_fin_formation
{
    class ADO
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["PFF"].ConnectionString;


       static public SqlConnection Cnx = new SqlConnection(connectionString);
       
        DataSet dataset;
        public static void OpenOrCloseConnection()
        {
            if (Cnx.State == ConnectionState.Closed)
            {
                Cnx.Open();
                return;
            }
            if (Cnx.State == ConnectionState.Open)
            {
                Cnx.Close();
                return;
            }
        }
           public static void Execute(SqlCommand cmd)
          {
            try
            {
                OpenOrCloseConnection();
                cmd.Connection = Cnx;
                cmd.ExecuteNonQuery();
                OpenOrCloseConnection();

            }
            catch (Exception e)
            {
                OpenOrCloseConnection();
                MessageBox.Show(e.Message);

            }
        }

    }
}

