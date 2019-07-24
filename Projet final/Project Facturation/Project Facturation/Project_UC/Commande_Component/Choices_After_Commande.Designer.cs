namespace Project_Facturation.Project_UC.Commande_Component
{
    partial class Choices_After_Commande
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmerChargement = new System.Windows.Forms.Button();
            this.btnLivrerCmd = new System.Windows.Forms.Button();
            this.btnFacturerCommande = new System.Windows.Forms.Button();
            this.btnBonCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Les opérations a effectué après la validation du commande";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmerChargement
            // 
            this.btnConfirmerChargement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmerChargement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmerChargement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmerChargement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmerChargement.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerChargement.Location = new System.Drawing.Point(18, 66);
            this.btnConfirmerChargement.Name = "btnConfirmerChargement";
            this.btnConfirmerChargement.Size = new System.Drawing.Size(173, 35);
            this.btnConfirmerChargement.TabIndex = 20;
            this.btnConfirmerChargement.Text = "Confirmer Chargemet";
            this.btnConfirmerChargement.UseVisualStyleBackColor = false;
            this.btnConfirmerChargement.Click += new System.EventHandler(this.btnConfirmerChargement_Click);
            // 
            // btnLivrerCmd
            // 
            this.btnLivrerCmd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLivrerCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLivrerCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivrerCmd.Enabled = false;
            this.btnLivrerCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivrerCmd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivrerCmd.Location = new System.Drawing.Point(197, 66);
            this.btnLivrerCmd.Name = "btnLivrerCmd";
            this.btnLivrerCmd.Size = new System.Drawing.Size(154, 35);
            this.btnLivrerCmd.TabIndex = 21;
            this.btnLivrerCmd.Text = "Livrer La Commande";
            this.btnLivrerCmd.UseVisualStyleBackColor = false;
            this.btnLivrerCmd.Click += new System.EventHandler(this.btnLivrerCmd_Click);
            // 
            // btnFacturerCommande
            // 
            this.btnFacturerCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFacturerCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFacturerCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturerCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturerCommande.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturerCommande.Location = new System.Drawing.Point(197, 111);
            this.btnFacturerCommande.Name = "btnFacturerCommande";
            this.btnFacturerCommande.Size = new System.Drawing.Size(154, 35);
            this.btnFacturerCommande.TabIndex = 22;
            this.btnFacturerCommande.Text = "Facturer La Commande";
            this.btnFacturerCommande.UseVisualStyleBackColor = false;
            this.btnFacturerCommande.Click += new System.EventHandler(this.btnFacturerCommande_Click);
            // 
            // btnBonCmd
            // 
            this.btnBonCmd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBonCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBonCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBonCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBonCmd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonCmd.Location = new System.Drawing.Point(18, 111);
            this.btnBonCmd.Name = "btnBonCmd";
            this.btnBonCmd.Size = new System.Drawing.Size(173, 35);
            this.btnBonCmd.TabIndex = 23;
            this.btnBonCmd.Text = "Imprimer Bon Commande";
            this.btnBonCmd.UseVisualStyleBackColor = false;
            this.btnBonCmd.Click += new System.EventHandler(this.btnBonCmd_Click);
            // 
            // Choices_After_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 165);
            this.Controls.Add(this.btnBonCmd);
            this.Controls.Add(this.btnFacturerCommande);
            this.Controls.Add(this.btnLivrerCmd);
            this.Controls.Add(this.btnConfirmerChargement);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Choices_After_Commande";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opérations après commande";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmerChargement;
        private System.Windows.Forms.Button btnLivrerCmd;
        private System.Windows.Forms.Button btnFacturerCommande;
        private System.Windows.Forms.Button btnBonCmd;
    }
}