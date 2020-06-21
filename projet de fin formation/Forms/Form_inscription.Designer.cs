namespace projet_de_fin_formation.Forms
{
    partial class Form_inscription
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
            this.btnImage = new System.Windows.Forms.Button();
            this.imgStudent = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.ComboGroupes = new System.Windows.Forms.ComboBox();
            this.ComboFiliere = new System.Windows.Forms.ComboBox();
            this.ComboSecteur = new System.Windows.Forms.ComboBox();
            this.BtnInscrir = new System.Windows.Forms.Button();
            this.FormOpenFiliere = new System.Windows.Forms.Button();
            this.OpenFormGroupes = new System.Windows.Forms.Button();
            this.DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.OpenFormSecteur = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StagaireDGV = new System.Windows.Forms.DataGridView();
            this.codestagiaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codegroupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomGroupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.getStagaireBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getStagaire = new projet_de_fin_formation.GetStagaire();
            this.button5 = new System.Windows.Forms.Button();
            this.getStagaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getStagaireTableAdapter = new projet_de_fin_formation.GetStagaireTableAdapters.GetStagaireTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StagaireDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStagaireBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStagaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStagaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.LimeGreen;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(36, 253);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(130, 37);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Choisir";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // imgStudent
            // 
            this.imgStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgStudent.Image = global::projet_de_fin_formation.Properties.Resources._021_student_2;
            this.imgStudent.InitialImage = global::projet_de_fin_formation.Properties.Resources._021_student_2;
            this.imgStudent.Location = new System.Drawing.Point(15, 81);
            this.imgStudent.Name = "imgStudent";
            this.imgStudent.Size = new System.Drawing.Size(181, 166);
            this.imgStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStudent.TabIndex = 23;
            this.imgStudent.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.groupBox1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 98);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1253, 357);
            this.metroPanel2.TabIndex = 26;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboGenre);
            this.groupBox1.Controls.Add(this.ComboGroupes);
            this.groupBox1.Controls.Add(this.ComboFiliere);
            this.groupBox1.Controls.Add(this.ComboSecteur);
            this.groupBox1.Controls.Add(this.BtnInscrir);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.imgStudent);
            this.groupBox1.Controls.Add(this.FormOpenFiliere);
            this.groupBox1.Controls.Add(this.OpenFormGroupes);
            this.groupBox1.Controls.Add(this.DateNaissance);
            this.groupBox1.Controls.Add(this.OpenFormSecteur);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPrenom);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.TxtPhone);
            this.groupBox1.Controls.Add(this.TxtAdresse);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 354);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Info Stagaire :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboGenre
            // 
            this.comboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGenre.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.comboGenre.Location = new System.Drawing.Point(863, 185);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(273, 29);
            this.comboGenre.TabIndex = 10;
            // 
            // ComboGroupes
            // 
            this.ComboGroupes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboGroupes.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboGroupes.FormattingEnabled = true;
            this.ComboGroupes.Location = new System.Drawing.Point(863, 151);
            this.ComboGroupes.Name = "ComboGroupes";
            this.ComboGroupes.Size = new System.Drawing.Size(273, 29);
            this.ComboGroupes.TabIndex = 9;
            this.ComboGroupes.Enter += new System.EventHandler(this.ComboGroupes_Enter);
            // 
            // ComboFiliere
            // 
            this.ComboFiliere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboFiliere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboFiliere.FormattingEnabled = true;
            this.ComboFiliere.Location = new System.Drawing.Point(863, 116);
            this.ComboFiliere.Name = "ComboFiliere";
            this.ComboFiliere.Size = new System.Drawing.Size(273, 29);
            this.ComboFiliere.TabIndex = 8;
            this.ComboFiliere.Enter += new System.EventHandler(this.comboFiliere_Enter);
            // 
            // ComboSecteur
            // 
            this.ComboSecteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboSecteur.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComboSecteur.FormattingEnabled = true;
            this.ComboSecteur.Location = new System.Drawing.Point(863, 84);
            this.ComboSecteur.Name = "ComboSecteur";
            this.ComboSecteur.Size = new System.Drawing.Size(273, 29);
            this.ComboSecteur.TabIndex = 7;
            // 
            // BtnInscrir
            // 
            this.BtnInscrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInscrir.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnInscrir.FlatAppearance.BorderSize = 0;
            this.BtnInscrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInscrir.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInscrir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnInscrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInscrir.Location = new System.Drawing.Point(1135, 301);
            this.BtnInscrir.Name = "BtnInscrir";
            this.BtnInscrir.Size = new System.Drawing.Size(106, 35);
            this.BtnInscrir.TabIndex = 28;
            this.BtnInscrir.Text = "Inscrir";
            this.BtnInscrir.UseVisualStyleBackColor = false;
            this.BtnInscrir.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormOpenFiliere
            // 
            this.FormOpenFiliere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormOpenFiliere.BackColor = System.Drawing.Color.Transparent;
            this.FormOpenFiliere.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.FormOpenFiliere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FormOpenFiliere.FlatAppearance.BorderSize = 0;
            this.FormOpenFiliere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormOpenFiliere.Location = new System.Drawing.Point(1139, 121);
            this.FormOpenFiliere.Name = "FormOpenFiliere";
            this.FormOpenFiliere.Size = new System.Drawing.Size(20, 21);
            this.FormOpenFiliere.TabIndex = 34;
            this.FormOpenFiliere.UseVisualStyleBackColor = false;
            this.FormOpenFiliere.Click += new System.EventHandler(this.FormOpenFiliere_Click);
            // 
            // OpenFormGroupes
            // 
            this.OpenFormGroupes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFormGroupes.BackColor = System.Drawing.Color.Transparent;
            this.OpenFormGroupes.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.OpenFormGroupes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFormGroupes.FlatAppearance.BorderSize = 0;
            this.OpenFormGroupes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFormGroupes.Location = new System.Drawing.Point(1139, 154);
            this.OpenFormGroupes.Name = "OpenFormGroupes";
            this.OpenFormGroupes.Size = new System.Drawing.Size(20, 21);
            this.OpenFormGroupes.TabIndex = 34;
            this.OpenFormGroupes.UseVisualStyleBackColor = false;
            this.OpenFormGroupes.Click += new System.EventHandler(this.OpenFormGroupes_Click);
            // 
            // DateNaissance
            // 
            this.DateNaissance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateNaissance.CustomFormat = "dd-MM-yyyy";
            this.DateNaissance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNaissance.Location = new System.Drawing.Point(863, 216);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(273, 32);
            this.DateNaissance.TabIndex = 11;
            this.DateNaissance.Value = new System.DateTime(2020, 6, 11, 11, 11, 8, 0);
            // 
            // OpenFormSecteur
            // 
            this.OpenFormSecteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFormSecteur.BackColor = System.Drawing.Color.Transparent;
            this.OpenFormSecteur.BackgroundImage = global::projet_de_fin_formation.Properties.Resources.add_button_inside_black_circle__1_;
            this.OpenFormSecteur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFormSecteur.FlatAppearance.BorderSize = 0;
            this.OpenFormSecteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFormSecteur.Location = new System.Drawing.Point(1139, 87);
            this.OpenFormSecteur.Name = "OpenFormSecteur";
            this.OpenFormSecteur.Size = new System.Drawing.Size(20, 21);
            this.OpenFormSecteur.TabIndex = 34;
            this.OpenFormSecteur.UseVisualStyleBackColor = false;
            this.OpenFormSecteur.Click += new System.EventHandler(this.OpenFormSecteur_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(711, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date naissance :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(786, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Genre :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(776, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "groupe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telephone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresse :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(788, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "filière :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nom :";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtPrenom.Location = new System.Drawing.Point(342, 151);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(267, 28);
            this.TxtPrenom.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(774, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Secteur :";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtEmail.Location = new System.Drawing.Point(342, 250);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(267, 28);
            this.TxtEmail.TabIndex = 6;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtCode.Location = new System.Drawing.Point(341, 82);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(267, 28);
            this.txtCode.TabIndex = 1;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtPhone.Location = new System.Drawing.Point(342, 219);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(267, 28);
            this.TxtPhone.TabIndex = 5;
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtAdresse.Location = new System.Drawing.Point(342, 185);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(267, 28);
            this.TxtAdresse.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtName.Location = new System.Drawing.Point(341, 116);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(267, 28);
            this.TxtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code : ";
            // 
            // StagaireDGV
            // 
            this.StagaireDGV.AllowUserToAddRows = false;
            this.StagaireDGV.AllowUserToDeleteRows = false;
            this.StagaireDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StagaireDGV.AutoGenerateColumns = false;
            this.StagaireDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StagaireDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.StagaireDGV.BackgroundColor = System.Drawing.Color.White;
            this.StagaireDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StagaireDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.StagaireDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.StagaireDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StagaireDGV.ColumnHeadersHeight = 36;
            this.StagaireDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codestagiaireDataGridViewTextBoxColumn,
            this.codegroupeDataGridViewTextBoxColumn,
            this.nomstDataGridViewTextBoxColumn,
            this.prenomstDataGridViewTextBoxColumn,
            this.adressstDataGridViewTextBoxColumn,
            this.emailstDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.telstDataGridViewTextBoxColumn,
            this.dateNaissDataGridViewTextBoxColumn,
            this.nomGroupeDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.StagaireDGV.DataSource = this.getStagaireBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StagaireDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.StagaireDGV.EnableHeadersVisualStyles = false;
            this.StagaireDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.StagaireDGV.Location = new System.Drawing.Point(23, 481);
            this.StagaireDGV.Name = "StagaireDGV";
            this.StagaireDGV.ReadOnly = true;
            this.StagaireDGV.RowHeadersVisible = false;
            this.StagaireDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StagaireDGV.Size = new System.Drawing.Size(1253, 385);
            this.StagaireDGV.TabIndex = 27;
            this.StagaireDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StagaireDGV_CellClick);
            // 
            // codestagiaireDataGridViewTextBoxColumn
            // 
            this.codestagiaireDataGridViewTextBoxColumn.DataPropertyName = "code_stagiaire";
            this.codestagiaireDataGridViewTextBoxColumn.HeaderText = "code_stagiaire";
            this.codestagiaireDataGridViewTextBoxColumn.Name = "codestagiaireDataGridViewTextBoxColumn";
            this.codestagiaireDataGridViewTextBoxColumn.ReadOnly = true;
            this.codestagiaireDataGridViewTextBoxColumn.Visible = false;
            // 
            // codegroupeDataGridViewTextBoxColumn
            // 
            this.codegroupeDataGridViewTextBoxColumn.DataPropertyName = "Code_groupe";
            this.codegroupeDataGridViewTextBoxColumn.HeaderText = "Code_groupe";
            this.codegroupeDataGridViewTextBoxColumn.Name = "codegroupeDataGridViewTextBoxColumn";
            this.codegroupeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codegroupeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomstDataGridViewTextBoxColumn
            // 
            this.nomstDataGridViewTextBoxColumn.DataPropertyName = "nom_st";
            this.nomstDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomstDataGridViewTextBoxColumn.Name = "nomstDataGridViewTextBoxColumn";
            this.nomstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomstDataGridViewTextBoxColumn
            // 
            this.prenomstDataGridViewTextBoxColumn.DataPropertyName = "prenom_st";
            this.prenomstDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomstDataGridViewTextBoxColumn.Name = "prenomstDataGridViewTextBoxColumn";
            this.prenomstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressstDataGridViewTextBoxColumn
            // 
            this.adressstDataGridViewTextBoxColumn.DataPropertyName = "adress_st";
            this.adressstDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adressstDataGridViewTextBoxColumn.Name = "adressstDataGridViewTextBoxColumn";
            this.adressstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailstDataGridViewTextBoxColumn
            // 
            this.emailstDataGridViewTextBoxColumn.DataPropertyName = "email_st";
            this.emailstDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailstDataGridViewTextBoxColumn.Name = "emailstDataGridViewTextBoxColumn";
            this.emailstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telstDataGridViewTextBoxColumn
            // 
            this.telstDataGridViewTextBoxColumn.DataPropertyName = "tel_st";
            this.telstDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.telstDataGridViewTextBoxColumn.Name = "telstDataGridViewTextBoxColumn";
            this.telstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateNaissDataGridViewTextBoxColumn
            // 
            this.dateNaissDataGridViewTextBoxColumn.DataPropertyName = "DateNaiss";
            this.dateNaissDataGridViewTextBoxColumn.HeaderText = "Date naissance";
            this.dateNaissDataGridViewTextBoxColumn.Name = "dateNaissDataGridViewTextBoxColumn";
            this.dateNaissDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomGroupeDataGridViewTextBoxColumn
            // 
            this.nomGroupeDataGridViewTextBoxColumn.DataPropertyName = "Nom_Groupe";
            this.nomGroupeDataGridViewTextBoxColumn.HeaderText = "Groupe";
            this.nomGroupeDataGridViewTextBoxColumn.Name = "nomGroupeDataGridViewTextBoxColumn";
            this.nomGroupeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            this.photoDataGridViewImageColumn.Visible = false;
            // 
            // getStagaireBindingSource1
            // 
            this.getStagaireBindingSource1.DataMember = "GetStagaire";
            this.getStagaireBindingSource1.DataSource = this.getStagaire;
            // 
            // getStagaire
            // 
            this.getStagaire.DataSetName = "GetStagaire";
            this.getStagaire.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1161, 872);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 35);
            this.button5.TabIndex = 29;
            this.button5.Text = "Supprimer";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // getStagaireBindingSource
            // 
            this.getStagaireBindingSource.DataSource = this.getStagaire;
            this.getStagaireBindingSource.Position = 0;
            // 
            // getStagaireTableAdapter
            // 
            this.getStagaireTableAdapter.ClearBeforeFill = true;
            // 
            // Form_inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 920);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.StagaireDGV);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Form_inscription";
            this.Text = "L\'inscription";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form_inscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StagaireDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStagaireBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStagaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStagaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox imgStudent;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DateNaissance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnInscrir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button OpenFormSecteur;
        private System.Windows.Forms.Button FormOpenFiliere;
        private System.Windows.Forms.Button OpenFormGroupes;
        private System.Windows.Forms.DataGridView StagaireDGV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codegrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitulésectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.ComboBox ComboGroupes;
        private System.Windows.Forms.ComboBox ComboFiliere;
        private System.Windows.Forms.ComboBox ComboSecteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.BindingSource getStagaireBindingSource;
        private GetStagaire getStagaire;
        private System.Windows.Forms.BindingSource getStagaireBindingSource1;
        private GetStagaireTableAdapters.GetStagaireTableAdapter getStagaireTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestagiaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codegroupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomGroupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
    }
}