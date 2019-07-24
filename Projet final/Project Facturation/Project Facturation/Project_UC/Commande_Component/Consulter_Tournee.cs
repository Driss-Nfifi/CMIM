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
    public partial class Consulter_Tournee : UserControl
    {
        UserControl userControl;

        public Consulter_Tournee()
        {
            InitializeComponent();
        }

        private void Consulter_Tournee_Load(object sender, EventArgs e)
        {
            DataTable dt = SqlServer_Classes.executeAndReturnTable(@"select *, [dbo].[getNbrCommande](NumeroTournee) from Tournee");
            foreach (DataRow r in dt.Rows)
            {
                userControl = new LTournee_Row(int.Parse(r[0].ToString()), DateTime.Parse(r[1].ToString()), int.Parse(r[2].ToString()));
                userControl.Dock = DockStyle.Top;
                panelTournees.Controls.Add(userControl);
            }
            userControl = new LTournee_Title();
            userControl.Dock = DockStyle.Top;
            panelTournees.Controls.Add(userControl);
        }

        public void loadCommande(int CodeTournee)
        {
            panelCommandes.Controls.Clear();
            DataTable dt = SqlServer_Classes.executeAndReturnTable(@"select CodeCommande, DateCommande, Convert(varchar, Client.Codeclient) + ' : ' + UPPER(Nom) + ' ' + LOWER(Prenom) from Commande
            inner join Client on Client.Codeclient = Commande.CodeClient
            where numTournee = '"+CodeTournee+"'");
            foreach (DataRow r in dt.Rows)
            {
                userControl = new LCmd_Row(int.Parse(r[0].ToString()), DateTime.Parse(r[1].ToString()), r[2].ToString());
                ((LCmd_Row)userControl).btnDetail.Enabled = false;
                userControl.Dock = DockStyle.Top;
                panelCommandes.Controls.Add(userControl);
            }
            userControl = new LCmd_Title();
            userControl.Dock = DockStyle.Top;
            panelCommandes.Controls.Add(userControl);
            panelCommandes.AutoScroll = false;
            panelCommandes.HorizontalScroll.Enabled = false;
            panelCommandes.HorizontalScroll.Visible = false;
            panelCommandes.HorizontalScroll.Maximum = 0;
            panelCommandes.AutoScroll = true;
        }
    }
}
