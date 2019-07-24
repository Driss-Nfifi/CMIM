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
    public partial class Livraison : UserControl
    {
        public Livraison()
        {
            InitializeComponent();
        }

        private void Livraison_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LivraisonUc.CreationLiv Crea = new LivraisonUc.CreationLiv();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(Crea);
            Crea.Dock = DockStyle.Fill;
            Crea.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LivraisonUc.Impression pre = new LivraisonUc.Impression();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(pre);
            pre.Dock = DockStyle.Fill;
            pre.BringToFront();
        }
    }
}
