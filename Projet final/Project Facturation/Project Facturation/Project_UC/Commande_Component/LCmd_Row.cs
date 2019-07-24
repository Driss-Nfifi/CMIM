using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Facturation.Models;

namespace Project_Facturation.Project_UC.Commande_Component
{
    public partial class LCmd_Row : UserControl
    {
        public LCmd_Row(int codeCommande, DateTime dtCommande, string Client)
        {
            InitializeComponent();
            lblCodeCommande.Text = codeCommande.ToString();
            lblDateCommande.Text = dtCommande.ToString("dd-MM-yyyy HH:mm");
            lblClient.Text = Client;
            toolTip1.SetToolTip(btnPrintBonCmd, "Imprimer La Bon De Commande");
            toolTip1.SetToolTip(btnDetail, "Afficher Detail Commande");
        }

        private void lblDetail_Click(object sender, EventArgs e)
        {

        }

        private void lblClient_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var App = Application.OpenForms["Form1"] as Form1;
            var CommandeUC = (Command_UC)App.panelContainer.Controls[0];
            var ConsulterComm = (Consulter_Commandes)CommandeUC.panelContainer.Controls[0];

            ConsulterComm.loadCommande(int.Parse(lblCodeCommande.Text));

        }

        private void btnPrintBonCmd_Click(object sender, EventArgs e)
        {
            Report_Viewer_Form frm = new Report_Viewer_Form();
            frm.Text = "Bon De Commande N°= " + lblCodeCommande.Text;

            DataSet set = SqlServer_Classes.getBonCommande(int.Parse(lblCodeCommande.Text));

            BonCommande reportCommande = new BonCommande();
            reportCommande.SetDataSource(set);

            frm.crystalReportViewer1.ReportSource = reportCommande;
            frm.Show();
        }
    }
}
