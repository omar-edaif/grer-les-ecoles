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
    public partial class Add_Diplome : MetroFramework.Forms.MetroForm
    {
        public Add_Diplome()
        {
            InitializeComponent();
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Diplome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getDiplome._GetDiplome' table. You can move, or remove it, as needed.
            this.getDiplomeTableAdapter.Fill(this.getDiplome._GetDiplome);
            // charger combobox Specialite
            ChargerComboBox.ChargerComboNiveau(comboNiveau);

            // Charger combobox secteur       
            ChargerComboBox.ChargerComboSecteur(combosecteur);
         }
        public void ChargerDGV()
        {
            // TODO: This line of code loads data into the 'getDiplome._GetDiplome' table. You can move, or remove it, as needed.
            this.getDiplomeTableAdapter.Fill(this.getDiplome._GetDiplome);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand($"insert into Diplome values('{TxtName.Text}',{combosecteur.SelectedValue.ToString()},{comboNiveau.SelectedValue.ToString()})");
            ADO.Execute(cmd);
            ChargerDGV();
            ADO.CleanForm(this);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update Diplome set IntituléDiplome='{TxtName.Text}',Code_secteur = {combosecteur.SelectedValue.ToString()},Code_Niveau = {comboNiveau.SelectedValue.ToString()} where Code_Diplome ={txtcode.Text}");
            ADO.Execute(cmd);
            ChargerDGV();
            ADO.CleanForm(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"Delete Diplome where Code_Diplome ={txtcode.Text}");
            ADO.Execute(cmd);
            ChargerDGV();
            ADO.CleanForm(this);
        }

        private void DiplomesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //ComboNiveau.Text = ComboSecteur.Text = "";
                DataGridViewRow row = DiplomesDGV.CurrentRow;
                txtcode.Text = row.Cells[0].Value.ToString();
                TxtName.Text = row.Cells[1].Value.ToString();

                SqlDataAdapter adapter = new SqlDataAdapter($"select code_secteur,Code_Niveau from Diplome where Code_Diplome = {row.Cells[0].Value.ToString()}", ADO.Cnx);
                Console.WriteLine(row.Cells[0].Value.ToString());
                DataSet ds1 = new DataSet();

                adapter.Fill(ds1, "table");

                combosecteur.SelectedValue = ds1.Tables["table"].Rows[0][0].ToString();

                comboNiveau.SelectedValue = ds1.Tables["table"].Rows[0][1].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
