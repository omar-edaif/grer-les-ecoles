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
    public partial class Add_AnneeScolaire : MetroFramework.Forms.MetroForm
    {
        public Add_AnneeScolaire()
        {
            InitializeComponent();
        }

        private void Add_AnneeScolaire_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into AnneeScolaire values ('{txtAnneScolaire.Text}')");
            ADO.Execute(cmd);
            this.Close();
        }
    }
}
