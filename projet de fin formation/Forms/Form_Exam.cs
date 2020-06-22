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
    public partial class Form_Exam : MetroFramework.Forms.MetroForm
    {

        public Form_Exam()
        {
            InitializeComponent();
        }
        public static int? idGroupe = null;
        private int valuecell;
        private bool Validates(object formattedValue)
        {
            if (formattedValue is string && formattedValue != null)
            {
                double value;
                return double.TryParse(formattedValue as string, out value) && value <= 40 ;
            }
            return false;
        }

        public void ChargerDGV()
        {

        }

        private void Form_Exam_Load(object sender, EventArgs e)
        {
            // charger combobox de secteur
            ChargerComboBox.ChargerComboSecteur(ComboSecteur);
            // charger combox de modules
            ChargerComboBox.ChargerComboModule(ComboModule);

        }
        
        private void ComboFiliere_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboSecteur.Text))
            {
                ChargerComboBox.ChargerComboFiliere(ComboFiliere, ComboSecteur.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("choisir un secteur !!!!! ");

            }
        }

        private void ComboGroupe_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboFiliere.Text))
            {
                ChargerComboBox.ChargerComboGroupes(ComboGroupe, ComboFiliere.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("choisir un Filiere !!!!! ");
                ComboFiliere.Focus();
                return;
            }
        }

        private void ComboGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ComboModule.Text) && string.IsNullOrEmpty(ComboGroupe.Text))
                {
                    return;
                }
                else
                {
                    getExamsTableAdapter.Fill(getExams._GetExams, (int)ComboGroupe.SelectedValue, (int)ComboModule.SelectedValue);
                }

            }
            catch
            {

            }


        }

        private void ComboModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ComboModule.Text) && string.IsNullOrEmpty(ComboGroupe.Text))
                {
                    return;
                }
                else
                {
                    getExamsTableAdapter.Fill(getExams._GetExams, (int)ComboGroupe.SelectedValue, (int)ComboModule.SelectedValue);
                }

            }
            catch
            {

            }
        }




        private void Sauvgard_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in ExamDGV.Rows)
            {
                if (row.Cells[4].Value == null || row.Cells[4].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[4].Value.ToString()))
                {
                    MessageBox.Show("un note n'est pas valid");
                    return;
                }
            }

            SqlCommand cmd;
            
            foreach (DataGridViewRow row in ExamDGV.Rows)
            {
                cmd = new SqlCommand($"insert into Examen values({row.Cells[0].Value.ToString()},{ComboModule.SelectedValue.ToString()},getdate(),{row.Cells[4].Value.ToString()})",ADO.Cnx);
                ADO.Execute(cmd);
            }
        }
        private void OpenFormSecteur_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_secteur secteur = new Add_secteur();
            secteur.ShowDialog();
        }

        private void OpenFormFiliere_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Filiere filiere = new Add_Filiere();
            filiere.ShowDialog();
        }

        private void OpenFormGroupe_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Groupe Groupe = new Add_Groupe();
            Groupe.ShowDialog();
        }

        private void OpenFormModule_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Module Module = new Add_Module();
            Module.ShowDialog();
        }


        private void ExamDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (ExamDGV.CurrentCell.ColumnIndex == 4)
            {
                if (e.Control !=null&& e.Control is TextBox)
                {
                   e.Control.KeyPress += Control_KeyPress;
                }
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void ExamDGV_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!this.Validates(e.FormattedValue) && e.ColumnIndex == 4) 
            {
                if (ExamDGV.EditingControl != null)
                {
                    e.Cancel = true;
                    ep.SetError(ExamDGV.EditingControl, "Note invalide \"##,##\"");
                    ep.SetIconAlignment(ExamDGV.EditingControl, ErrorIconAlignment.MiddleRight);
                    ep.SetIconPadding(ExamDGV.EditingControl, -20);
                }
                
            }
            else
            {
                ep.Clear();
                e.Cancel = false;
            }
        }

       
    }
}
