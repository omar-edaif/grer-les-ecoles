using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button5_Click(object sender, EventArgs e)
        {

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
                if (string.IsNullOrEmpty(ComboModule.Text)&&string.IsNullOrEmpty(ComboGroupe.Text))
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
                var x = row.Cells[4].Value?.ToString();
                MessageBox.Show(x);
                if (string.IsNullOrEmpty(row.Cells[4].Value.ToString()) || int.TryParse((x),out valuecell))
                {
                    MessageBox.Show("un note");

                }
                else
                {
                    MessageBox.Show("une note est inccorrect or cell empty");
                }
                      
            }
        }
        private void OpenFormSecteur_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_secteur secteur = new Add_secteur();
            secteur.ShowDialog();
        }

        private void OpenFormFiliere_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Filiere filiere= new Add_Filiere ();
            filiere.ShowDialog();
        }

        private void OpenFormGroupe_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Groupe Groupe = new  Add_Groupe ();
            Groupe.ShowDialog();
        }

        private void OpenFormModule_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Module Module= new Add_Module  ();
            Module.ShowDialog();
        }

       

        private void ExamDGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void ExamDGV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            decimal x;
            var cell = ExamDGV.CurrentCell;
            var cell1 = sender as DataGridViewCell;
            var c2 = cell1.Value.ToString();
            if (decimal.TryParse(cell.Value.ToString(), out x))
            {
                ExamDGV.CurrentCell.Value = "am9os";

            }
            else
            {
                ExamDGV.CurrentCell.Value = "ikhan";
            }
        }
    }
}
