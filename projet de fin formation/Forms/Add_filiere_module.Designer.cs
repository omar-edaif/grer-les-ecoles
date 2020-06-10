namespace projet_de_fin_formation.Forms
{
    partial class Add_filiere_module
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
            this.BtnOpenFiliere = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_Suprimer = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOpenModule = new System.Windows.Forms.Button();
            this.TxtMasseHoraire = new System.Windows.Forms.TextBox();
            this.TxtCofficient = new System.Windows.Forms.TextBox();
            this.comboModule = new System.Windows.Forms.ComboBox();
            this.comboFiliere = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomFilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitulémodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masseHoraireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getModuleFiliereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPP_EcoleDataSet3 = new projet_de_fin_formation.APP_EcoleDataSet3();
            this.getModuleFiliereTableAdapter = new projet_de_fin_formation.APP_EcoleDataSet3TableAdapters.GetModuleFiliereTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getModuleFiliereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPP_EcoleDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOpenFiliere
            // 
            this.BtnOpenFiliere.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenFiliere.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.BtnOpenFiliere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOpenFiliere.FlatAppearance.BorderSize = 0;
            this.BtnOpenFiliere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenFiliere.Location = new System.Drawing.Point(477, 123);
            this.BtnOpenFiliere.Name = "BtnOpenFiliere";
            this.BtnOpenFiliere.Size = new System.Drawing.Size(22, 25);
            this.BtnOpenFiliere.TabIndex = 46;
            this.BtnOpenFiliere.UseVisualStyleBackColor = false;
            this.BtnOpenFiliere.Click += new System.EventHandler(this.BtnOpenFiliere_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 21);
            this.label10.TabIndex = 40;
            this.label10.Text = "Masse horaire :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(123, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 41;
            this.label11.Text = "Filière :";
            // 
            // Btn_Suprimer
            // 
            this.Btn_Suprimer.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Suprimer.FlatAppearance.BorderSize = 0;
            this.Btn_Suprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Suprimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Suprimer.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Suprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Suprimer.Location = new System.Drawing.Point(367, 293);
            this.Btn_Suprimer.Name = "Btn_Suprimer";
            this.Btn_Suprimer.Size = new System.Drawing.Size(106, 35);
            this.Btn_Suprimer.TabIndex = 36;
            this.Btn_Suprimer.Text = "Supprimer";
            this.Btn_Suprimer.UseVisualStyleBackColor = false;
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Ajouter.FlatAppearance.BorderSize = 0;
            this.Btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ajouter.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajouter.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Ajouter.Location = new System.Drawing.Point(201, 293);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(106, 35);
            this.Btn_Ajouter.TabIndex = 38;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = false;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 35;
            this.label12.Text = "Module :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Coefficient :";
            // 
            // BtnOpenModule
            // 
            this.BtnOpenModule.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenModule.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.BtnOpenModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOpenModule.FlatAppearance.BorderSize = 0;
            this.BtnOpenModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenModule.Location = new System.Drawing.Point(477, 156);
            this.BtnOpenModule.Name = "BtnOpenModule";
            this.BtnOpenModule.Size = new System.Drawing.Size(22, 25);
            this.BtnOpenModule.TabIndex = 46;
            this.BtnOpenModule.UseVisualStyleBackColor = false;
            this.BtnOpenModule.Click += new System.EventHandler(this.BtnOpenModule_Click);
            // 
            // TxtMasseHoraire
            // 
            this.TxtMasseHoraire.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtMasseHoraire.Location = new System.Drawing.Point(201, 192);
            this.TxtMasseHoraire.Name = "TxtMasseHoraire";
            this.TxtMasseHoraire.Size = new System.Drawing.Size(272, 28);
            this.TxtMasseHoraire.TabIndex = 47;
            this.TxtMasseHoraire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMasseHoraire_KeyPress);
            // 
            // TxtCofficient
            // 
            this.TxtCofficient.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtCofficient.Location = new System.Drawing.Point(201, 226);
            this.TxtCofficient.Name = "TxtCofficient";
            this.TxtCofficient.Size = new System.Drawing.Size(272, 28);
            this.TxtCofficient.TabIndex = 47;
            // 
            // comboModule
            // 
            this.comboModule.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboModule.FormattingEnabled = true;
            this.comboModule.Location = new System.Drawing.Point(201, 156);
            this.comboModule.Name = "comboModule";
            this.comboModule.Size = new System.Drawing.Size(272, 29);
            this.comboModule.TabIndex = 49;
            this.comboModule.Enter += new System.EventHandler(this.comboModule_Enter);
            // 
            // comboFiliere
            // 
            this.comboFiliere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboFiliere.FormattingEnabled = true;
            this.comboFiliere.Location = new System.Drawing.Point(201, 120);
            this.comboFiliere.Name = "comboFiliere";
            this.comboFiliere.Size = new System.Drawing.Size(272, 29);
            this.comboFiliere.TabIndex = 48;
            this.comboFiliere.Enter += new System.EventHandler(this.comboFiliere_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomFilDataGridViewTextBoxColumn,
            this.intitulémodDataGridViewTextBoxColumn,
            this.masseHoraireDataGridViewTextBoxColumn,
            this.coefficientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getModuleFiliereBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(514, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(557, 363);
            this.dataGridView1.TabIndex = 50;
            // 
            // nomFilDataGridViewTextBoxColumn
            // 
            this.nomFilDataGridViewTextBoxColumn.DataPropertyName = "nom_Fil";
            this.nomFilDataGridViewTextBoxColumn.HeaderText = "Filiere";
            this.nomFilDataGridViewTextBoxColumn.Name = "nomFilDataGridViewTextBoxColumn";
            this.nomFilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intitulémodDataGridViewTextBoxColumn
            // 
            this.intitulémodDataGridViewTextBoxColumn.DataPropertyName = "Intitulé_mod";
            this.intitulémodDataGridViewTextBoxColumn.HeaderText = "Module";
            this.intitulémodDataGridViewTextBoxColumn.Name = "intitulémodDataGridViewTextBoxColumn";
            this.intitulémodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masseHoraireDataGridViewTextBoxColumn
            // 
            this.masseHoraireDataGridViewTextBoxColumn.DataPropertyName = "masseHoraire";
            this.masseHoraireDataGridViewTextBoxColumn.HeaderText = "masseHoraire";
            this.masseHoraireDataGridViewTextBoxColumn.Name = "masseHoraireDataGridViewTextBoxColumn";
            this.masseHoraireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coefficientDataGridViewTextBoxColumn
            // 
            this.coefficientDataGridViewTextBoxColumn.DataPropertyName = "Coefficient";
            this.coefficientDataGridViewTextBoxColumn.HeaderText = "Coefficient";
            this.coefficientDataGridViewTextBoxColumn.Name = "coefficientDataGridViewTextBoxColumn";
            this.coefficientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getModuleFiliereBindingSource
            // 
            this.getModuleFiliereBindingSource.DataMember = "GetModuleFiliere";
            this.getModuleFiliereBindingSource.DataSource = this.aPP_EcoleDataSet3;
            // 
            // aPP_EcoleDataSet3
            // 
            this.aPP_EcoleDataSet3.DataSetName = "APP_EcoleDataSet3";
            this.aPP_EcoleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getModuleFiliereTableAdapter
            // 
            this.getModuleFiliereTableAdapter.ClearBeforeFill = true;
            // 
            // Add_filiere_module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboModule);
            this.Controls.Add(this.comboFiliere);
            this.Controls.Add(this.TxtCofficient);
            this.Controls.Add(this.TxtMasseHoraire);
            this.Controls.Add(this.BtnOpenModule);
            this.Controls.Add(this.BtnOpenFiliere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_Suprimer);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.label12);
            this.Name = "Add_filiere_module";
            this.Text = "Gestion des module d\'un filiere";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Add_filiere_module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getModuleFiliereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPP_EcoleDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOpenFiliere;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Suprimer;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpenModule;
        private System.Windows.Forms.TextBox TxtMasseHoraire;
        private System.Windows.Forms.TextBox TxtCofficient;
        private System.Windows.Forms.ComboBox comboModule;
        private System.Windows.Forms.ComboBox comboFiliere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private APP_EcoleDataSet3 aPP_EcoleDataSet3;
        private System.Windows.Forms.BindingSource getModuleFiliereBindingSource;
        private APP_EcoleDataSet3TableAdapters.GetModuleFiliereTableAdapter getModuleFiliereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitulémodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masseHoraireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefficientDataGridViewTextBoxColumn;
    }
}