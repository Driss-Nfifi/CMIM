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
    public partial class Commande_Row : UserControl
    {
        public Commande_Row(string Produit, int Qte, string unite, decimal Mt, int CodeChargement)
        {
            InitializeComponent();
            lblProduit.Text = Produit;
            lblQte.Text = Qte + " " + unite;
            lblPrice.Text = string.Format("{0:0.00}", Mt);
            if (CodeChargement != -1)
                chk_Select.Visible = false;
        }
    }
}
