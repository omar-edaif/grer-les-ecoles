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
    public partial class Form_Menu : MetroFramework.Forms.MetroForm    {
        User CurrentUser;
        public Form_Menu()
        {
            InitializeComponent();
            this.Hide();  
        }
        #region FlowControl
        private void pb_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                (sender as PictureBox).Parent.Size = new Size(195, 235);
                (sender as PictureBox).Size = new Size(195, 195);
            }
            if (sender is Label)
            {
                (sender as Label).Parent.Size = new Size(195, 235);
                foreach (var item in (sender as Label).Parent.Controls.OfType<PictureBox>())
                {
                    item.Size = new Size(195, 195);
                }
            }

        }

        private void pb_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                (sender as PictureBox).Parent.Size = new Size(185, 225);
                (sender as PictureBox).Size = new Size(185, 185);
            }
            if (sender is Label)
            {
                (sender as Label).Parent.Size = new Size(185, 225);
                foreach (var item in (sender as Label).Parent.Controls.OfType<PictureBox>())
                {
                    item.Size = new Size(185, 185);
                }
            }

        }
        #endregion
        #region eventHandlers
        private void pictureBoxGestionEnseignants_Click(object sender, EventArgs e)
        {
            Form_Enseignant FormEnsgnt = new Form_Enseignant();
            FormEnsgnt.WindowState = FormWindowState.Maximized;
            FormEnsgnt.ShowDialog();
        }

        private void pictureBoxGestionStagaires_Click(object sender, EventArgs e)
        {
            Form_inscription formInscription = new Form_inscription();
            formInscription.WindowState = FormWindowState.Maximized;
            formInscription.ShowDialog();

        }

        private void pictureBoxGestienModules_Click(object sender, EventArgs e)
        {
            Add_filiere_module formFilier = new Add_filiere_module();
            formFilier.ShowDialog();

        }

        private void pictureBoxGestienGroupes_Click(object sender, EventArgs e)
        {
            Add_Groupe ad = new Add_Groupe();
            ad.ShowDialog();
        }

        private void pictureBoxGestionFilières_Click(object sender, EventArgs e)
        {
            Add_Filiere af = new Add_Filiere();
            af.ShowDialog();
        }

        private void pictureBoxGestionSecteurs_Click(object sender, EventArgs e)
        {
            Add_secteur secteur = new Add_secteur();
            secteur.ShowDialog();
        }

        private void pictureBoxGestionDiplôme_Click(object sender, EventArgs e)
        {
            Add_Diplome diplome = new Add_Diplome();
            diplome.ShowDialog();
        }

        private void pictureBoxGestienNiveau_Click(object sender, EventArgs e)
        {
            Add_Niveau niveau = new Add_Niveau();
            niveau.ShowDialog();
        }

        private void pictureBoxGestionExamens_Click(object sender, EventArgs e)
        {
            Form_Exam exam = new Form_Exam();
            exam.ShowDialog();
        }
        #endregion

        private void BtnModifierinfo_Click(object sender, EventArgs e)
        {
            panelUtilisatuerInformation.Visible = true;

        }

        private void buttonChangerMoteDePass_Click(object sender, EventArgs e)
        {
            panelUtilisatuerInformation.Visible = false;
        }

        private void buttonDeconnecter_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelUtilisatuerInformation.Visible = false;
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Form_User login = new Form_User(CurrentUser);            
            if (login.ShowDialog() == DialogResult.OK)
            {
                CurrentUser = login.LogedUser;
                this.lblUserName.Text= CurrentUser.Username;
                this.lblRole.Text = CurrentUser.Role;
                foreach (var item in CurrentUser.Permissions)
                {
                    foreach (var control in flowLayoutPanelMenuIcon.Controls.OfType<Panel>())
                    {
                        if (string.Equals(control.Name,"panel"+item))
                        {
                            control.Visible = true;
                        } 
                    }

                }
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Add_NewUser user = new Add_NewUser();
            user.ShowDialog();
        }
    }
}
