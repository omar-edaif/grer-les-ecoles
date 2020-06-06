using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;


namespace projet_de_fin_formation
{
    public partial class Add_Niveau : MetroFramework.Forms.MetroForm
    {
        public Add_Niveau()
        {
            InitializeComponent();
        }

         public void ChargerDGV()
        {
            this.niveauTableAdapter.Fill(this.aPP_EcoleDataSet.Niveau);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPP_EcoleDataSet.Niveau' table. You can move, or remove it, as needed.
            ChargerDGV();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"insert into niveau values('{txtName.Text.Trim()}','{DateTime.Now.ToShortDateString()}')";
            ADO.Execute(cmd);
            ChargerDGV();
        }
        //code modifier les niveaux

        private void BtnModifier_Click(object sender, EventArgs e)
                {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"update Niveau set intitué_niveau='{txtName.Text.Trim()}'where Code_niveau={TxtCodeNiveau.Text}";
            ADO.Execute(cmd);
            // Charger DataGridView 
            ChargerDGV();

        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"Delete from Niveau where Code_niveau={TxtCodeNiveau.Text}";
            ADO.Execute(cmd);

            // Charger DataGridView 
            ChargerDGV();
        }
         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;

            TxtCodeNiveau.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
        }




        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Invalide"); 
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
            }
      }

       
    }
}
