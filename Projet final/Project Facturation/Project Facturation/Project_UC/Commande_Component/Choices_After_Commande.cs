using Project_Facturation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Facturation.Project_UC.Commande_Component
{
    public partial class Choices_After_Commande : Form
    {
        private int codeCommande;

        public Choices_After_Commande(int CodeComande)
        {
            InitializeComponent();
            this.codeCommande = CodeComande;
        }

        private void btnConfirmerChargement_Click(object sender, EventArgs e)
        {
            using (choiceCamionAndChauffeur frm = new choiceCamionAndChauffeur())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SqlServer_Classes.ConfirmerChargement_Commande(codeCommande,
                        int.Parse(frm.cmbChauffeur.SelectedValue.ToString()),
                        int.Parse(frm.cmbCamion.SelectedValue.ToString()));
                    btnConfirmerChargement.Enabled = false;
                    btnLivrerCmd.Enabled = true;
                }
            }
        }

        private void btnLivrerCmd_Click(object sender, EventArgs e)
        {
            SqlServer_Classes.LivrerCommande_Print(codeCommande);
            btnConfirmerChargement.Enabled = false;
            btnLivrerCmd.Enabled = false;
        }

        private void btnFacturerCommande_Click(object sender, EventArgs e)
        {
            SqlServer_Classes.FacturerCommande_Print(codeCommande);
        }

        private void btnBonCmd_Click(object sender, EventArgs e)
        {
                Report_Viewer_Form frm = new Report_Viewer_Form();

                DataSet Data_Set = SqlServer_Classes.getBonCommande(codeCommande);

                BonCommande reportCommande = new BonCommande();
                reportCommande.SetDataSource(Data_Set);

                frm.Text = "Bon De Commande N°= " + codeCommande;
                frm.crystalReportViewer1.ReportSource = reportCommande;
                frm.Show();
        }
    }
}
