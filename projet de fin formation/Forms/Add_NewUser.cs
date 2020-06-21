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
    public partial class Add_NewUser : MetroFramework.Forms.MetroForm
    {
        public Add_NewUser()
        {
            InitializeComponent();
        }

        private void Add_NewUser_Load(object sender, EventArgs e)
        {
            ComboBoxRole.ValueMember = "Id";
            ComboBoxRole.DisplayMember = "Name";
            ComboBoxRole.DataSource = UserServices.GetAllRoles();
        }
    }
}
