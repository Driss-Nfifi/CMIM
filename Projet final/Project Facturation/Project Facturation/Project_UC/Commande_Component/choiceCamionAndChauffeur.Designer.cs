namespace Project_Facturation.Project_UC.Commande_Component
{
    partial class choiceCamionAndChauffeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choiceCamionAndChauffeur));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCamion = new System.Windows.Forms.ComboBox();
            this.cmbChauffeur = new System.Windows.Forms.ComboBox();
            this.btnPrintBonCommande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisissez le Camion Et Le Chauffeur Qui S\'occupera du chargement des produits de" +
    " cette commande";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Le Camion:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Le Chauffeur:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCamion
            // 
            this.cmbCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCamion.FormattingEnabled = true;
            this.cmbCamion.Location = new System.Drawing.Point(126, 71);
            this.cmbCamion.Name = "cmbCamion";
            this.cmbCamion.Size = new System.Drawing.Size(241, 25);
            this.cmbCamion.TabIndex = 4;
            // 
            // cmbChauffeur
            // 
            this.cmbChauffeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChauffeur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChauffeur.FormattingEnabled = true;
            this.cmbChauffeur.Location = new System.Drawing.Point(126, 110);
            this.cmbChauffeur.Name = "cmbChauffeur";
            this.cmbChauffeur.Size = new System.Drawing.Size(241, 25);
            this.cmbChauffeur.TabIndex = 5;
            // 
            // btnPrintBonCommande
            // 
            this.btnPrintBonCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrintBonCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrintBonCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBonCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBonCommande.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBonCommande.Location = new System.Drawing.Point(76, 156);
            this.btnPrintBonCommande.Name = "btnPrintBonCommande";
            this.btnPrintBonCommande.Size = new System.Drawing.Size(251, 35);
            this.btnPrintBonCommande.TabIndex = 19;
            this.btnPrintBonCommande.Text = "Confirmer Le Chargement Du Commande";
            this.btnPrintBonCommande.UseVisualStyleBackColor = false;
            this.btnPrintBonCommande.Click += new System.EventHandler(this.btnPrintBonCommande_Click);
            // 
            // choiceCamionAndChauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 210);
            this.Controls.Add(this.btnPrintBonCommande);
            this.Controls.Add(this.cmbChauffeur);
            this.Controls.Add(this.cmbCamion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "choiceCamionAndChauffeur";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmer Le Chargement";
            this.Load += new System.EventHandler(this.choiceCamionAndChauffeur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintBonCommande;
        public System.Windows.Forms.ComboBox cmbCamion;
        public System.Windows.Forms.ComboBox cmbChauffeur;
    }
}