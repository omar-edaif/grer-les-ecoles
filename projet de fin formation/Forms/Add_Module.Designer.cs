namespace projet_de_fin_formation.Forms
{
    partial class Add_Module
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtModule = new System.Windows.Forms.TextBox();
            this.ModulesDGV = new System.Windows.Forms.DataGridView();
            this.gestionModule = new projet_de_fin_formation.GestionModule();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleTableAdapter = new projet_de_fin_formation.GestionModuleTableAdapters.ModuleTableAdapter();
            this.codemodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitulémodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSuprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Transparent;
            this.btnAjouter.Location = new System.Drawing.Point(65, 233);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(129, 35);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iintitué Niveau :";
            // 
            // TxtModule
            // 
            this.TxtModule.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtModule.Location = new System.Drawing.Point(186, 121);
            this.TxtModule.Name = "TxtModule";
            this.TxtModule.Size = new System.Drawing.Size(234, 28);
            this.TxtModule.TabIndex = 8;
            // 
            // ModulesDGV
            // 
            this.ModulesDGV.AllowUserToAddRows = false;
            this.ModulesDGV.AllowUserToDeleteRows = false;
            this.ModulesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModulesDGV.AutoGenerateColumns = false;
            this.ModulesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ModulesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ModulesDGV.BackgroundColor = System.Drawing.Color.White;
            this.ModulesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModulesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ModulesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ModulesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ModulesDGV.ColumnHeadersHeight = 36;
            this.ModulesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codemodDataGridViewTextBoxColumn,
            this.intitulémodDataGridViewTextBoxColumn});
            this.ModulesDGV.DataSource = this.moduleBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ModulesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ModulesDGV.EnableHeadersVisualStyles = false;
            this.ModulesDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ModulesDGV.Location = new System.Drawing.Point(484, 121);
            this.ModulesDGV.Name = "ModulesDGV";
            this.ModulesDGV.ReadOnly = true;
            this.ModulesDGV.RowHeadersVisible = false;
            this.ModulesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModulesDGV.Size = new System.Drawing.Size(242, 217);
            this.ModulesDGV.TabIndex = 22;
            // 
            // gestionModule
            // 
            this.gestionModule.DataSetName = "GestionModule";
            this.gestionModule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.gestionModule;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // codemodDataGridViewTextBoxColumn
            // 
            this.codemodDataGridViewTextBoxColumn.DataPropertyName = "code_mod";
            this.codemodDataGridViewTextBoxColumn.HeaderText = "code_mod";
            this.codemodDataGridViewTextBoxColumn.Name = "codemodDataGridViewTextBoxColumn";
            this.codemodDataGridViewTextBoxColumn.ReadOnly = true;
            this.codemodDataGridViewTextBoxColumn.Visible = false;
            // 
            // intitulémodDataGridViewTextBoxColumn
            // 
            this.intitulémodDataGridViewTextBoxColumn.DataPropertyName = "Intitulé_mod";
            this.intitulémodDataGridViewTextBoxColumn.HeaderText = "Module";
            this.intitulémodDataGridViewTextBoxColumn.Name = "intitulémodDataGridViewTextBoxColumn";
            this.intitulémodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BtnSuprimer
            // 
            this.BtnSuprimer.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSuprimer.FlatAppearance.BorderSize = 0;
            this.BtnSuprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuprimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuprimer.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSuprimer.Location = new System.Drawing.Point(309, 233);
            this.BtnSuprimer.Name = "BtnSuprimer";
            this.BtnSuprimer.Size = new System.Drawing.Size(129, 35);
            this.BtnSuprimer.TabIndex = 1;
            this.BtnSuprimer.Text = "Suprimer";
            this.BtnSuprimer.UseVisualStyleBackColor = false;
            this.BtnSuprimer.Click += new System.EventHandler(this.BtnSuprimer_Click);
            // 
            // Add_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 379);
            this.Controls.Add(this.ModulesDGV);
            this.Controls.Add(this.TxtModule);
            this.Controls.Add(this.BtnSuprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label4);
            this.Name = "Add_Module";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " ajouter Module";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Add_Module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModulesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtModule;
        private System.Windows.Forms.DataGridView ModulesDGV;
        private GestionModule gestionModule;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private GestionModuleTableAdapters.ModuleTableAdapter moduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitulémodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSuprimer;
    }
}