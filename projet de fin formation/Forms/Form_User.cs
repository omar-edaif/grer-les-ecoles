
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_de_fin_formation.Forms
{
    public partial class Form_User : MetroFramework.Forms.MetroForm
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PFF"].ConnectionString;
        public User LogedUser;
        public Form_User( User user)
        {
            LogedUser = user ;
            InitializeComponent();
        }

        private void buttonChangerMoteDePass_Click(object sender, EventArgs e)
        {
            if ((!(string.IsNullOrEmpty(TxtNomUtilisateur.Text) || string.IsNullOrWhiteSpace(TxtNomUtilisateur.Text)) && !(string.IsNullOrEmpty(textBoxMoteDePass.Text) || string.IsNullOrWhiteSpace(textBoxMoteDePass.Text))))
            {
                using (SqlConnection Cnx = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT code_User,LoginUser,mot_de_passe,IdRole,dbo.Role.Name FROM compteUser INNER JOIN dbo.Role on compteUser.IdRole = dbo.Role.Id WHERE LoginUser = @login ;",Cnx);
                    command.Parameters.Add(new SqlParameter("login", TxtNomUtilisateur.Text));
                    Cnx.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();                        
                        if (string.Equals(UserServices.ComputePasswordHash(textBoxMoteDePass.Text), reader.GetString(2)))
                        {
                            LogedUser = new User() { Id = reader.GetInt32(0), Username = reader.GetString(1), IdRole = reader.GetInt32(3), Role = reader.GetString(4) };
                            LogedUser.Permissions = UserServices.GetPermissionsForRole(LogedUser.IdRole);
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Mot de pass est incorect \n Merci de contacter l'administrateur ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ne'exist pas \nMerci de contacter l'administrateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de pass ne peut pas etre vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
