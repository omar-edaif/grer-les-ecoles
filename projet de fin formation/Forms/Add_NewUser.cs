using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_de_fin_formation.Forms
{
    public partial class Add_NewUser : MetroFramework.Forms.MetroForm
    {
        public Add_NewUser()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtcode_user.Text = (Convert.ToInt32(aPP_EcoleDataSet4.UserRoles.AsEnumerable().Max(row => row["code_User"]))+1).ToString() ;
            TxtName.Text = string.Empty;
            textPassword.Text = string.Empty;
            ComboBoxRole.SelectedValue = 1;
            BtnModifier.Visible = btnSupprimer.Visible = false;
        }

        private void Add_NewUser_Load(object sender, EventArgs e)
        {
            //  This line of code loads data into the 'aPP_EcoleDataSet4.UserRoles' table. 
            this.userRolesTableAdapter.Fill(this.aPP_EcoleDataSet4.UserRoles);

            ClearInputFields();
            ComboBoxRole.ValueMember = "Id";
            ComboBoxRole.DisplayMember = "Name";
            ComboBoxRole.DataSource = UserServices.GetAllRoles();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Visible))
            {
                try
                {
                UserServices.AddUser(TxtName.Text.Trim(), textPassword.Text, (int)ComboBoxRole.SelectedValue);
                this.userRolesTableAdapter.Fill(aPP_EcoleDataSet4.UserRoles);
                ClearInputFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"ERREUR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            return;                
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Voulez vous modifier l'utilisateur suivant: \n\t \" {TxtName.Text} \"","Questien", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserServices.UpdateUser(int.Parse(txtcode_user.Text), TxtName.Text, textPassword.Text, (int)ComboBoxRole.SelectedValue);
                this.userRolesTableAdapter.Fill(aPP_EcoleDataSet4.UserRoles);
                ClearInputFields();
            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Voulez vous supprimer l'utilisateur suivant: \n\t \" {TxtName.Text} \"", "Questien", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (UserServices.DeleteUser(int.Parse(txtcode_user.Text)))
                {
                    MessageBox.Show("Operation Effectuier","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.userRolesTableAdapter.Fill(aPP_EcoleDataSet4.UserRoles);
                    ClearInputFields();
                }
            }
        }

        private void datagridviewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 )
            {
                e.Value = new string('\u25CF', e.Value.ToString().Length);
            }
        }

        private void datagridviewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User selectedUser = UserServices.GetUserById((int)datagridviewUsers.CurrentRow.Cells[0].Value);
            txtcode_user.Text = selectedUser.Id.ToString();
            TxtName.Text = selectedUser.Username;
            textPassword.Text = selectedUser.Password;
            ComboBoxRole.SelectedValue = selectedUser.IdRole;
            BtnModifier.Visible = btnSupprimer.Visible = true;
            
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
           if( aPP_EcoleDataSet4.UserRoles.AsEnumerable().Select(al => al.Field<String>("LoginUser")).Contains((sender as TextBox).Text.Trim()))
            {
                errorProvider1.SetError((sender as TextBox), "Ce nom d'utilisateur existe déjà");
                e.Cancel = true;
            }
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text)|| string.IsNullOrEmpty((sender as TextBox).Text))
            {
                errorProvider1.SetError((sender as TextBox), "Invalide Nome d'utilisateur");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                e.Cancel = true;
            }
        }

        private void textPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch((sender as TextBox).Text, @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{6,15}$"))
            {
                errorProvider1.SetError((sender as TextBox), "Le mot de passe doit comporter au moins 6 caractères,mais pas plus de 15 \nau moins(une lettre majuscule, un chiffre, une minuscule)");
                e.Cancel = true;                
            }
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text) || string.IsNullOrEmpty((sender as TextBox).Text))
            {
                errorProvider1.SetError((sender as TextBox), "Invalide mote de passe");
                e.Cancel = true;
            }
        }

        private void textPassword_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

    }
}
