using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_de_fin_formation.Forms
{
    public partial class Add_filiere_module : MetroFramework.Forms.MetroForm
    {
        public Add_filiere_module()
        {
            InitializeComponent();
        }
        public void ChargerDGV()
        {
            // TODO: This line of code loads data into the 'aPP_EcoleDataSet3.GetModuleFiliere' table. You can move, or remove it, as needed.
            this.getModuleFiliereTableAdapter.Fill(this.aPP_EcoleDataSet3.GetModuleFiliere);
        }
        private void Add_filiere_module_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPP_EcoleDataSet3.GetModuleFiliere' table. You can move, or remove it, as needed.
            this.getModuleFiliereTableAdapter.Fill(this.aPP_EcoleDataSet3.GetModuleFiliere);
            ChargerDGV(); 
            // charger combobox Filiere 
            ChargerComboBox.ChargerComboFiliere(comboFiliere);

            // charger combobox Module
            ChargerComboBox.ChargerComboModule(comboModule);

        }

        private void BtnOpenFiliere_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Filiere filiere = new Add_Filiere();
            filiere.ShowDialog();
        }

        private void BtnOpenModule_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Module Module= new Add_Module();
            Module.ShowDialog();
        }

    

        private void comboModule_Enter(object sender, EventArgs e)
        {
            ChargerComboBox.ChargerComboModule(comboModule);
        }

        private void comboFiliere_Enter(object sender, EventArgs e)
        {
            ChargerComboBox.ChargerComboFiliere(comboFiliere);
        }

    
        private void TxtMasseHoraire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
       && !char.IsDigit(e.KeyChar)
       && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            else if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
          
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into ModuleFiliere values({comboModule.SelectedValue.ToString()},{comboFiliere.SelectedValue.ToString()},{TxtMasseHoraire.Text},{TxtCofficient.Text})");
            ADO.Execute(cmd);
            ChargerDGV();
            ADO.CleanForm(this);


        }

        private void Btn_Suprimer_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ModuleFiliereDGV.CurrentRow;
            DialogResult dialogResult = MessageBox.Show("vous etes sure de supprimer ce module la a cette filiere", "La Suppression", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            SqlCommand cmd = new SqlCommand($"Delete from ModuleFiliere where code_fil={row.Cells[4].Value.ToString()} and code_mod = {row.Cells[5].Value.ToString()}");
                ADO.Execute(cmd);
            }
            else if (dialogResult == DialogResult.No)
            {
    
            }
            ChargerDGV();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
