namespace Project_Facturation
{
    partial class MAJ_UC
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblLastMAJ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressMAJ = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnCommande = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblLastMAJ);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(769, 108);
            this.panelHeader.TabIndex = 0;
            // 
            // lblLastMAJ
            // 
            this.lblLastMAJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastMAJ.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblLastMAJ.Location = new System.Drawing.Point(361, 52);
            this.lblLastMAJ.Name = "lblLastMAJ";
            this.lblLastMAJ.Size = new System.Drawing.Size(382, 36);
            this.lblLastMAJ.TabIndex = 14;
            this.lblLastMAJ.Text = "Lun 18/02/2019 à 18:49";
            this.lblLastMAJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(472, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dernière Mise à Jour:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "BD Mise à Jour";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Etat:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressMAJ
            // 
            this.progressMAJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressMAJ.Location = new System.Drawing.Point(111, 229);
            this.progressMAJ.Name = "progressMAJ";
            this.progressMAJ.Size = new System.Drawing.Size(550, 31);
            this.progressMAJ.TabIndex = 1;
            this.progressMAJ.Value = 50;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProgress.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblProgress.Location = new System.Drawing.Point(111, 190);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(550, 36);
            this.lblProgress.TabIndex = 15;
            this.lblProgress.Text = "50 %";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCommande
            // 
            this.btnCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.btnCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Monofonto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(59)))));
            this.btnCommande.Location = new System.Drawing.Point(115, 323);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(546, 53);
            this.btnCommande.TabIndex = 16;
            this.btnCommande.Text = "Mettre à jour la base de donnée";
            this.btnCommande.UseVisualStyleBackColor = false;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // MAJ_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCommande);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressMAJ);
            this.Controls.Add(this.panelHeader);
            this.Name = "MAJ_UC";
            this.Size = new System.Drawing.Size(769, 550);
            this.Load += new System.EventHandler(this.MAJ_UC_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblLastMAJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressMAJ;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnCommande;
    }
}
