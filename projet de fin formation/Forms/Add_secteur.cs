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
    public partial class Add_secteur : MetroFramework.Forms.MetroForm
    {
        public Add_secteur()
        {
            InitializeComponent();
        }
        public void ChargerDataGridView()
        {
            // TODO: This line of code loads data into the 'aPP_EcoleDataSet1.Secteur' table. You can move, or remove it, as needed.
            this.secteurTableAdapter.Fill(this.aPP_EcoleDataSet1.Secteur);

        }
        

        private void Add_secteur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPP_EcoleDataSet1.Secteur' table. You can move, or remove it, as needed.
            this.secteurTableAdapter.Fill(this.aPP_EcoleDataSet1.Secteur);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"insert into secteur values('{txtName.Text.Trim()}','{DateTime.Now.ToShortDateString()}')";
            ADO.Execute(cmd);
            ChargerDataGridView();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"update Secteur set intitulé_sect ='{txtName.Text.Trim()}'where code_sect={TxtCodeSecteur.Text}";
            ADO.Execute(cmd);
            ChargerDataGridView();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"Delete from secteur where code_sect={TxtCodeSecteur.Text}";
            ADO.Execute(cmd);
            ChargerDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
    
            TxtCodeSecteur.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();

        }
    }
}
