using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;

namespace projet_de_fin_formation
{
    class ADO
    {
        public static void CleanForm(Form form)
        {
            foreach (var c in form.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                if (c is Panel)
                {
                    foreach (var item in (c as Panel).Controls)
                    {
                        if (item is TextBox)
                            {
                                ((TextBox)item).Text = String.Empty;
                            }                      
                    }
                }
                if (c is GroupBox)
                {
                    foreach (var item in (c as GroupBox).Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = String.Empty;
                        }
                    }
                }
            }
        }
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["PFF"].ConnectionString;

       static public SqlConnection Cnx = new SqlConnection(connectionString);
        

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
                MessageBox.Show("votre opiratin effectuer");
               

            }
            catch (Exception e)
            {
                OpenOrCloseConnection();
                MessageBox.Show(e.Message);

            }
        }

    }
}

