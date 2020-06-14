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
    public partial class Form_inscription : MetroFramework.Forms.MetroForm
    {
        public Form_inscription()
        {
            InitializeComponent();
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }


        public int NombreStagairInGroupe(string GroupeOfStagaire)
        {
            int Nombre=0;
            try
            {
                SqlCommand cmd = new SqlCommand($"select COUNT (Code_groupe) from Inscription where Code_groupe = {GroupeOfStagaire}",ADO.Cnx);
                ADO.OpenOrCloseConnection();
                Nombre = (int)cmd.ExecuteScalar();
                ADO.OpenOrCloseConnection();
              
                
            }
            catch
            {
              
            }
            return Nombre;
        }
        public void ChargerDGV()
        {
            // TODO: This line of code loads data into the 'getStagaire._GetStagaire' table. You can move, or remove it, as needed.
            this.getStagaireTableAdapter.Fill(this.getStagaire._GetStagaire);
        }
      
        private void Form_inscription_Load(object sender, EventArgs e)
        {

            ChargerDGV();
            // charger combobox de ***secteur***
            ChargerComboBox.ChargerComboSecteur(ComboSecteur);
            //
       
             

        }

      

        private void OpenFormSecteur_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_secteur FormSecteur = new Add_secteur();
            FormSecteur.ShowDialog();
        }

        private void FormOpenFiliere_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Filiere filiere = new Add_Filiere();
            filiere.ShowDialog();
        }

        private void OpenFormGroupes_Click(object sender, EventArgs e)
        {
            projet_de_fin_formation.Forms.Add_Groupe groupe = new Add_Groupe();
            groupe.ShowDialog();
        }

        private void comboFiliere_Enter(object sender, EventArgs e)
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

        private void ComboGroupes_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboFiliere.Text))
            {
                ChargerComboBox.ChargerComboGroupes(ComboGroupes, ComboFiliere.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("choisir un Filiere !!!!! ");
                ComboFiliere.Focus();
                return;

            }
          

        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All Files |*.*|JPG|*.jpg|PNG|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgStudent.Image = Image.FromFile(ofd.FileName);
                }


            }
            catch
            {
                MessageBox.Show("Quelque chose s'est mal passé");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (NombreStagairInGroupe(ComboGroupes.SelectedValue.ToString())<=30)
                {
                    var image = ImageToByte(imgStudent.Image);
                    SqlCommand InsertStagire = new SqlCommand($"insert");


                }
            }
            catch (Exception)
            {

                throw;
            }
            SqlCommand cmd = new SqlCommand("select COUNT (Code_groupe) from Inscription where Code_groupe =2");


            cmd = new SqlCommand("insert into Inscription values ( (select MAX(code_stagiaire)from Stagiaire),1,GETDATE())");
        }
    }
}
