namespace crous.views
{
    partial class FModifierAppartement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbSuperficie = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(150, 30);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(250, 23);
            this.tbLibelle.TabIndex = 6;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(150, 70);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(250, 23);
            this.tbDescription.TabIndex = 7;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(150, 110);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(250, 23);
            this.tbAdresse.TabIndex = 8;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(150, 150);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(250, 23);
            this.tbCodePostal.TabIndex = 9;
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(150, 190);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(250, 23);
            this.tbVille.TabIndex = 10;
            // 
            // tbSuperficie
            // 
            this.tbSuperficie.Location = new System.Drawing.Point(150, 230);
            this.tbSuperficie.Name = "tbSuperficie";
            this.tbSuperficie.Size = new System.Drawing.Size(250, 23);
            this.tbSuperficie.TabIndex = 11;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(150, 280);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(325, 280);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code Postal :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ville :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Superficie (m²) :";
            // 
            // FModifierAppartement
            // 
            this.ClientSize = new System.Drawing.Size(450, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbSuperficie);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FModifierAppartement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier un appartement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbSuperficie;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6;
    }
}
