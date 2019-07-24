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
    public partial class choiceCamionAndChauffeur : Form
    {
        public choiceCamionAndChauffeur()
        {
            InitializeComponent();
        }

        private void choiceCamionAndChauffeur_Load(object sender, EventArgs e)
        {
            cmbCamion.DataSource = SqlServer_Classes.executeAndReturnTable("select codecamm, Matricule from Camion");
            cmbCamion.ValueMember = "codecamm";
            cmbCamion.DisplayMember = "Matricule";

            cmbChauffeur.DataSource = SqlServer_Classes.executeAndReturnTable("select CodeChauffeur, CIN + ' ' + Upper(Nom) + ' ' + Lower(PreNom) as Name from chauffeur");
            cmbChauffeur.ValueMember = "CodeChauffeur";
            cmbChauffeur.DisplayMember = "Name";
        }

        private void btnPrintBonCommande_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiement confirmer le chargement de la commande", "Message Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
