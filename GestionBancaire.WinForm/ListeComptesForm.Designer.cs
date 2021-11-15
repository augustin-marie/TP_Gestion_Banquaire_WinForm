
namespace GestionBancaire.WinForm
{
    partial class ListeComptesForm
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
            this.lbLibelles = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lbComptes = new System.Windows.Forms.ListBox();
            this.btnTransferer = new System.Windows.Forms.Button();
            this.btnDebiter = new System.Windows.Forms.Button();
            this.btnCrediter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLibelles
            // 
            this.lbLibelles.AutoSize = true;
            this.lbLibelles.Location = new System.Drawing.Point(77, 36);
            this.lbLibelles.Name = "lbLibelles";
            this.lbLibelles.Size = new System.Drawing.Size(113, 17);
            this.lbLibelles.TabIndex = 0;
            this.lbLibelles.Text = "Libelles comptes";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(604, 56);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 30);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(604, 282);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 30);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(604, 318);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 30);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lbComptes
            // 
            this.lbComptes.FormattingEnabled = true;
            this.lbComptes.ItemHeight = 16;
            this.lbComptes.Location = new System.Drawing.Point(80, 56);
            this.lbComptes.Name = "lbComptes";
            this.lbComptes.Size = new System.Drawing.Size(518, 292);
            this.lbComptes.TabIndex = 4;
            // 
            // btnTransferer
            // 
            this.btnTransferer.Location = new System.Drawing.Point(604, 246);
            this.btnTransferer.Name = "btnTransferer";
            this.btnTransferer.Size = new System.Drawing.Size(100, 30);
            this.btnTransferer.TabIndex = 5;
            this.btnTransferer.Text = "Transferer";
            this.btnTransferer.UseVisualStyleBackColor = true;
            this.btnTransferer.Click += new System.EventHandler(this.btnTransferer_Click);
            // 
            // btnDebiter
            // 
            this.btnDebiter.Location = new System.Drawing.Point(604, 210);
            this.btnDebiter.Name = "btnDebiter";
            this.btnDebiter.Size = new System.Drawing.Size(100, 30);
            this.btnDebiter.TabIndex = 7;
            this.btnDebiter.Text = "Debiter";
            this.btnDebiter.UseVisualStyleBackColor = true;
            this.btnDebiter.Click += new System.EventHandler(this.btnDebiter_Click);
            // 
            // btnCrediter
            // 
            this.btnCrediter.Location = new System.Drawing.Point(604, 174);
            this.btnCrediter.Name = "btnCrediter";
            this.btnCrediter.Size = new System.Drawing.Size(100, 30);
            this.btnCrediter.TabIndex = 8;
            this.btnCrediter.Text = "Crediter";
            this.btnCrediter.UseVisualStyleBackColor = true;
            this.btnCrediter.Click += new System.EventHandler(this.btnCrediter_Click);
            // 
            // ListeComptesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 419);
            this.Controls.Add(this.btnCrediter);
            this.Controls.Add(this.btnDebiter);
            this.Controls.Add(this.btnTransferer);
            this.Controls.Add(this.lbComptes);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lbLibelles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListeComptesForm";
            this.Text = "RaisonSocialeBanque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLibelles;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ListBox lbComptes;
        private System.Windows.Forms.Button btnTransferer;
        private System.Windows.Forms.Button btnDebiter;
        private System.Windows.Forms.Button btnCrediter;
    }
}