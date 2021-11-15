
namespace GestionBancaire.WinForm
{
    partial class CreationBanqueForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBanque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBanque
            // 
            this.inputBanque.Location = new System.Drawing.Point(317, 115);
            this.inputBanque.MaxLength = 100;
            this.inputBanque.Name = "inputBanque";
            this.inputBanque.Size = new System.Drawing.Size(227, 22);
            this.inputBanque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrez le nom de la banque : ";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(275, 220);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 30);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // CreationBanqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 350);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBanque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreationBanqueForm";
            this.Text = "Gestion bancaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBanque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
    }
}

