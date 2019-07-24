namespace Project_Facturation.Project_UC.Commande_Component
{
    partial class Add_Commande_UC
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
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.txtDateOperation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCommandeProducts = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUnite = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnValidateCommande = new System.Windows.Forms.Button();
            this.lblMontantTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date D\'opération:";
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(456, 8);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(265, 25);
            this.cmbClient.TabIndex = 1;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // txtDateOperation
            // 
            this.txtDateOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDateOperation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDateOperation.Location = new System.Drawing.Point(124, 9);
            this.txtDateOperation.Name = "txtDateOperation";
            this.txtDateOperation.Size = new System.Drawing.Size(213, 23);
            this.txtDateOperation.TabIndex = 2;
            this.txtDateOperation.Text = "Lundi 04 Décembre 2019 14:53";
            this.txtDateOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateOperation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDateOperation_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Le Client:";
            // 
            // panelCommandeProducts
            // 
            this.panelCommandeProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCommandeProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCommandeProducts.Location = new System.Drawing.Point(481, 49);
            this.panelCommandeProducts.Name = "panelCommandeProducts";
            this.panelCommandeProducts.Size = new System.Drawing.Size(259, 363);
            this.panelCommandeProducts.TabIndex = 4;
            this.panelCommandeProducts.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelCommandeProducts_ControlAdded);
            this.panelCommandeProducts.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelCommandeProducts_ControlAdded);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.txtDateOperation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbClient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 40);
            this.panel1.TabIndex = 6;
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduct.Location = new System.Drawing.Point(15, 49);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Padding = new System.Windows.Forms.Padding(7);
            this.panelProduct.Size = new System.Drawing.Size(457, 334);
            this.panelProduct.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblUnite);
            this.panel2.Controls.Add(this.txtQte);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtProduct);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(15, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 53);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Project_Facturation.Properties.Resources.send_button_1_;
            this.btnAdd.Location = new System.Drawing.Point(409, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUnite
            // 
            this.lblUnite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnite.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnite.Location = new System.Drawing.Point(361, 7);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(48, 36);
            this.lblUnite.TabIndex = 12;
            this.lblUnite.Text = "Kgs";
            this.lblUnite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQte
            // 
            this.txtQte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtQte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQte.Location = new System.Drawing.Point(265, 14);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(90, 23);
            this.txtQte.TabIndex = 11;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qte:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProduct
            // 
            this.txtProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProduct.Location = new System.Drawing.Point(65, 14);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(150, 23);
            this.txtProduct.TabIndex = 9;
            this.txtProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDateOperation_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Produit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnValidateCommande);
            this.panel3.Controls.Add(this.lblMontantTotal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(481, 418);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 53);
            this.panel3.TabIndex = 9;
            // 
            // btnValidateCommande
            // 
            this.btnValidateCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidateCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnValidateCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidateCommande.FlatAppearance.BorderSize = 0;
            this.btnValidateCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateCommande.Image = global::Project_Facturation.Properties.Resources.checked_1_;
            this.btnValidateCommande.Location = new System.Drawing.Point(214, 5);
            this.btnValidateCommande.Name = "btnValidateCommande";
            this.btnValidateCommande.Size = new System.Drawing.Size(40, 40);
            this.btnValidateCommande.TabIndex = 14;
            this.btnValidateCommande.UseVisualStyleBackColor = false;
            this.btnValidateCommande.Click += new System.EventHandler(this.btnValidateCommande_Click);
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantTotal.Location = new System.Drawing.Point(73, 5);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(140, 40);
            this.lblMontantTotal.TabIndex = 5;
            this.lblMontantTotal.Text = "0,00 Dhs";
            this.lblMontantTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Montant:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSearchProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchProduct.Location = new System.Drawing.Point(263, 389);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(209, 23);
            this.txtSearchProduct.TabIndex = 5;
            this.txtSearchProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rechercher Produit:";
            // 
            // Add_Commande_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelCommandeProducts);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Commande_UC";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 19, 0);
            this.Size = new System.Drawing.Size(759, 485);
            this.Load += new System.EventHandler(this.Add_Commande_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.TextBox txtDateOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtProduct;
        public System.Windows.Forms.Label lblUnite;
        public System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel panelCommandeProducts;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMontantTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValidateCommande;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label label6;
    }
}
