using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Facturation.Project_UC.Commande_Component;

namespace Project_Facturation.Project_UC
{
    public partial class Command_UC : UserControl
    {
        UserControl Uc;
        public Command_UC()
        {
            InitializeComponent();
        }

        private void btnAddCommande_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Uc = new Add_Commande_UC();
            Uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(Uc);
        }

        private void btnConsultCmd_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Uc = new Consulter_Commandes();
            Uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(Uc);
        }

        private void add_Commande_UC1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintFacture_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Uc = new Consulter_Tournee();
            Uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(Uc);
        }
    }
}
