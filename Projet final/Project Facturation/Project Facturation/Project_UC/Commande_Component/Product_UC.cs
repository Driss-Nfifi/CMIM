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
    public partial class Product_UC : UserControl
    {
        public Product_UC(string product, int QStock, decimal Price, string unite)
        {
            InitializeComponent();
            lblProduct.Text = product;
            lblQte.Text = QStock.ToString() + " " + unite;
            lblPrice.Text = String.Format("{0:0.00} Dhs", Price);
            setHeight();
        }

        void setHeight()
        {
            Graphics G = CreateGraphics();
            SizeF size = G.MeasureString(lblProduct.Text, lblProduct.Font, lblProduct.Width);

            lblProduct.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());

            lblPrice.Top = lblProduct.Bottom + 5;
            lblN_Price.Top = lblPrice.Top;

            lblQte.Top = lblPrice.Bottom + 5;

            lblN_QStock.Top = lblQte.Top;

            btnAdd.Top = lblN_QStock.Bottom + 5;

            this.Height = btnAdd.Bottom + 7;
        }

        private void Product_UC_Resize(object sender, EventArgs e)
        {
            setHeight();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var App = Application.OpenForms["Form1"] as Form1;
            Command_UC uc = (Command_UC)App.panelContainer.Controls[0];
            Add_Commande_UC uc_Commande = (Add_Commande_UC)uc.panelContainer.Controls[0];
            uc_Commande.txtProduct.Text = uc_Commande.ListProduits[int.Parse(this.Name)].Designation;
            uc_Commande.usedProduct = int.Parse(this.Name);
            uc_Commande.txtQte.Text = "0";
            uc_Commande.lblUnite.Text = uc_Commande.ListProduits[int.Parse(this.Name)].Unite;
        }
    }
}
