namespace projet_de_fin_formation.Forms
{
    partial class Form_Exam
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ComboModule = new System.Windows.Forms.ComboBox();
            this.ComboGroupe = new System.Windows.Forms.ComboBox();
            this.ComboFiliere = new System.Windows.Forms.ComboBox();
            this.ComboSecteur = new System.Windows.Forms.ComboBox();
            this.Sauvgard = new System.Windows.Forms.Button();
            this.OpenFormModule = new System.Windows.Forms.Button();
            this.OpenFormFiliere = new System.Windows.Forms.Button();
            this.OpenFormGroupe = new System.Windows.Forms.Button();
            this.OpenFormSecteur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ExamDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitulémodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getExamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getExams = new projet_de_fin_formation.GetExams();
            this.getExamsTableAdapter = new projet_de_fin_formation.GetExamsTableAdapters.GetExamsTableAdapter();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroPanel1.Controls.Add(this.ComboModule);
            this.metroPanel1.Controls.Add(this.ComboGroupe);
            this.metroPanel1.Controls.Add(this.ComboFiliere);
            this.metroPanel1.Controls.Add(this.ComboSecteur);
            this.metroPanel1.Controls.Add(this.Sauvgard);
            this.metroPanel1.Controls.Add(this.OpenFormModule);
            this.metroPanel1.Controls.Add(this.OpenFormFiliere);
            this.metroPanel1.Controls.Add(this.OpenFormGroupe);
            this.metroPanel1.Controls.Add(this.OpenFormSecteur);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label11);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.label12);
            this.metroPanel1.Controls.Add(this.ExamDGV);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1224, 648);
            this.metroPanel1.TabIndex = 54;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ComboModule
            // 
            this.ComboModule.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboModule.FormattingEnabled = true;
            this.ComboModule.Location = new System.Drawing.Point(808, 88);
            this.ComboModule.Name = "ComboModule";
            this.ComboModule.Size = new System.Drawing.Size(270, 29);
            this.ComboModule.TabIndex = 69;
            this.ComboModule.SelectedIndexChanged += new System.EventHandler(this.ComboModule_SelectedIndexChanged);
            // 
            // ComboGroupe
            // 
            this.ComboGroupe.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboGroupe.FormattingEnabled = true;
            this.ComboGroupe.Location = new System.Drawing.Point(204, 88);
            this.ComboGroupe.Name = "ComboGroupe";
            this.ComboGroupe.Size = new System.Drawing.Size(270, 29);
            this.ComboGroupe.TabIndex = 69;
            this.ComboGroupe.SelectedIndexChanged += new System.EventHandler(this.ComboGroupe_SelectedIndexChanged);
            this.ComboGroupe.Enter += new System.EventHandler(this.ComboGroupe_Enter);
            // 
            // ComboFiliere
            // 
            this.ComboFiliere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboFiliere.FormattingEnabled = true;
            this.ComboFiliere.Location = new System.Drawing.Point(808, 52);
            this.ComboFiliere.Name = "ComboFiliere";
            this.ComboFiliere.Size = new System.Drawing.Size(270, 29);
            this.ComboFiliere.TabIndex = 69;
            this.ComboFiliere.Enter += new System.EventHandler(this.ComboFiliere_Enter);
            // 
            // ComboSecteur
            // 
            this.ComboSecteur.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboSecteur.FormattingEnabled = true;
            this.ComboSecteur.Location = new System.Drawing.Point(204, 49);
            this.ComboSecteur.Name = "ComboSecteur";
            this.ComboSecteur.Size = new System.Drawing.Size(270, 29);
            this.ComboSecteur.TabIndex = 69;
            // 
            // Sauvgard
            // 
            this.Sauvgard.BackColor = System.Drawing.Color.LimeGreen;
            this.Sauvgard.FlatAppearance.BorderSize = 0;
            this.Sauvgard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sauvgard.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sauvgard.ForeColor = System.Drawing.Color.Transparent;
            this.Sauvgard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sauvgard.Location = new System.Drawing.Point(1115, 610);
            this.Sauvgard.Name = "Sauvgard";
            this.Sauvgard.Size = new System.Drawing.Size(106, 35);
            this.Sauvgard.TabIndex = 67;
            this.Sauvgard.Text = "Sauvgarder";
            this.Sauvgard.UseVisualStyleBackColor = false;
            this.Sauvgard.Click += new System.EventHandler(this.Sauvgard_Click);
            // 
            // OpenFormModule
            // 
            this.OpenFormModule.BackColor = System.Drawing.Color.Transparent;
            this.OpenFormModule.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.OpenFormModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFormModule.FlatAppearance.BorderSize = 0;
            this.OpenFormModule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OpenFormModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OpenFormModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFormModule.Location = new System.Drawing.Point(1084, 91);
            this.OpenFormModule.Name = "OpenFormModule";
            this.OpenFormModule.Size = new System.Drawing.Size(22, 25);
            this.OpenFormModule.TabIndex = 65;
            this.OpenFormModule.UseVisualStyleBackColor = false;
            this.OpenFormModule.Click += new System.EventHandler(this.OpenFormModule_Click);
            // 
            // OpenFormFiliere
            // 
            this.OpenFormFiliere.BackColor = System.Drawing.Color.Transparent;
            this.OpenFormFiliere.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.OpenFormFiliere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFormFiliere.FlatAppearance.BorderSize = 0;
            this.OpenFormFiliere.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OpenFormFiliere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OpenFormFiliere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFormFiliere.Location = new System.Drawing.Point(1084, 55);
            this.OpenFormFiliere.Name = "OpenFormFiliere";
            this.OpenFormFiliere.Size = new System.Drawing.Size(22, 25);
            this.OpenFormFiliere.TabIndex = 65;
            this.OpenFormFiliere.UseVisualStyleBackColor = false;
            this.OpenFormFiliere.Click += new System.EventHandler(this.OpenFormFiliere_Click);
            // 
            // OpenFormGroupe
            // 
            this.OpenFormGroupe.BackColor = System.Drawing.Color.Transparent;
            this.OpenFormGroupe.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.OpenFormGroupe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFormGroupe.FlatAppearance.BorderSize = 0;
            this.OpenFormGroupe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OpenFormGroupe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OpenFormGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFormGroupe.Location = new System.Drawing.Point(480, 91);
            this.OpenFormGroupe.Name = "OpenFormGroupe";
            this.OpenFormGroupe.Size = new System.Drawing.Size(22, 25);
            this.OpenFormGroupe.TabIndex = 65;
            this.OpenFormGroupe.UseVisualStyleBackColor = false;
            this.OpenFormGroupe.Click += new System.EventHandler(this.OpenFormGroupe_Click);
            // 
            // OpenFormSecteur
            // 
            this.OpenFormSecteur.BackColor = System.Drawing.Color.Transparent;
            this.OpenFormSecteur.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.OpenFormSecteur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFormSecteur.FlatAppearance.BorderSize = 0;
            this.OpenFormSecteur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OpenFormSecteur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OpenFormSecteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFormSecteur.Location = new System.Drawing.Point(480, 51);
            this.OpenFormSecteur.Name = "OpenFormSecteur";
            this.OpenFormSecteur.Size = new System.Drawing.Size(22, 27);
            this.OpenFormSecteur.TabIndex = 65;
            this.OpenFormSecteur.UseVisualStyleBackColor = false;
            this.OpenFormSecteur.Click += new System.EventHandler(this.OpenFormSecteur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Secteur :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(733, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 59;
            this.label11.Text = "Filière :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "groupe :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(719, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 55;
            this.label12.Text = "Module :";
            // 
            // ExamDGV
            // 
            this.ExamDGV.AllowUserToAddRows = false;
            this.ExamDGV.AllowUserToDeleteRows = false;
            this.ExamDGV.AutoGenerateColumns = false;
            this.ExamDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExamDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ExamDGV.BackgroundColor = System.Drawing.Color.White;
            this.ExamDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExamDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ExamDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExamDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExamDGV.ColumnHeadersHeight = 36;
            this.ExamDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.intitulémodDataGridViewTextBoxColumn,
            this.Note});
            this.ExamDGV.DataSource = this.getExamsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExamDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExamDGV.EnableHeadersVisualStyles = false;
            this.ExamDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExamDGV.Location = new System.Drawing.Point(121, 132);
            this.ExamDGV.Name = "ExamDGV";
            this.ExamDGV.RowHeadersVisible = false;
            this.ExamDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExamDGV.Size = new System.Drawing.Size(985, 495);
            this.ExamDGV.TabIndex = 68;
            this.ExamDGV.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ExamDGV_CellValidating_1);
            this.ExamDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ExamDGV_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "code_stagiaire";
            this.dataGridViewTextBoxColumn1.HeaderText = "code_stagiaire";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom_st";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prenom_st";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // intitulémodDataGridViewTextBoxColumn
            // 
            this.intitulémodDataGridViewTextBoxColumn.DataPropertyName = "Intitulé_mod";
            this.intitulémodDataGridViewTextBoxColumn.HeaderText = "Module";
            this.intitulémodDataGridViewTextBoxColumn.Name = "intitulémodDataGridViewTextBoxColumn";
            this.intitulémodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // getExamsBindingSource
            // 
            this.getExamsBindingSource.DataMember = "GetExams";
            this.getExamsBindingSource.DataSource = this.getExams;
            // 
            // getExams
            // 
            this.getExams.DataSetName = "GetExams";
            this.getExams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getExamsTableAdapter
            // 
            this.getExamsTableAdapter.ClearBeforeFill = true;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // Form_Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 713);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form_Exam";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Gestion des exams";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form_Exam_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Sauvgard;
        private System.Windows.Forms.Button OpenFormSecteur;
        private System.Windows.Forms.Button OpenFormModule;
        private System.Windows.Forms.Button OpenFormFiliere;
        private System.Windows.Forms.Button OpenFormGroupe;
        private System.Windows.Forms.DataGridView ExamDGV;
        private System.Windows.Forms.ComboBox ComboModule;
        private System.Windows.Forms.ComboBox ComboGroupe;
        private System.Windows.Forms.ComboBox ComboFiliere;
        private System.Windows.Forms.ComboBox ComboSecteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestagiaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomstDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getExamsBindingSource;
        private GetExams getExams;
        private GetExamsTableAdapters.GetExamsTableAdapter getExamsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitulémodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.ErrorProvider ep;
    }
}