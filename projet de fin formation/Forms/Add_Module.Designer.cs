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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtModule = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Transparent;
            this.btnAjouter.Location = new System.Drawing.Point(466, 101);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 29);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iintitué Niveau :";
            // 
            // TxtModule
            // 
            this.TxtModule.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtModule.Location = new System.Drawing.Point(192, 101);
            this.TxtModule.Name = "TxtModule";
            this.TxtModule.Size = new System.Drawing.Size(234, 28);
            this.TxtModule.TabIndex = 8;
            // 
            // Add_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 158);
            this.Controls.Add(this.TxtModule);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(595, 158);
            this.Name = "Add_Module";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " ajouter Module";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtModule;
    }
}