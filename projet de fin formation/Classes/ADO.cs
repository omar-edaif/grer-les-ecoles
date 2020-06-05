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

        static public Exception exception;
       static public SqlConnection Cnx = new SqlConnection(connectionString);
        static public SqlDataAdapter Adapter;
        static public DataTable Table;
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
           public static void Insert(SqlCommand cmd)
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
                MessageBox.Show(e.Message);

            }
        }

    }
}

