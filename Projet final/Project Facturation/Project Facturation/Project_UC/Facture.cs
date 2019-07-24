using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itshort.UserControll
{
    public partial class Facture : UserControl
    {
        public Facture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FactureUc.Creation fac = new FactureUc.Creation();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(fac);
            fac.Dock = DockStyle.Fill;
            fac.BringToFront();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FactureUc.Imprimer imp = new FactureUc.Imprimer();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(imp);
            imp.Dock = DockStyle.Fill;
            imp.BringToFront();
        }
    }
}
