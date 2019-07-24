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
    public partial class LTournee_Row : UserControl
    {
        public LTournee_Row(int codeTournee, DateTime dateCreation, int NbrCommande)
        {
            InitializeComponent();
            lblNumTournee.Text = codeTournee.ToString();
            lblDateCreation.Text = dateCreation.ToString("dddd dd MMMM yyyy à HH:mm");
            lblNbrCommande.Text = NbrCommande.ToString();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var App = Application.OpenForms["Form1"] as Form1;
            var CommandeUC = (Command_UC)App.panelContainer.Controls[0];
            var ConsulterComm = (Consulter_Tournee)CommandeUC.panelContainer.Controls[0];

            ConsulterComm.loadCommande(int.Parse(lblNumTournee.Text));

        }

    
    }
}
