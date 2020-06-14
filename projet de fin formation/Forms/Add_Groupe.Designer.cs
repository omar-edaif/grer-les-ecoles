namespace projet_de_fin_formation.Forms
{
    partial class Add_Groupe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnOpenFormnewAnneScolaire = new System.Windows.Forms.Button();
            this.comboAnneeScolair = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ComboAnne = new System.Windows.Forms.ComboBox();
            this.comboFiliere = new System.Windows.Forms.ComboBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getGroupes = new projet_de_fin_formation.GetGroupes();
            this.getGroupesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getGroupesTableAdapter = new projet_de_fin_formation.GetGroupesTableAdapters.GetGroupesTableAdapter();
            this.DiplomesDGV = new System.Windows.Forms.DataGridView();
            this.codegroupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeFilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annéescolaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomGroupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annéeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeScolaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getGroupes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGroupesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiplomesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.BtnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Location = new System.Drawing.Point(73, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 100);
            this.panel1.TabIndex = 16;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(272, 44);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 35);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnModifier.FlatAppearance.BorderSize = 0;
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.Transparent;
            this.BtnModifier.Location = new System.Drawing.Point(145, 44);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(106, 35);
            this.BtnModifier.TabIndex = 1;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Transparent;
            this.btnAjouter.Location = new System.Drawing.Point(18, 44);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 35);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnOpenFormnewAnneScolaire);
            this.groupBox1.Controls.Add(this.comboAnneeScolair);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.ComboAnne);
            this.groupBox1.Controls.Add(this.comboFiliere);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 285);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groupe : ";
            // 
            // BtnOpenFormnewAnneScolaire
            // 
            this.BtnOpenFormnewAnneScolaire.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenFormnewAnneScolaire.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.BtnOpenFormnewAnneScolaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOpenFormnewAnneScolaire.FlatAppearance.BorderSize = 0;
            this.BtnOpenFormnewAnneScolaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenFormnewAnneScolaire.Location = new System.Drawing.Point(415, 212);
            this.BtnOpenFormnewAnneScolaire.Name = "BtnOpenFormnewAnneScolaire";
            this.BtnOpenFormnewAnneScolaire.Size = new System.Drawing.Size(22, 25);
            this.BtnOpenFormnewAnneScolaire.TabIndex = 50;
            this.BtnOpenFormnewAnneScolaire.UseVisualStyleBackColor = false;
            this.BtnOpenFormnewAnneScolaire.Click += new System.EventHandler(this.BtnOpenFiliere_Click);
            // 
            // comboAnneeScolair
            // 
            this.comboAnneeScolair.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboAnneeScolair.FormattingEnabled = true;
            this.comboAnneeScolair.Location = new System.Drawing.Point(160, 211);
            this.comboAnneeScolair.Name = "comboAnneeScolair";
            this.comboAnneeScolair.Size = new System.Drawing.Size(249, 29);
            this.comboAnneeScolair.TabIndex = 49;
            this.comboAnneeScolair.Enter += new System.EventHandler(this.comboAnneeScolair_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Année Scolaire :";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtName.Location = new System.Drawing.Point(160, 86);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(249, 28);
            this.TxtName.TabIndex = 15;
            // 
            // ComboAnne
            // 
            this.ComboAnne.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboAnne.FormattingEnabled = true;
            this.ComboAnne.Items.AddRange(new object[] {
            "Premiére année",
            "Deuxiéme année"});
            this.ComboAnne.Location = new System.Drawing.Point(160, 169);
            this.ComboAnne.Name = "ComboAnne";
            this.ComboAnne.Size = new System.Drawing.Size(249, 29);
            this.ComboAnne.TabIndex = 13;
            // 
            // comboFiliere
            // 
            this.comboFiliere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboFiliere.FormattingEnabled = true;
            this.comboFiliere.Location = new System.Drawing.Point(160, 127);
            this.comboFiliere.Name = "comboFiliere";
            this.comboFiliere.Size = new System.Drawing.Size(249, 29);
            this.comboFiliere.TabIndex = 13;
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcode.Location = new System.Drawing.Point(160, 45);
            this.txtcode.Name = "txtcode";
            this.txtcode.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(249, 28);
            this.txtcode.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Année :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Filiére :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom Groupe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code Groupe :";
            // 
            // getGroupes
            // 
            this.getGroupes.DataSetName = "GetGroupes";
            this.getGroupes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getGroupesBindingSource
            // 
            this.getGroupesBindingSource.DataMember = "GetGroupes";
            this.getGroupesBindingSource.DataSource = this.getGroupes;
            // 
            // getGroupesTableAdapter
            // 
            this.getGroupesTableAdapter.ClearBeforeFill = true;
            // 
            // DiplomesDGV
            // 
            this.DiplomesDGV.AllowUserToAddRows = false;
            this.DiplomesDGV.AllowUserToDeleteRows = false;
            this.DiplomesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiplomesDGV.AutoGenerateColumns = false;
            this.DiplomesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiplomesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DiplomesDGV.BackgroundColor = System.Drawing.Color.White;
            this.DiplomesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiplomesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DiplomesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DiplomesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DiplomesDGV.ColumnHeadersHeight = 36;
            this.DiplomesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codegroupeDataGridViewTextBoxColumn,
            this.codeFilDataGridViewTextBoxColumn,
            this.annéescolaireDataGridViewTextBoxColumn,
            this.nomFilDataGridViewTextBoxColumn,
            this.nomGroupeDataGridViewTextBoxColumn,
            this.annéeDataGridViewTextBoxColumn,
            this.anneeScolaireDataGridViewTextBoxColumn});
            this.DiplomesDGV.DataSource = this.getGroupesBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiplomesDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.DiplomesDGV.EnableHeadersVisualStyles = false;
            this.DiplomesDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DiplomesDGV.Location = new System.Drawing.Point(542, 131);
            this.DiplomesDGV.Name = "DiplomesDGV";
            this.DiplomesDGV.ReadOnly = true;
            this.DiplomesDGV.RowHeadersVisible = false;
            this.DiplomesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiplomesDGV.Size = new System.Drawing.Size(700, 447);
            this.DiplomesDGV.TabIndex = 22;
            this.DiplomesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiplomesDGV_CellClick);
            // 
            // codegroupeDataGridViewTextBoxColumn
            // 
            this.codegroupeDataGridViewTextBoxColumn.DataPropertyName = "Code_groupe";
            this.codegroupeDataGridViewTextBoxColumn.HeaderText = "Code_groupe";
            this.codegroupeDataGridViewTextBoxColumn.Name = "codegroupeDataGridViewTextBoxColumn";
            this.codegroupeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codegroupeDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeFilDataGridViewTextBoxColumn
            // 
            this.codeFilDataGridViewTextBoxColumn.DataPropertyName = "CodeFil";
            this.codeFilDataGridViewTextBoxColumn.HeaderText = "CodeFil";
            this.codeFilDataGridViewTextBoxColumn.Name = "codeFilDataGridViewTextBoxColumn";
            this.codeFilDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeFilDataGridViewTextBoxColumn.Visible = false;
            // 
            // annéescolaireDataGridViewTextBoxColumn
            // 
            this.annéescolaireDataGridViewTextBoxColumn.DataPropertyName = "Année_scolaire";
            this.annéescolaireDataGridViewTextBoxColumn.HeaderText = "Année_scolaire";
            this.annéescolaireDataGridViewTextBoxColumn.Name = "annéescolaireDataGridViewTextBoxColumn";
            this.annéescolaireDataGridViewTextBoxColumn.ReadOnly = true;
            this.annéescolaireDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomFilDataGridViewTextBoxColumn
            // 
            this.nomFilDataGridViewTextBoxColumn.DataPropertyName = "nom_Fil";
            this.nomFilDataGridViewTextBoxColumn.HeaderText = "Filiere";
            this.nomFilDataGridViewTextBoxColumn.Name = "nomFilDataGridViewTextBoxColumn";
            this.nomFilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomGroupeDataGridViewTextBoxColumn
            // 
            this.nomGroupeDataGridViewTextBoxColumn.DataPropertyName = "Nom_Groupe";
            this.nomGroupeDataGridViewTextBoxColumn.HeaderText = "Groupe";
            this.nomGroupeDataGridViewTextBoxColumn.Name = "nomGroupeDataGridViewTextBoxColumn";
            this.nomGroupeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // annéeDataGridViewTextBoxColumn
            // 
            this.annéeDataGridViewTextBoxColumn.DataPropertyName = "Année";
            this.annéeDataGridViewTextBoxColumn.HeaderText = "Année";
            this.annéeDataGridViewTextBoxColumn.Name = "annéeDataGridViewTextBoxColumn";
            this.annéeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anneeScolaireDataGridViewTextBoxColumn
            // 
            this.anneeScolaireDataGridViewTextBoxColumn.DataPropertyName = "AnneeScolaire";
            this.anneeScolaireDataGridViewTextBoxColumn.HeaderText = "Annee Scolaire";
            this.anneeScolaireDataGridViewTextBoxColumn.Name = "anneeScolaireDataGridViewTextBoxColumn";
            this.anneeScolaireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Add_Groupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 654);
            this.Controls.Add(this.DiplomesDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Groupe";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "Gestion des groupe ";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Add_Groupe_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getGroupes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGroupesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiplomesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox comboFiliere;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.ComboBox ComboAnne;
        private System.Windows.Forms.Button BtnOpenFormnewAnneScolaire;
        private System.Windows.Forms.ComboBox comboAnneeScolair;
        private System.Windows.Forms.Label label5;
        private GetGroupes getGroupes;
        private System.Windows.Forms.BindingSource getGroupesBindingSource;
        private GetGroupesTableAdapters.GetGroupesTableAdapter getGroupesTableAdapter;
        private System.Windows.Forms.DataGridView DiplomesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn codegroupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeFilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annéescolaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomGroupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annéeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeScolaireDataGridViewTextBoxColumn;
    }
}