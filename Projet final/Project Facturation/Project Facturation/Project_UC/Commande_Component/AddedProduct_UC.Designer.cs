namespace Project_Facturation.Project_UC.Commande_Component
{
    partial class AddedProduct_UC
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodeproduit = new System.Windows.Forms.Label();
            this.lblN_Designation = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblN_Qte = new System.Windows.Forms.Label();
            this.lblQteCommande = new System.Windows.Forms.Label();
            this.lblN_Mt = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code du produit:";
            // 
            // lblCodeproduit
            // 
            this.lblCodeproduit.ContextMenuStrip = this.contextMenuStrip1;
            this.lblCodeproduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeproduit.Location = new System.Drawing.Point(115, 8);
            this.lblCodeproduit.Name = "lblCodeproduit";
            this.lblCodeproduit.Size = new System.Drawing.Size(138, 17);
            this.lblCodeproduit.TabIndex = 2;
            this.lblCodeproduit.Text = "Code du produit:";
            // 
            // lblN_Designation
            // 
            this.lblN_Designation.AutoSize = true;
            this.lblN_Designation.ContextMenuStrip = this.contextMenuStrip1;
            this.lblN_Designation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN_Designation.Location = new System.Drawing.Point(32, 38);
            this.lblN_Designation.Name = "lblN_Designation";
            this.lblN_Designation.Size = new System.Drawing.Size(82, 17);
            this.lblN_Designation.TabIndex = 3;
            this.lblN_Designation.Text = "Designation:";
            // 
            // lblDesignation
            // 
            this.lblDesignation.ContextMenuStrip = this.contextMenuStrip1;
            this.lblDesignation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(115, 38);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(138, 76);
            this.lblDesignation.TabIndex = 4;
            this.lblDesignation.Text = "Code du produit:";
            // 
            // lblN_Qte
            // 
            this.lblN_Qte.AutoSize = true;
            this.lblN_Qte.ContextMenuStrip = this.contextMenuStrip1;
            this.lblN_Qte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN_Qte.Location = new System.Drawing.Point(7, 124);
            this.lblN_Qte.Name = "lblN_Qte";
            this.lblN_Qte.Size = new System.Drawing.Size(107, 17);
            this.lblN_Qte.TabIndex = 5;
            this.lblN_Qte.Text = "Qte Commandé:";
            // 
            // lblQteCommande
            // 
            this.lblQteCommande.ContextMenuStrip = this.contextMenuStrip1;
            this.lblQteCommande.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQteCommande.Location = new System.Drawing.Point(115, 124);
            this.lblQteCommande.Name = "lblQteCommande";
            this.lblQteCommande.Size = new System.Drawing.Size(138, 17);
            this.lblQteCommande.TabIndex = 6;
            this.lblQteCommande.Text = "Code du produit:";
            // 
            // lblN_Mt
            // 
            this.lblN_Mt.AutoSize = true;
            this.lblN_Mt.ContextMenuStrip = this.contextMenuStrip1;
            this.lblN_Mt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN_Mt.Location = new System.Drawing.Point(52, 160);
            this.lblN_Mt.Name = "lblN_Mt";
            this.lblN_Mt.Size = new System.Drawing.Size(62, 17);
            this.lblN_Mt.TabIndex = 7;
            this.lblN_Mt.Text = "Montant:";
            // 
            // lblMontant
            // 
            this.lblMontant.ContextMenuStrip = this.contextMenuStrip1;
            this.lblMontant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(115, 160);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(138, 17);
            this.lblMontant.TabIndex = 8;
            this.lblMontant.Text = "Code du produit:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // AddedProduct_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(232)))), ((int)(((byte)(188)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblN_Mt);
            this.Controls.Add(this.lblQteCommande);
            this.Controls.Add(this.lblN_Qte);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblN_Designation);
            this.Controls.Add(this.lblCodeproduit);
            this.Controls.Add(this.label1);
            this.Name = "AddedProduct_UC";
            this.Size = new System.Drawing.Size(257, 189);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblN_Designation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblN_Qte;
        private System.Windows.Forms.Label lblN_Mt;
        public System.Windows.Forms.Label lblCodeproduit;
        public System.Windows.Forms.Label lblQteCommande;
        public System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
