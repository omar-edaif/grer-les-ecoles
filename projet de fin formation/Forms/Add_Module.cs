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
    public partial class Add_Module : MetroFramework.Forms.MetroForm
    {
        public Add_Module()
        {
            InitializeComponent();
        }
        public void ChargerDGV()
        {
            // TODO: This line of code loads data into the 'gestionModule.Module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.gestionModule.Module);

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"insert into Module values('{TxtModule.Text}')";
            ADO.Execute(cmd);
            this.Close();
          
        }

        private void Add_Module_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionModule.Module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.gestionModule.Module);

        }

        private void BtnSuprimer_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ModulesDGV.CurrentRow;
            DialogResult dialogResult = MessageBox.Show("vous etes sure de supprimer ce module la ", "La Suppression", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand($"Delete from Module where code_mod = {row.Cells[0].Value.ToString()}");
                ADO.Execute(cmd);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            ChargerDGV();
        }
    }
}
