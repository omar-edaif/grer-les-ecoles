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
        // charger combobox Secteur 
        public static void ChargerComboSecteur(ComboBox combo)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from secteur", ADO.Cnx);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "secteur");
            combo.ValueMember = "code_sect";
            combo.DisplayMember = "intitulé_sect";
            combo.DataSource = dataset.Tables["secteur"];


        }
        //charger combobox Niveau
        public static void ChargerComboNiveau(ComboBox combo)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Niveau", ADO.Cnx);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Niveau");
            combo.ValueMember = "Code_niveau";
            combo.DisplayMember = "intitué_niveau";
            combo.DataSource = dataset.Tables["Niveau"];
           

        }

        // charger combobox Module
        public static void ChargerComboModule(ComboBox combo)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Module", ADO.Cnx);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Module");
            combo.ValueMember = "code_mod";
            combo.DisplayMember = "Intitulé_mod";
            combo.DataSource = dataset.Tables["Module"];
        }
        // charger combobox Filiere 
      
        public static void ChargerComboFiliere(ComboBox combo)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Filière", ADO.Cnx);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Filière");
            combo.ValueMember = "code_Fil";
            combo.DisplayMember = "nom_Fil";
            combo.DataSource = dataset.Tables["Filière"];
        }

    }
}
