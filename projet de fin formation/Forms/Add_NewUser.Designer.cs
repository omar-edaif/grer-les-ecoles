namespace projet_de_fin_formation.Forms
{
    partial class Add_NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridviewUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxRole = new MetroFramework.Controls.MetroComboBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.txtcode_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aPP_EcoleDataSet4 = new projet_de_fin_formation.APP_EcoleDataSet4();
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRolesTableAdapter = new projet_de_fin_formation.APP_EcoleDataSet4TableAdapters.UserRolesTableAdapter();
            this.codeUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motdepasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPP_EcoleDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewUsers
            // 
            this.datagridviewUsers.AllowUserToAddRows = false;
            this.datagridviewUsers.AllowUserToDeleteRows = false;
            this.datagridviewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridviewUsers.AutoGenerateColumns = false;
            this.datagridviewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datagridviewUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridviewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.datagridviewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.datagridviewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewUsers.ColumnHeadersHeight = 36;
            this.datagridviewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeUserDataGridViewTextBoxColumn,
            this.loginUserDataGridViewTextBoxColumn,
            this.motdepasseDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.datagridviewUsers.DataSource = this.userRolesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewUsers.EnableHeadersVisualStyles = false;
            this.datagridviewUsers.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.datagridviewUsers.Location = new System.Drawing.Point(488, 72);
            this.datagridviewUsers.Name = "datagridviewUsers";
            this.datagridviewUsers.ReadOnly = true;
            this.datagridviewUsers.RowHeadersVisible = false;
            this.datagridviewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewUsers.Size = new System.Drawing.Size(542, 490);
            this.datagridviewUsers.TabIndex = 0;
            this.datagridviewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewUsers_CellClick);
            this.datagridviewUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagridviewUsers_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.BtnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Location = new System.Drawing.Point(16, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 85);
            this.panel1.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(310, 25);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 35);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Visible = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnModifier.FlatAppearance.BorderSize = 0;
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.Transparent;
            this.BtnModifier.Location = new System.Drawing.Point(183, 25);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(106, 35);
            this.BtnModifier.TabIndex = 1;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Visible = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Transparent;
            this.btnAjouter.Location = new System.Drawing.Point(56, 25);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 35);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxRole);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.txtcode_user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groupe : ";
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.ItemHeight = 23;
            this.ComboBoxRole.Location = new System.Drawing.Point(167, 168);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Size = new System.Drawing.Size(249, 29);
            this.ComboBoxRole.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(167, 127);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(249, 28);
            this.textPassword.TabIndex = 1;
            this.textPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textPassword_Validating);
            this.textPassword.Validated += new System.EventHandler(this.textPassword_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "Role :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 21);
            this.label18.TabIndex = 44;
            this.label18.Text = "Mote de passe :";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtName.Location = new System.Drawing.Point(167, 86);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(249, 28);
            this.TxtName.TabIndex = 0;
            this.TxtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            this.TxtName.Validated += new System.EventHandler(this.textPassword_Validated);
            // 
            // txtcode_user
            // 
            this.txtcode_user.Enabled = false;
            this.txtcode_user.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcode_user.Location = new System.Drawing.Point(167, 45);
            this.txtcode_user.Name = "txtcode_user";
            this.txtcode_user.ReadOnly = true;
            this.txtcode_user.Size = new System.Drawing.Size(249, 28);
            this.txtcode_user.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom Utlisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code utilisateur :";
            // 
            // aPP_EcoleDataSet4
            // 
            this.aPP_EcoleDataSet4.DataSetName = "APP_EcoleDataSet4";
            this.aPP_EcoleDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "UserRoles";
            this.userRolesBindingSource.DataSource = this.aPP_EcoleDataSet4;
            // 
            // userRolesTableAdapter
            // 
            this.userRolesTableAdapter.ClearBeforeFill = true;
            // 
            // codeUserDataGridViewTextBoxColumn
            // 
            this.codeUserDataGridViewTextBoxColumn.DataPropertyName = "code_User";
            this.codeUserDataGridViewTextBoxColumn.HeaderText = "code_User";
            this.codeUserDataGridViewTextBoxColumn.Name = "codeUserDataGridViewTextBoxColumn";
            this.codeUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // loginUserDataGridViewTextBoxColumn
            // 
            this.loginUserDataGridViewTextBoxColumn.DataPropertyName = "LoginUser";
            this.loginUserDataGridViewTextBoxColumn.HeaderText = "Nom Utililisateur";
            this.loginUserDataGridViewTextBoxColumn.Name = "loginUserDataGridViewTextBoxColumn";
            this.loginUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motdepasseDataGridViewTextBoxColumn
            // 
            this.motdepasseDataGridViewTextBoxColumn.DataPropertyName = "mot_de_passe";
            this.motdepasseDataGridViewTextBoxColumn.HeaderText = "Mot de passe";
            this.motdepasseDataGridViewTextBoxColumn.Name = "motdepasseDataGridViewTextBoxColumn";
            this.motdepasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Role";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Add_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 585);
            this.Controls.Add(this.datagridviewUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Add_NewUser";
            this.Text = "Gestion des utilisateurs";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Add_NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPP_EcoleDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox txtcode_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox ComboBoxRole;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private APP_EcoleDataSet4 aPP_EcoleDataSet4;
        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private APP_EcoleDataSet4TableAdapters.UserRolesTableAdapter userRolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motdepasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}