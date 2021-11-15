
namespace GestionBancaire.WinForm
{
    partial class OuvrirCompteForm
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
            this.lbClient = new System.Windows.Forms.Label();
            this.inputLibelle = new System.Windows.Forms.TextBox();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.inputSolde = new System.Windows.Forms.TextBox();
            this.lbSolde = new System.Windows.Forms.Label();
            this.inputFraiTransfert = new System.Windows.Forms.TextBox();
            this.lbFraiTransfert = new System.Windows.Forms.Label();
            this.inputSoldeMin = new System.Windows.Forms.TextBox();
            this.lbSoldeMin = new System.Windows.Forms.Label();
            this.inputTxInteret = new System.Windows.Forms.TextBox();
            this.lbTxInteret = new System.Windows.Forms.Label();
            this.inputPlafond = new System.Windows.Forms.TextBox();
            this.lbPlafond = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.radCourant = new System.Windows.Forms.RadioButton();
            this.radEpargne = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(52, 72);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(86, 17);
            this.lbClient.TabIndex = 2;
            this.lbClient.Text = "Libelle client";
            // 
            // inputLibelle
            // 
            this.inputLibelle.Location = new System.Drawing.Point(146, 72);
            this.inputLibelle.MaxLength = 100;
            this.inputLibelle.Name = "inputLibelle";
            this.inputLibelle.Size = new System.Drawing.Size(227, 22);
            this.inputLibelle.TabIndex = 3;
            // 
            // inputNum
            // 
            this.inputNum.Location = new System.Drawing.Point(146, 44);
            this.inputNum.MaxLength = 6;
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(227, 22);
            this.inputNum.TabIndex = 5;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(12, 44);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(128, 17);
            this.lbNumero.TabIndex = 4;
            this.lbNumero.Text = "Numero de compte";
            // 
            // inputSolde
            // 
            this.inputSolde.Location = new System.Drawing.Point(146, 100);
            this.inputSolde.MaxLength = 20;
            this.inputSolde.Name = "inputSolde";
            this.inputSolde.Size = new System.Drawing.Size(227, 22);
            this.inputSolde.TabIndex = 7;
            // 
            // lbSolde
            // 
            this.lbSolde.AutoSize = true;
            this.lbSolde.Location = new System.Drawing.Point(94, 105);
            this.lbSolde.Name = "lbSolde";
            this.lbSolde.Size = new System.Drawing.Size(44, 17);
            this.lbSolde.TabIndex = 6;
            this.lbSolde.Text = "Solde";
            // 
            // inputFraiTransfert
            // 
            this.inputFraiTransfert.Location = new System.Drawing.Point(345, 172);
            this.inputFraiTransfert.MaxLength = 5;
            this.inputFraiTransfert.Name = "inputFraiTransfert";
            this.inputFraiTransfert.Size = new System.Drawing.Size(100, 22);
            this.inputFraiTransfert.TabIndex = 9;
            // 
            // lbFraiTransfert
            // 
            this.lbFraiTransfert.AutoSize = true;
            this.lbFraiTransfert.Location = new System.Drawing.Point(230, 178);
            this.lbFraiTransfert.Name = "lbFraiTransfert";
            this.lbFraiTransfert.Size = new System.Drawing.Size(109, 17);
            this.lbFraiTransfert.TabIndex = 8;
            this.lbFraiTransfert.Text = "Frai de transfert";
            // 
            // inputSoldeMin
            // 
            this.inputSoldeMin.Location = new System.Drawing.Point(630, 171);
            this.inputSoldeMin.MaxLength = 20;
            this.inputSoldeMin.Name = "inputSoldeMin";
            this.inputSoldeMin.Size = new System.Drawing.Size(100, 22);
            this.inputSoldeMin.TabIndex = 11;
            // 
            // lbSoldeMin
            // 
            this.lbSoldeMin.AutoSize = true;
            this.lbSoldeMin.Location = new System.Drawing.Point(461, 176);
            this.lbSoldeMin.Name = "lbSoldeMin";
            this.lbSoldeMin.Size = new System.Drawing.Size(163, 17);
            this.lbSoldeMin.TabIndex = 10;
            this.lbSoldeMin.Text = "Solde minimum autoriser";
            // 
            // inputTxInteret
            // 
            this.inputTxInteret.Enabled = false;
            this.inputTxInteret.Location = new System.Drawing.Point(345, 247);
            this.inputTxInteret.MaxLength = 10;
            this.inputTxInteret.Name = "inputTxInteret";
            this.inputTxInteret.Size = new System.Drawing.Size(100, 22);
            this.inputTxInteret.TabIndex = 13;
            // 
            // lbTxInteret
            // 
            this.lbTxInteret.AutoSize = true;
            this.lbTxInteret.Location = new System.Drawing.Point(245, 247);
            this.lbTxInteret.Name = "lbTxInteret";
            this.lbTxInteret.Size = new System.Drawing.Size(94, 17);
            this.lbTxInteret.TabIndex = 12;
            this.lbTxInteret.Text = "Taux d\'interet";
            // 
            // inputPlafond
            // 
            this.inputPlafond.Enabled = false;
            this.inputPlafond.Location = new System.Drawing.Point(630, 248);
            this.inputPlafond.MaxLength = 20;
            this.inputPlafond.Name = "inputPlafond";
            this.inputPlafond.Size = new System.Drawing.Size(100, 22);
            this.inputPlafond.TabIndex = 15;
            // 
            // lbPlafond
            // 
            this.lbPlafond.AutoSize = true;
            this.lbPlafond.Location = new System.Drawing.Point(568, 252);
            this.lbPlafond.Name = "lbPlafond";
            this.lbPlafond.Size = new System.Drawing.Size(56, 17);
            this.lbPlafond.TabIndex = 14;
            this.lbPlafond.Text = "Plafond";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(345, 318);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 30);
            this.btnValider.TabIndex = 16;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // radCourant
            // 
            this.radCourant.AutoSize = true;
            this.radCourant.Checked = true;
            this.radCourant.Location = new System.Drawing.Point(15, 171);
            this.radCourant.Name = "radCourant";
            this.radCourant.Size = new System.Drawing.Size(129, 21);
            this.radCourant.TabIndex = 17;
            this.radCourant.TabStop = true;
            this.radCourant.Text = "Compte courant";
            this.radCourant.UseVisualStyleBackColor = true;
            this.radCourant.CheckedChanged += new System.EventHandler(this.radEpargne_CheckedChanged);
            // 
            // radEpargne
            // 
            this.radEpargne.AutoSize = true;
            this.radEpargne.Location = new System.Drawing.Point(15, 252);
            this.radEpargne.Name = "radEpargne";
            this.radEpargne.Size = new System.Drawing.Size(134, 21);
            this.radEpargne.TabIndex = 18;
            this.radEpargne.Text = "Compte epargne";
            this.radEpargne.UseVisualStyleBackColor = true;
            this.radEpargne.CheckedChanged += new System.EventHandler(this.radEpargne_CheckedChanged);
            // 
            // OuvrirCompteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 393);
            this.Controls.Add(this.radEpargne);
            this.Controls.Add(this.radCourant);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.inputPlafond);
            this.Controls.Add(this.lbPlafond);
            this.Controls.Add(this.inputTxInteret);
            this.Controls.Add(this.lbTxInteret);
            this.Controls.Add(this.inputSoldeMin);
            this.Controls.Add(this.lbSoldeMin);
            this.Controls.Add(this.inputFraiTransfert);
            this.Controls.Add(this.lbFraiTransfert);
            this.Controls.Add(this.inputSolde);
            this.Controls.Add(this.lbSolde);
            this.Controls.Add(this.inputNum);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.inputLibelle);
            this.Controls.Add(this.lbClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OuvrirCompteForm";
            this.Text = "Ajout de compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.TextBox inputLibelle;
        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox inputSolde;
        private System.Windows.Forms.Label lbSolde;
        private System.Windows.Forms.TextBox inputFraiTransfert;
        private System.Windows.Forms.Label lbFraiTransfert;
        private System.Windows.Forms.TextBox inputSoldeMin;
        private System.Windows.Forms.Label lbSoldeMin;
        private System.Windows.Forms.TextBox inputTxInteret;
        private System.Windows.Forms.Label lbTxInteret;
        private System.Windows.Forms.TextBox inputPlafond;
        private System.Windows.Forms.Label lbPlafond;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.RadioButton radCourant;
        private System.Windows.Forms.RadioButton radEpargne;
    }
}