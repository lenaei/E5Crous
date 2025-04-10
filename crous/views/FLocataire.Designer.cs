namespace crous.views
{
    partial class FLocataire
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEtudiant;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.Button btnOuvrirAppartement;  // Bouton ajouté

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblEtudiant = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.btnOuvrirAppartement = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEtudiant
            // 
            this.lblEtudiant.AutoSize = true;
            this.lblEtudiant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEtudiant.Location = new System.Drawing.Point(30, 20);
            this.lblEtudiant.Name = "lblEtudiant";
            this.lblEtudiant.Size = new System.Drawing.Size(118, 19);
            this.lblEtudiant.TabIndex = 0;
            this.lblEtudiant.Text = "Étudiant : [Nom]";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLibelle.Location = new System.Drawing.Point(30, 50);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(40, 15);
            this.lblLibelle.TabIndex = 1;
            this.lblLibelle.Text = "Type : ";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(30, 80);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(54, 15);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Location = new System.Drawing.Point(30, 110);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(65, 15);
            this.lblSuperficie.TabIndex = 3;
            this.lblSuperficie.Text = "Superficie :";
            // 
            // btnOuvrirAppartement
            // 
            this.btnOuvrirAppartement.Location = new System.Drawing.Point(30, 140);
            this.btnOuvrirAppartement.Name = "btnOuvrirAppartement";
            this.btnOuvrirAppartement.Size = new System.Drawing.Size(160, 23);
            this.btnOuvrirAppartement.TabIndex = 4;
            this.btnOuvrirAppartement.Text = "Modifier Appartement";
            this.btnOuvrirAppartement.UseVisualStyleBackColor = true;
            this.btnOuvrirAppartement.Click += new System.EventHandler(this.btnOuvrirAppartement_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(313, 140);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // FLocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnOuvrirAppartement);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblEtudiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FLocataire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locataire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnOk;
    }
}
