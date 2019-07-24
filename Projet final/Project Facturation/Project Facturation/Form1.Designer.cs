namespace Project_Facturation
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMAJ = new System.Windows.Forms.Button();
            this.btnRessources = new System.Windows.Forms.Button();
            this.btnFacturation = new System.Windows.Forms.Button();
            this.btnLivraison = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.command_UC1 = new Project_Facturation.Project_UC.Command_UC();
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Controls.Add(this.panelButtons);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1024, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Monofonto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(204, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(630, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Logiciel De Facturation Et Livraison";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Project_Facturation.Properties.Resources.itshore;
            this.picLogo.Location = new System.Drawing.Point(9, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnMinimize);
            this.panelButtons.Controls.Add(this.btnMaximize);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(849, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(175, 50);
            this.panelButtons.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Project_Facturation.Properties.Resources.close_window;
            this.btnClose.Location = new System.Drawing.Point(126, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Project_Facturation.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(27, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Project_Facturation.Properties.Resources.maximize;
            this.btnMaximize.Location = new System.Drawing.Point(77, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 40);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.btnMAJ);
            this.panelMenu.Controls.Add(this.btnRessources);
            this.panelMenu.Controls.Add(this.btnFacturation);
            this.panelMenu.Controls.Add(this.btnLivraison);
            this.panelMenu.Controls.Add(this.btnCommande);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(255, 550);
            this.panelMenu.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Project_Facturation.Properties.Resources.settings_gears_1_;
            this.btnAdd.Location = new System.Drawing.Point(210, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMAJ
            // 
            this.btnMAJ.BackColor = System.Drawing.Color.White;
            this.btnMAJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMAJ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMAJ.Font = new System.Drawing.Font("Monofonto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(59)))));
            this.btnMAJ.Location = new System.Drawing.Point(0, 292);
            this.btnMAJ.Name = "btnMAJ";
            this.btnMAJ.Size = new System.Drawing.Size(253, 73);
            this.btnMAJ.TabIndex = 4;
            this.btnMAJ.Text = "Mise à jour";
            this.btnMAJ.UseVisualStyleBackColor = false;
            this.btnMAJ.Click += new System.EventHandler(this.btnMAJ_Click);
            // 
            // btnRessources
            // 
            this.btnRessources.BackColor = System.Drawing.Color.White;
            this.btnRessources.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRessources.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRessources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRessources.Font = new System.Drawing.Font("Monofonto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRessources.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(59)))));
            this.btnRessources.Location = new System.Drawing.Point(0, 219);
            this.btnRessources.Name = "btnRessources";
            this.btnRessources.Size = new System.Drawing.Size(253, 73);
            this.btnRessources.TabIndex = 3;
            this.btnRessources.Text = "Ressources";
            this.btnRessources.UseVisualStyleBackColor = false;
            this.btnRessources.Click += new System.EventHandler(this.btnRessources_Click);
            // 
            // btnFacturation
            // 
            this.btnFacturation.BackColor = System.Drawing.Color.White;
            this.btnFacturation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturation.Font = new System.Drawing.Font("Monofonto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(59)))));
            this.btnFacturation.Location = new System.Drawing.Point(0, 146);
            this.btnFacturation.Name = "btnFacturation";
            this.btnFacturation.Size = new System.Drawing.Size(253, 73);
            this.btnFacturation.TabIndex = 2;
            this.btnFacturation.Text = "Facturation";
            this.btnFacturation.UseVisualStyleBackColor = false;
            this.btnFacturation.Click += new System.EventHandler(this.btnFacturation_Click);
            // 
            // btnLivraison
            // 
            this.btnLivraison.BackColor = System.Drawing.Color.White;
            this.btnLivraison.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivraison.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivraison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivraison.Font = new System.Drawing.Font("Monofonto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivraison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(59)))));
            this.btnLivraison.Location = new System.Drawing.Point(0, 73);
            this.btnLivraison.Name = "btnLivraison";
            this.btnLivraison.Size = new System.Drawing.Size(253, 73);
            this.btnLivraison.TabIndex = 1;
            this.btnLivraison.Text = "Livraison";
            this.btnLivraison.UseVisualStyleBackColor = false;
            this.btnLivraison.Click += new System.EventHandler(this.btnLivraison_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.btnCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommande.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Monofonto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(59)))));
            this.btnCommande.Location = new System.Drawing.Point(0, 0);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(253, 73);
            this.btnCommande.TabIndex = 0;
            this.btnCommande.Text = "Commande";
            this.btnCommande.UseVisualStyleBackColor = false;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.command_UC1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(255, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(769, 550);
            this.panelContainer.TabIndex = 2;
            // 
            // command_UC1
            // 
            this.command_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.command_UC1.Location = new System.Drawing.Point(0, 0);
            this.command_UC1.Name = "command_UC1";
            this.command_UC1.Size = new System.Drawing.Size(769, 550);
            this.command_UC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMAJ;
        private System.Windows.Forms.Button btnRessources;
        private System.Windows.Forms.Button btnFacturation;
        private System.Windows.Forms.Button btnLivraison;
        private System.Windows.Forms.Button btnCommande;
        private Project_UC.Command_UC command_UC1;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTipButtons;
    }
}

