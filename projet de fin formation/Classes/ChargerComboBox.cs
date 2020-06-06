using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace projet_de_fin_formation
{
    class ChargerComboBox
    {
        public static void ChargerComboSecteur(ComboBox combo)
        {
           SqlDataAdapter adapter = new SqlDataAdapter("select * from secteur", ADO.Cnx);
            DataSet dataset=new DataSet ();
            adapter.Fill(dataset, "secteur");
            combo.ValueMember = "code_sect";
            combo.DisplayMember = "intitulé_sect";
            combo.DataSource = dataset.Tables["secteur"];

            
        }
        public static void ChargerComboNiveau(ComboBox combo)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Niveau", ADO.Cnx);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Niveau");
            combo.ValueMember = "Code_niveau";
            combo.DisplayMember = "intitué_niveau";
            combo.DataSource = dataset.Tables["Niveau"];
           

        }

    }
}
