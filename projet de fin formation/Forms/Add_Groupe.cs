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
    public partial class Add_Groupe : MetroFramework.Forms.MetroForm
    {
        public Add_Groupe()
        {
            InitializeComponent();
        }
        // charger DGv des Groupes
        public void ChargerDGV()
        {

            // TODO: This line of code loads data into the 'getGroupes._GetGroupes' table. You can move, or remove it, as needed.
            this.getGroupesTableAdapter.Fill(this.getGroupes._GetGroupes);
        }
        private void Add_Groupe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getGroupes._GetGroupes' table. You can move, or remove it, as needed.
            this.getGroupesTableAdapter.Fill(this.getGroupes._GetGroupes);
            // charger combobox Filiere
            ChargerComboBox.ChargerComboFiliere(comboFiliere);
            // charger cmobobox Anne scolair
            ChargerComboBox.ChargerComboAnneeScolaire(comboAnneeScolair);
            

        }

       

        private void BtnOpenFiliere_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_AnneeScolaire AnneScolaire = new Add_AnneeScolaire();
            AnneScolaire.ShowDialog();
        }

        private void DiplomesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DiplomesDGV.CurrentRow;
            txtcode.Text = row.Cells[0].Value.ToString();
           TxtName.Text = row.Cells[4].Value.ToString();
            ComboAnne.Text = row.Cells[5].Value.ToString();
            comboAnneeScolair.SelectedValue = row.Cells[2].Value.ToString();
            comboFiliere.SelectedValue = row.Cells[1].Value.ToString();


        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($" insert into Groupe values ('{TxtName.Text}',{comboAnneeScolair.SelectedValue.ToString()},'{ComboAnne.Text}',{comboFiliere.SelectedValue.ToString()})");
            ADO.Execute(cmd);

            // charger DGV
            ChargerDGV();
            ADO.CleanForm(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( txtcode.Text))
            {
                MessageBox.Show("CHOISISSEZ UNE RANGÉE DANS LE TABLEAU");
            }
   else{
                SqlCommand cmd = new SqlCommand($"Delete from deplome where Code_groupe = {txtcode.Text }");
                ADO.Execute(cmd);
                ChargerDGV();

            }
        }

        private void comboAnneeScolair_Enter(object sender, EventArgs e)
        {
            // charger cmobobox Anne scolair
            ChargerComboBox.ChargerComboAnneeScolaire(comboAnneeScolair);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update Groupe set Nom_Groupe ='{ TxtName.Text}',Année_scolaire ={ comboAnneeScolair.SelectedValue.ToString()}, Année =' {ComboAnne.Text }',CodeFil ={ comboFiliere.SelectedValue.ToString()} where Code_groupe = {txtcode.Text }");
            ADO.Execute(cmd);
            ChargerDGV();
            ADO.CleanForm(this);

        }
    }
}
