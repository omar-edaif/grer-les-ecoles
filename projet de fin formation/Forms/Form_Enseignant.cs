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
    public partial class Form_Enseignant : MetroFramework.Forms.MetroForm
    {
        public Form_Enseignant()
        {
            InitializeComponent();
        }
        public void ChargerDGV()
        {
            // TODO: This line of code loads data into the 'getEnsgnient.GetEnsegnient' table. You can move, or remove it, as needed.
            this.getEnsegnientTableAdapter.Fill(this.getEnsgnient.GetEnsegnient);
        }
        private void Form_Enseignant_Load(object sender, EventArgs e)
        {
          
            ChargerDGV();

        }


        private void ComboFiliere_Enter(object sender, EventArgs e)
        {
            ChargerComboBox.ChargerComboFiliere(ComboFiliere);
        }

        private void ComboModule_Enter(object sender, EventArgs e)
        {
            ChargerComboBox.ChargerComboModule(ComboModule);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                
                    SqlCommand InsertEnsgn = new SqlCommand($"insert into Enseignant values ('{TxtName.Text}','{TxtPrenom.Text}','{TxtCin.Text}','{DateNaissance.Text.ToString()}','{TxtAdresse.Text}','{TxtPhone.Text}','{TxtEmail.Text}','{TxtGrade.Text}','{ComboStatu.Text}','{comboGenre.Text}')");
                    ADO.Execute(InsertEnsgn);
                    SqlCommand cmd = new SqlCommand($"insert into Affecation values ( (select MAX(code_Ens)from Enseignant),{ComboModule.SelectedValue.ToString()},{ComboFiliere.SelectedValue.ToString()},GETDATE())");
                    ADO.Execute(cmd);
                ChargerDGV();
                ADO.CleanForm(this);


            }
            catch
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                DataGridViewRow row = dataGridView1 .CurrentRow;
                txtCode.Text = row.Cells[0].Value.ToString();
                TxtName.Text = row.Cells[1].Value.ToString();
                TxtPrenom.Text = row.Cells[2].Value.ToString();
                TxtCin.Text = row.Cells[3].Value.ToString();
                TxtAdresse.Text = row.Cells[5].Value.ToString();
                TxtPhone.Text = row.Cells[6].Value.ToString();
                TxtEmail.Text = row.Cells[7].Value.ToString();
                TxtGrade.Text = row.Cells[8].Value.ToString();
                DateNaissance.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                ComboStatu.Text = row.Cells[9].Value.ToString();

            }
            catch
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("vous voulez vraimennt supprimer l'ensegnient que vous choisire", "La suppression", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var row = dataGridView1.CurrentRow;
                    SqlCommand cmd = new SqlCommand($"delete from Affecation where code_Ens={row.Cells[0].Value.ToString()} delete from Enseignant where code_Ens   = {row.Cells[0].Value.ToString()} ");
                    ADO.Execute(cmd);
                    ChargerDGV();

                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                ChargerDGV();
            }
            catch
            {
            }

        }
    }
}
