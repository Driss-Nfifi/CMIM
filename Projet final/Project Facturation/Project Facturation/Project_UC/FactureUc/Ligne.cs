using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itshort.UserControll.FactureUc
{
    public partial class Ligne : UserControl
    {
        public Ligne(string desi,int qtn,double prix)
        {
            InitializeComponent();
            lblProduit.Text = desi;
            lblQte.Text = qtn.ToString();
            lblPrice.Text = prix.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
