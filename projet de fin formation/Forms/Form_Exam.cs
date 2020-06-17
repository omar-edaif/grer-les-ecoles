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
        public void ChargerDGV()
        {
            sqldataAdapter
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

        private void button4_Click(object sender, EventArgs e)
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
    }
}
