namespace projet_de_fin_formation.Forms
{
    partial class Add_secteur
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.TxtCodeSecteur = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codesectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitulésectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCréationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPP_EcoleDataSet1 = new projet_de_fin_formation.APP_EcoleDataSet1();
            this.secteurTableAdapter = new projet_de_fin_formation.APP_EcoleDataSet1TableAdapters.SecteurTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPP_EcoleDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.BtnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Location = new System.Drawing.Point(35, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 113);
            this.panel1.TabIndex = 14;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(276, 39);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 29);
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
            this.BtnModifier.Location = new System.Drawing.Point(149, 39);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(106, 29);
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
            this.btnAjouter.Location = new System.Drawing.Point(22, 39);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 29);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.TxtCodeSecteur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 192);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secteur :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(160, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 28);
            this.txtName.TabIndex = 11;
            // 
            // TxtCodeSecteur
            // 
            this.TxtCodeSecteur.Enabled = false;
            this.TxtCodeSecteur.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtCodeSecteur.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtCodeSecteur.Location = new System.Drawing.Point(160, 57);
            this.TxtCodeSecteur.Multiline = true;
            this.TxtCodeSecteur.Name = "TxtCodeSecteur";
            this.TxtCodeSecteur.ReadOnly = true;
            this.TxtCodeSecteur.Size = new System.Drawing.Size(238, 28);
            this.TxtCodeSecteur.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intitué Secteur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code Secteur:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codesectDataGridViewTextBoxColumn,
            this.intitulésectDataGridViewTextBoxColumn,
            this.dateCréationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.secteurBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(531, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(492, 311);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codesectDataGridViewTextBoxColumn
            // 
            this.codesectDataGridViewTextBoxColumn.DataPropertyName = "code_sect";
            this.codesectDataGridViewTextBoxColumn.HeaderText = "code secteur";
            this.codesectDataGridViewTextBoxColumn.Name = "codesectDataGridViewTextBoxColumn";
            this.codesectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intitulésectDataGridViewTextBoxColumn
            // 
            this.intitulésectDataGridViewTextBoxColumn.DataPropertyName = "intitulé_sect";
            this.intitulésectDataGridViewTextBoxColumn.HeaderText = "intitulé secteur";
            this.intitulésectDataGridViewTextBoxColumn.Name = "intitulésectDataGridViewTextBoxColumn";
            this.intitulésectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCréationDataGridViewTextBoxColumn
            // 
            this.dateCréationDataGridViewTextBoxColumn.DataPropertyName = "date_Création";
            this.dateCréationDataGridViewTextBoxColumn.HeaderText = "date Création";
            this.dateCréationDataGridViewTextBoxColumn.Name = "dateCréationDataGridViewTextBoxColumn";
            this.dateCréationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secteurBindingSource
            // 
            this.secteurBindingSource.DataMember = "Secteur";
            this.secteurBindingSource.DataSource = this.aPP_EcoleDataSet1;
            // 
            // aPP_EcoleDataSet1
            // 
            this.aPP_EcoleDataSet1.DataSetName = "APP_EcoleDataSet1";
            this.aPP_EcoleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // secteurTableAdapter
            // 
            this.secteurTableAdapter.ClearBeforeFill = true;
            // 
            // Add_secteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1061, 576);
            this.Name = "Add_secteur";
            this.Text = "Gestion de secteur ";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Add_secteur_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPP_EcoleDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private MetroFramework.Controls.MetroTextBox TxtCodeSecteur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private APP_EcoleDataSet1 aPP_EcoleDataSet1;
        private System.Windows.Forms.BindingSource secteurBindingSource;
        private APP_EcoleDataSet1TableAdapters.SecteurTableAdapter secteurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codesectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitulésectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCréationDataGridViewTextBoxColumn;
    }
}