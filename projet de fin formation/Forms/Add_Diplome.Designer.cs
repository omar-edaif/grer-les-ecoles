namespace projet_de_fin_formation.Forms
{
    partial class Add_Diplome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.combosecteur = new System.Windows.Forms.ComboBox();
            this.comboNiveau = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.DiplomesDGV = new System.Windows.Forms.DataGridView();
            this.codeDiplomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituléDiplomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitulésectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituéniveauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getDiplomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDiplome = new projet_de_fin_formation.GetDiplome();
            this.getDiplomeTableAdapter = new projet_de_fin_formation.GetDiplomeTableAdapters.GetDiplomeTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiplomesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDiplomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDiplome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.BtnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Location = new System.Drawing.Point(84, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 100);
            this.panel1.TabIndex = 19;
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
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.combosecteur);
            this.groupBox1.Controls.Add(this.comboNiveau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 303);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diplome :";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtName.Location = new System.Drawing.Point(162, 89);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(249, 28);
            this.TxtName.TabIndex = 11;
            // 
            // combosecteur
            // 
            this.combosecteur.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.combosecteur.FormattingEnabled = true;
            this.combosecteur.Location = new System.Drawing.Point(162, 173);
            this.combosecteur.Name = "combosecteur";
            this.combosecteur.Size = new System.Drawing.Size(249, 29);
            this.combosecteur.TabIndex = 10;
            // 
            // comboNiveau
            // 
            this.comboNiveau.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboNiveau.FormattingEnabled = true;
            this.comboNiveau.Location = new System.Drawing.Point(162, 133);
            this.comboNiveau.Name = "comboNiveau";
            this.comboNiveau.Size = new System.Drawing.Size(249, 29);
            this.comboNiveau.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Secteur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "spécialité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Intitulé diplome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code Diplome :";
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcode.Location = new System.Drawing.Point(162, 43);
            this.txtcode.Name = "txtcode";
            this.txtcode.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(249, 28);
            this.txtcode.TabIndex = 8;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DiplomesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DiplomesDGV.ColumnHeadersHeight = 36;
            this.DiplomesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDiplomeDataGridViewTextBoxColumn,
            this.intituléDiplomeDataGridViewTextBoxColumn,
            this.intitulésectDataGridViewTextBoxColumn,
            this.intituéniveauDataGridViewTextBoxColumn});
            this.DiplomesDGV.DataSource = this.getDiplomeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiplomesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DiplomesDGV.EnableHeadersVisualStyles = false;
            this.DiplomesDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DiplomesDGV.Location = new System.Drawing.Point(527, 110);
            this.DiplomesDGV.Name = "DiplomesDGV";
            this.DiplomesDGV.ReadOnly = true;
            this.DiplomesDGV.RowHeadersVisible = false;
            this.DiplomesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiplomesDGV.Size = new System.Drawing.Size(646, 447);
            this.DiplomesDGV.TabIndex = 21;
            this.DiplomesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiplomesDGV_CellClick);
            // 
            // codeDiplomeDataGridViewTextBoxColumn
            // 
            this.codeDiplomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codeDiplomeDataGridViewTextBoxColumn.DataPropertyName = "Code_Diplome";
            this.codeDiplomeDataGridViewTextBoxColumn.HeaderText = "ID";
            this.codeDiplomeDataGridViewTextBoxColumn.Name = "codeDiplomeDataGridViewTextBoxColumn";
            this.codeDiplomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDiplomeDataGridViewTextBoxColumn.Width = 40;
            // 
            // intituléDiplomeDataGridViewTextBoxColumn
            // 
            this.intituléDiplomeDataGridViewTextBoxColumn.DataPropertyName = "IntituléDiplome";
            this.intituléDiplomeDataGridViewTextBoxColumn.HeaderText = "Diplome";
            this.intituléDiplomeDataGridViewTextBoxColumn.Name = "intituléDiplomeDataGridViewTextBoxColumn";
            this.intituléDiplomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intitulésectDataGridViewTextBoxColumn
            // 
            this.intitulésectDataGridViewTextBoxColumn.DataPropertyName = "intitulé_sect";
            this.intitulésectDataGridViewTextBoxColumn.HeaderText = "Secteur";
            this.intitulésectDataGridViewTextBoxColumn.Name = "intitulésectDataGridViewTextBoxColumn";
            this.intitulésectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intituéniveauDataGridViewTextBoxColumn
            // 
            this.intituéniveauDataGridViewTextBoxColumn.DataPropertyName = "intitué_niveau";
            this.intituéniveauDataGridViewTextBoxColumn.HeaderText = "Niveau";
            this.intituéniveauDataGridViewTextBoxColumn.Name = "intituéniveauDataGridViewTextBoxColumn";
            this.intituéniveauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getDiplomeBindingSource
            // 
            this.getDiplomeBindingSource.DataMember = "GetDiplome";
            this.getDiplomeBindingSource.DataSource = this.getDiplome;
            // 
            // getDiplome
            // 
            this.getDiplome.DataSetName = "GetDiplome";
            this.getDiplome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getDiplomeTableAdapter
            // 
            this.getDiplomeTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Diplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 606);
            this.Controls.Add(this.DiplomesDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1205, 606);
            this.Name = "Add_Diplome";
            this.Text = "Gestion des diplomes";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Add_Diplome_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiplomesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDiplomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDiplome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combosecteur;
        private System.Windows.Forms.ComboBox comboNiveau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.DataGridView DiplomesDGV;
        private GetDiplome getDiplome;
        private System.Windows.Forms.BindingSource getDiplomeBindingSource;
        private GetDiplomeTableAdapters.GetDiplomeTableAdapter getDiplomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDiplomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituléDiplomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitulésectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituéniveauDataGridViewTextBoxColumn;
    }
}