namespace projet_de_fin_formation.Forms
{
    partial class Form_Enseignant
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
            this.metroComboBox7 = new MetroFramework.Controls.MetroComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.ComboGroupes = new System.Windows.Forms.ComboBox();
            this.ComboFiliere = new System.Windows.Forms.ComboBox();
            this.ComboSecteur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox7
            // 
            this.metroComboBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboBox7.FormattingEnabled = true;
            this.metroComboBox7.ItemHeight = 23;
            this.metroComboBox7.Location = new System.Drawing.Point(732, -31);
            this.metroComboBox7.Name = "metroComboBox7";
            this.metroComboBox7.Size = new System.Drawing.Size(273, 29);
            this.metroComboBox7.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1112, 876);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 35);
            this.button4.TabIndex = 28;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(1092, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 35);
            this.button5.TabIndex = 29;
            this.button5.Text = "Modifier";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(968, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 35);
            this.button6.TabIndex = 30;
            this.button6.Text = "Ajouter";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel2.Controls.Add(this.label3);
            this.metroPanel2.Controls.Add(this.label6);
            this.metroPanel2.Controls.Add(this.label5);
            this.metroPanel2.Controls.Add(this.label4);
            this.metroPanel2.Controls.Add(this.TxtPrenom);
            this.metroPanel2.Controls.Add(this.TxtEmail);
            this.metroPanel2.Controls.Add(this.txtCode);
            this.metroPanel2.Controls.Add(this.TxtPhone);
            this.metroPanel2.Controls.Add(this.TxtAdresse);
            this.metroPanel2.Controls.Add(this.TxtName);
            this.metroPanel2.Controls.Add(this.label9);
            this.metroPanel2.Controls.Add(this.label13);
            this.metroPanel2.Controls.Add(this.comboGenre);
            this.metroPanel2.Controls.Add(this.ComboGroupes);
            this.metroPanel2.Controls.Add(this.ComboFiliere);
            this.metroPanel2.Controls.Add(this.ComboSecteur);
            this.metroPanel2.Controls.Add(this.label7);
            this.metroPanel2.Controls.Add(this.label10);
            this.metroPanel2.Controls.Add(this.label11);
            this.metroPanel2.Controls.Add(this.label12);
            this.metroPanel2.Controls.Add(this.DateNaissance);
            this.metroPanel2.Controls.Add(this.label8);
            this.metroPanel2.Controls.Add(this.button5);
            this.metroPanel2.Controls.Add(this.button6);
            this.metroPanel2.Controls.Add(this.metroComboBox7);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(5, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1230, 321);
            this.metroPanel2.TabIndex = 28;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // DateNaissance
            // 
            this.DateNaissance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateNaissance.CustomFormat = "dd-MM-yyyy";
            this.DateNaissance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNaissance.Location = new System.Drawing.Point(925, 216);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(273, 32);
            this.DateNaissance.TabIndex = 43;
            this.DateNaissance.Value = new System.DateTime(2020, 6, 11, 11, 11, 8, 0);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(773, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "Date naissance :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 463);
            this.dataGridView1.TabIndex = 30;
            // 
            // comboGenre
            // 
            this.comboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGenre.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.comboGenre.Location = new System.Drawing.Point(916, 130);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(273, 29);
            this.comboGenre.TabIndex = 50;
            // 
            // ComboGroupes
            // 
            this.ComboGroupes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboGroupes.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboGroupes.FormattingEnabled = true;
            this.ComboGroupes.Location = new System.Drawing.Point(916, 96);
            this.ComboGroupes.Name = "ComboGroupes";
            this.ComboGroupes.Size = new System.Drawing.Size(273, 29);
            this.ComboGroupes.TabIndex = 49;
            // 
            // ComboFiliere
            // 
            this.ComboFiliere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboFiliere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboFiliere.FormattingEnabled = true;
            this.ComboFiliere.Location = new System.Drawing.Point(925, 62);
            this.ComboFiliere.Name = "ComboFiliere";
            this.ComboFiliere.Size = new System.Drawing.Size(273, 29);
            this.ComboFiliere.TabIndex = 48;
            // 
            // ComboSecteur
            // 
            this.ComboSecteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboSecteur.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboSecteur.FormattingEnabled = true;
            this.ComboSecteur.Location = new System.Drawing.Point(925, 26);
            this.ComboSecteur.Name = "ComboSecteur";
            this.ComboSecteur.Size = new System.Drawing.Size(273, 29);
            this.ComboSecteur.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(839, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "Genre :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(829, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 52;
            this.label10.Text = "groupe :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(838, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 53;
            this.label11.Text = "filière :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(838, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 47;
            this.label12.Text = "Secteur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Telephone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nom :";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtPrenom.Location = new System.Drawing.Point(175, 95);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(267, 28);
            this.TxtPrenom.TabIndex = 56;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtEmail.Location = new System.Drawing.Point(175, 194);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(267, 28);
            this.TxtEmail.TabIndex = 59;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtCode.Location = new System.Drawing.Point(174, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(267, 28);
            this.txtCode.TabIndex = 54;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtPhone.Location = new System.Drawing.Point(175, 163);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(267, 28);
            this.TxtPhone.TabIndex = 58;
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtAdresse.Location = new System.Drawing.Point(175, 129);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(267, 28);
            this.TxtAdresse.TabIndex = 57;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtName.Location = new System.Drawing.Point(174, 60);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(267, 28);
            this.TxtName.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 64;
            this.label9.Text = "Prénom :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(107, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 65;
            this.label13.Text = "Code : ";
            // 
            // Form_Enseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 920);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.button4);
            this.Name = "Form_Enseignant";
            this.Text = "Gestion des enseignents ";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.toolTip1.SetToolTip(this, "zeeeeeeeeee");
            this.Load += new System.EventHandler(this.Form_Enseignant_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DateNaissance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.ComboBox ComboGroupes;
        private System.Windows.Forms.ComboBox ComboFiliere;
        private System.Windows.Forms.ComboBox ComboSecteur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
    }
}