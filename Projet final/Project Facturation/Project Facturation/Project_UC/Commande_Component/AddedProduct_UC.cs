using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Facturation.Project_UC.Commande_Component
{
    public partial class AddedProduct_UC : UserControl
    {
        public AddedProduct_UC(int CodeProduct, string Designation, int Qte, string unite, decimal Montant)
        {
            InitializeComponent();
            lblCodeproduit.Text = CodeProduct.ToString();
            lblDesignation.Text = Designation;
            lblQteCommande.Text = Qte + " " + unite;
            lblMontant.Text = string.Format("{0:0.00} Dhs", Montant);
            setHeight();
        }

        void setHeight()
        {
            Graphics G = CreateGraphics();
            SizeF size = G.MeasureString(lblDesignation.Text, lblDesignation.Font, lblDesignation.Width);

            lblDesignation.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());

            lblDesignation.Top = lblCodeproduit.Bottom + 5;
            lblN_Designation.Top = lblDesignation.Top;
            

            lblQteCommande.Top = lblDesignation.Bottom + 5;
            lblN_Qte.Top = lblQteCommande.Top;

            lblMontant.Top = lblN_Qte.Bottom + 5;

            lblN_Mt.Top = lblMontant.Top;

            this.Height = lblN_Mt.Bottom + 7;
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var App = Application.OpenForms["Form1"] as Form1;
            Command_UC uc = (Command_UC)App.panelContainer.Controls[0];
            Add_Commande_UC uc_Commande = (Add_Commande_UC)uc.panelContainer.Controls[0];
            int index = uc_Commande.getPrecedentControl(int.Parse(lblCodeproduit.Text));
            if(index != -1)
            {
                uc_Commande.panelCommandeProducts.Controls.RemoveAt(index);
            }
        }
    }
}
