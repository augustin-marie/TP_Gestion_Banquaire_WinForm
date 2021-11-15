
namespace GestionBancaire.WinForm
{
    partial class ModifierCompteForm
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
            this.lbDetailCompte = new System.Windows.Forms.Label();
            this.lbLibelle = new System.Windows.Forms.Label();
            this.lbTxInteret = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.inputLibelleCompte = new System.Windows.Forms.TextBox();
            this.lbFraisDeTransfert = new System.Windows.Forms.Label();
            this.inputTxInteret = new System.Windows.Forms.TextBox();
            this.inputFraiTransfert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDetailCompte
            // 
            this.lbDetailCompte.AutoSize = true;
            this.lbDetailCompte.Location = new System.Drawing.Point(167, 89);
            this.lbDetailCompte.Name = "lbDetailCompte";
            this.lbDetailCompte.Size = new System.Drawing.Size(445, 17);
            this.lbDetailCompte.TabIndex = 0;
            this.lbDetailCompte.Text = "Compte typeCompte n°XXXXXX - libelleCompte - Solde : XXXXXXXX€";
            // 
            // lbLibelle
            // 
            this.lbLibelle.AutoSize = true;
            this.lbLibelle.Location = new System.Drawing.Point(33, 126);
            this.lbLibelle.Name = "lbLibelle";
            this.lbLibelle.Size = new System.Drawing.Size(131, 17);
            this.lbLibelle.TabIndex = 1;
            this.lbLibelle.Text = "Libelle du compte : ";
            // 
            // lbTxInteret
            // 
            this.lbTxInteret.AutoSize = true;
            this.lbTxInteret.Location = new System.Drawing.Point(58, 154);
            this.lbTxInteret.Name = "lbTxInteret";
            this.lbTxInteret.Size = new System.Drawing.Size(106, 17);
            this.lbTxInteret.TabIndex = 2;
            this.lbTxInteret.Text = "Taux d\'intérêt : ";
            this.lbTxInteret.Visible = false;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(170, 193);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // inputLibelleCompte
            // 
            this.inputLibelleCompte.Location = new System.Drawing.Point(170, 123);
            this.inputLibelleCompte.MaxLength = 100;
            this.inputLibelleCompte.Name = "inputLibelleCompte";
            this.inputLibelleCompte.Size = new System.Drawing.Size(460, 22);
            this.inputLibelleCompte.TabIndex = 4;
            // 
            // lbFraisDeTransfert
            // 
            this.lbFraisDeTransfert.AutoSize = true;
            this.lbFraisDeTransfert.Location = new System.Drawing.Point(43, 156);
            this.lbFraisDeTransfert.Name = "lbFraisDeTransfert";
            this.lbFraisDeTransfert.Size = new System.Drawing.Size(121, 17);
            this.lbFraisDeTransfert.TabIndex = 6;
            this.lbFraisDeTransfert.Text = "Frai de transfert : ";
            this.lbFraisDeTransfert.Visible = false;
            // 
            // inputTxInteret
            // 
            this.inputTxInteret.Location = new System.Drawing.Point(170, 151);
            this.inputTxInteret.MaxLength = 10;
            this.inputTxInteret.Name = "inputTxInteret";
            this.inputTxInteret.Size = new System.Drawing.Size(100, 22);
            this.inputTxInteret.TabIndex = 14;
            this.inputTxInteret.Visible = false;
            // 
            // inputFraiTransfert
            // 
            this.inputFraiTransfert.Location = new System.Drawing.Point(170, 151);
            this.inputFraiTransfert.MaxLength = 5;
            this.inputFraiTransfert.Name = "inputFraiTransfert";
            this.inputFraiTransfert.Size = new System.Drawing.Size(100, 22);
            this.inputFraiTransfert.TabIndex = 15;
            this.inputFraiTransfert.Visible = false;
            // 
            // ModifierCompteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.inputFraiTransfert);
            this.Controls.Add(this.inputTxInteret);
            this.Controls.Add(this.lbFraisDeTransfert);
            this.Controls.Add(this.inputLibelleCompte);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.lbTxInteret);
            this.Controls.Add(this.lbLibelle);
            this.Controls.Add(this.lbDetailCompte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierCompteForm";
            this.Text = "Modifier le compte n°XXXXXX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDetailCompte;
        private System.Windows.Forms.Label lbLibelle;
        private System.Windows.Forms.Label lbTxInteret;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox inputLibelleCompte;
        private System.Windows.Forms.Label lbFraisDeTransfert;
        private System.Windows.Forms.TextBox inputTxInteret;
        private System.Windows.Forms.TextBox inputFraiTransfert;
    }
}