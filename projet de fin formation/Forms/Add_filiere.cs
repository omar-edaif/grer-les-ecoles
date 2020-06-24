using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_de_fin_formation.Forms
{
    public partial class Add_Filiere : MetroFramework.Forms.MetroForm
    {
        public Add_Filiere()
        {
            InitializeComponent();
        }
       
        private void Add_Filiere_Load(object sender, EventArgs e)
        {
            
            ChargerComboBox.ChargerComboSecteur(ComboSecteur);         
            ChargerComboBox.ChargerComboNiveau(ComboNiveau);
            ChargerDGV();
        }
         public void ChargerDGV()
        {
            // TODO: This line of code loads data into the 'getFiliere._GetFiliere' table. You can move, or remove it, as needed.
            this.getFiliereTableAdapter.Fill(this.getFiliere._GetFiliere);
        }
        //         $$   charger combobox secteur  $$


        private void ComboSecteur_Enter(object sender, EventArgs e)
        {
        //    ComboSecteur.DataSource=null;
        //    ChargerComboBox.ChargerComboSecteur(ComboSecteur);
        }
         
        
        //         $$   charger combobox Niveau  $$
        private void ComboNiveau_Enter(object sender, EventArgs e)
        {
            //ComboNiveau.DataSource = null;
            //ChargerComboBox.ChargerComboNiveau(ComboNiveau);

        }
        //  code de la button ajouter 

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"insert into Filière values ('{txtName.Text}',{ComboNiveau.SelectedValue.ToString()},GETDATE(),{ComboSecteur.SelectedValue.ToString()})";
            ADO.Execute(cmd);

            ChargerDGV();
            ADO.CleanForm(this);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = $" update Filière set nom_Fil='{txtName.Text}',CodeNiveau={ComboNiveau.SelectedValue.ToString()},code_secteur={ComboSecteur.SelectedValue.ToString()} where code_Fil={txtId.Text}";
            ADO.Execute(cmd);
            ChargerDGV();
            ADO.CleanForm(this);

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $" delete from Filière where code_Fil={txtId.Text}";
            ADO.Execute(cmd);
            ChargerDGV();
            ADO.CleanForm(this);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //ComboNiveau.Text = ComboSecteur.Text = "";
                DataGridViewRow row = dataGridView1.CurrentRow;
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[3].Value.ToString();

                SqlDataAdapter adapter = new SqlDataAdapter($"select code_secteur,CodeNiveau from Filière where code_Fil = {row.Cells[0].Value.ToString()}", ADO.Cnx);
                Console.WriteLine(row.Cells[0].Value.ToString());
                DataSet ds1 = new DataSet();

                adapter.Fill(ds1, "table");

                ComboSecteur.SelectedValue = ds1.Tables["table"].Rows[0][0].ToString();

                ComboNiveau.SelectedValue = ds1.Tables["table"].Rows[0][1].ToString();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
