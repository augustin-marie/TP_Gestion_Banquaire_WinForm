
namespace GestionBancaire.WinForm
{
    partial class TransfertForm
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
            this.lbCompteSource = new System.Windows.Forms.Label();
            this.lbCompteSourceName = new System.Windows.Forms.Label();
            this.lbCompteDestination = new System.Windows.Forms.Label();
            this.lbMontant = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.selectCompteDestination = new System.Windows.Forms.DomainUpDown();
            this.inputMontant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCompteSource
            // 
            this.lbCompteSource.AutoSize = true;
            this.lbCompteSource.Location = new System.Drawing.Point(72, 86);
            this.lbCompteSource.Name = "lbCompteSource";
            this.lbCompteSource.Size = new System.Drawing.Size(117, 17);
            this.lbCompteSource.TabIndex = 0;
            this.lbCompteSource.Text = "Compte Source : ";
            // 
            // lbCompteSourceName
            // 
            this.lbCompteSourceName.AutoSize = true;
            this.lbCompteSourceName.Location = new System.Drawing.Point(192, 86);
            this.lbCompteSourceName.Name = "lbCompteSourceName";
            this.lbCompteSourceName.Size = new System.Drawing.Size(445, 17);
            this.lbCompteSourceName.TabIndex = 1;
            this.lbCompteSourceName.Text = "Compte typeCompte n°XXXXXX - libelleCompte - Solde : XXXXXXXX€";
            // 
            // lbCompteDestination
            // 
            this.lbCompteDestination.AutoSize = true;
            this.lbCompteDestination.Location = new System.Drawing.Point(48, 111);
            this.lbCompteDestination.Name = "lbCompteDestination";
            this.lbCompteDestination.Size = new System.Drawing.Size(141, 17);
            this.lbCompteDestination.TabIndex = 2;
            this.lbCompteDestination.Text = "Compte destination : ";
            // 
            // lbMontant
            // 
            this.lbMontant.AutoSize = true;
            this.lbMontant.Location = new System.Drawing.Point(40, 134);
            this.lbMontant.Name = "lbMontant";
            this.lbMontant.Size = new System.Drawing.Size(149, 17);
            this.lbMontant.TabIndex = 3;
            this.lbMontant.Text = "Montant à transférer : ";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(195, 179);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 4;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // selectCompteDestination
            // 
            this.selectCompteDestination.Location = new System.Drawing.Point(195, 109);
            this.selectCompteDestination.Name = "selectCompteDestination";
            this.selectCompteDestination.Size = new System.Drawing.Size(460, 22);
            this.selectCompteDestination.TabIndex = 7;
            this.selectCompteDestination.Text = "Liste des comptes";
            // 
            // inputMontant
            // 
            this.inputMontant.Location = new System.Drawing.Point(195, 132);
            this.inputMontant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputMontant.Name = "inputMontant";
            this.inputMontant.Size = new System.Drawing.Size(120, 22);
            this.inputMontant.TabIndex = 8;
            // 
            // TransfertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.inputMontant);
            this.Controls.Add(this.selectCompteDestination);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.lbMontant);
            this.Controls.Add(this.lbCompteDestination);
            this.Controls.Add(this.lbCompteSourceName);
            this.Controls.Add(this.lbCompteSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TransfertForm";
            this.Text = "Transferer";
            ((System.ComponentModel.ISupportInitialize)(this.inputMontant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCompteSource;
        private System.Windows.Forms.Label lbCompteSourceName;
        private System.Windows.Forms.Label lbCompteDestination;
        private System.Windows.Forms.Label lbMontant;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.DomainUpDown selectCompteDestination;
        private System.Windows.Forms.NumericUpDown inputMontant;
    }
}