
namespace crous.views
{
    partial class FMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAppartements = new System.Windows.Forms.Button();
            this.btnEtudiants = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(230, 217);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnAppartements
            // 
            this.btnAppartements.Location = new System.Drawing.Point(81, 37);
            this.btnAppartements.Name = "btnAppartements";
            this.btnAppartements.Size = new System.Drawing.Size(145, 51);
            this.btnAppartements.TabIndex = 2;
            this.btnAppartements.Text = "Appartements";
            this.btnAppartements.UseVisualStyleBackColor = true;
            // 
            // btnEtudiants
            // 
            this.btnEtudiants.Location = new System.Drawing.Point(81, 129);
            this.btnEtudiants.Name = "btnEtudiants";
            this.btnEtudiants.Size = new System.Drawing.Size(145, 51);
            this.btnEtudiants.TabIndex = 3;
            this.btnEtudiants.Text = "Etudiants";
            this.btnEtudiants.UseVisualStyleBackColor = true;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(138, 215);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(86, 23);
            this.btnDeconnexion.TabIndex = 4;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 252);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnEtudiants);
            this.Controls.Add(this.btnAppartements);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAppartements;
        private System.Windows.Forms.Button btnEtudiants;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}