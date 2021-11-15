
namespace GestionBancaire.WinForm
{
    partial class CrediterCompteForm
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
            this.lbInfoCompte = new System.Windows.Forms.Label();
            this.lbTypeCompte = new System.Windows.Forms.Label();
            this.lbContraintes = new System.Windows.Forms.Label();
            this.inputValue = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfoCompte
            // 
            this.lbInfoCompte.AutoSize = true;
            this.lbInfoCompte.Location = new System.Drawing.Point(12, 9);
            this.lbInfoCompte.Name = "lbInfoCompte";
            this.lbInfoCompte.Size = new System.Drawing.Size(88, 17);
            this.lbInfoCompte.TabIndex = 0;
            this.lbInfoCompte.Text = "Infos compte";
            // 
            // lbTypeCompte
            // 
            this.lbTypeCompte.AutoSize = true;
            this.lbTypeCompte.Location = new System.Drawing.Point(12, 38);
            this.lbTypeCompte.Name = "lbTypeCompte";
            this.lbTypeCompte.Size = new System.Drawing.Size(90, 17);
            this.lbTypeCompte.TabIndex = 1;
            this.lbTypeCompte.Text = "Type compte";
            // 
            // lbContraintes
            // 
            this.lbContraintes.AutoSize = true;
            this.lbContraintes.Location = new System.Drawing.Point(12, 69);
            this.lbContraintes.Name = "lbContraintes";
            this.lbContraintes.Size = new System.Drawing.Size(123, 17);
            this.lbContraintes.TabIndex = 2;
            this.lbContraintes.Text = "Contrainte compte";
            // 
            // inputValue
            // 
            this.inputValue.Location = new System.Drawing.Point(15, 108);
            this.inputValue.MaxLength = 10;
            this.inputValue.Name = "inputValue";
            this.inputValue.Size = new System.Drawing.Size(100, 22);
            this.inputValue.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(173, 107);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // CrediterCompteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.lbContraintes);
            this.Controls.Add(this.lbTypeCompte);
            this.Controls.Add(this.lbInfoCompte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CrediterCompteForm";
            this.Text = "Crediter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfoCompte;
        private System.Windows.Forms.Label lbTypeCompte;
        private System.Windows.Forms.Label lbContraintes;
        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.Button btnValider;
    }
}