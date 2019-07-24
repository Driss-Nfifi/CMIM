namespace Project_Facturation.Project_UC
{
    partial class Command_UC
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
            this.btnAddCommande = new System.Windows.Forms.Button();
            this.btnPrintBonCommande = new System.Windows.Forms.Button();
            this.btnPrintFacture = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.add_Commande_UC1 = new Project_Facturation.Project_UC.Commande_Component.Add_Commande_UC();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelContainer.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCommande
            // 
            this.btnAddCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommande.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommande.Location = new System.Drawing.Point(34, 7);
            this.btnAddCommande.Name = "btnAddCommande";
            this.btnAddCommande.Size = new System.Drawing.Size(250, 35);
            this.btnAddCommande.TabIndex = 0;
            this.btnAddCommande.Text = "Ajouter une nouvelle commande";
            this.btnAddCommande.UseVisualStyleBackColor = false;
            this.btnAddCommande.Click += new System.EventHandler(this.btnAddCommande_Click);
            // 
            // btnPrintBonCommande
            // 
            this.btnPrintBonCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrintBonCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBonCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBonCommande.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBonCommande.Location = new System.Drawing.Point(291, 7);
            this.btnPrintBonCommande.Name = "btnPrintBonCommande";
            this.btnPrintBonCommande.Size = new System.Drawing.Size(222, 35);
            this.btnPrintBonCommande.TabIndex = 2;
            this.btnPrintBonCommande.Text = "Consulter toutes les commandes";
            this.btnPrintBonCommande.UseVisualStyleBackColor = false;
            this.btnPrintBonCommande.Click += new System.EventHandler(this.btnConsultCmd_Click);
            // 
            // btnPrintFacture
            // 
            this.btnPrintFacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrintFacture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintFacture.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintFacture.Location = new System.Drawing.Point(519, 7);
            this.btnPrintFacture.Name = "btnPrintFacture";
            this.btnPrintFacture.Size = new System.Drawing.Size(210, 35);
            this.btnPrintFacture.TabIndex = 4;
            this.btnPrintFacture.Text = "La liste des tournées";
            this.btnPrintFacture.UseVisualStyleBackColor = false;
            this.btnPrintFacture.Click += new System.EventHandler(this.btnPrintFacture_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.add_Commande_UC1);
            this.panelContainer.Location = new System.Drawing.Point(5, 53);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(759, 485);
            this.panelContainer.TabIndex = 5;
            // 
            // add_Commande_UC1
            // 
            this.add_Commande_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Commande_UC1.Location = new System.Drawing.Point(0, 0);
            this.add_Commande_UC1.Name = "add_Commande_UC1";
            this.add_Commande_UC1.Padding = new System.Windows.Forms.Padding(0, 0, 19, 0);
            this.add_Commande_UC1.Size = new System.Drawing.Size(759, 485);
            this.add_Commande_UC1.TabIndex = 0;
            this.add_Commande_UC1.Load += new System.EventHandler(this.add_Commande_UC1_Load);
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelButtons.Controls.Add(this.btnPrintFacture);
            this.panelButtons.Controls.Add(this.btnPrintBonCommande);
            this.panelButtons.Controls.Add(this.btnAddCommande);
            this.panelButtons.Location = new System.Drawing.Point(0, 5);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(769, 47);
            this.panelButtons.TabIndex = 6;
            // 
            // Command_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelButtons);
            this.Name = "Command_UC";
            this.Size = new System.Drawing.Size(769, 550);
            this.panelContainer.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCommande;
        private System.Windows.Forms.Button btnPrintBonCommande;
        private System.Windows.Forms.Button btnPrintFacture;
        private Commande_Component.Add_Commande_UC add_Commande_UC1;
        private System.Windows.Forms.Panel panelButtons;
        public System.Windows.Forms.Panel panelContainer;
    }
}
