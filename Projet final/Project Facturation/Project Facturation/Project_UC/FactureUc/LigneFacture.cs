using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Facturation;
using System.Data.SqlClient;
namespace Itshort.UserControll.FactureUc
{
    public partial class LigneFacture : UserControl
    {
        public LigneFacture(int nfac,int ncom,double total)
        {
            InitializeComponent();
            label9.Text = nfac.ToString();
            label11.Text = ncom.ToString();
            label4.Text = string.Format("{0:0.00} Dhs", total);
        }
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet set = new DataSet();
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Imrimerfact fac = new Imrimerfact(int.Parse(label11.Text));
            var App = Application.OpenForms["Form1"] as Form1;
            App.panelContainer.Controls.Clear();
            Facture f = new Facture();
            App.panelContainer.Controls.Add(f);
            f.panelContainer.Controls.Clear();
            f.panelContainer.Controls.Add(fac);
            fac.Dock = DockStyle.Fill;
            fac.BringToFront();
            f.Dock = DockStyle.Fill;
            f.BringToFront();
        }

        private void LigneFacture_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintBonCmd_Click(object sender, EventArgs e)
        {
            try
            {
                data = new SqlDataAdapter("select CodeFacture,Total from Facture where CodeComm=" + label11.Text, con);
                data.Fill(set, "Facture");
                data = new SqlDataAdapter("select C.CodeDepot,C.CodeClient,C.DateCommande,C.Codecommande from Commande as C inner Join Facture as F on C.Codecommande=F.CodeComm where F.CodeComm=" + label11.Text, con);
                data.Fill(set, "Commande");
                data = new SqlDataAdapter("select Cl.Nom,Cl.Prenom,Cl.Cin,Cl.Tel,Cl.Adresse,Cl.Email from Client as Cl inner join Commande as C on C.CodeClient=Cl.Codeclient inner Join Facture as F on C.Codecommande=F.CodeComm where F.CodeComm=" + label11.Text, con);
                data.Fill(set, "Client");
                Facturation f = new Facturation();
                f.SetDataSource(set);
                Report_Viewer_Form r = new Report_Viewer_Form();
                r.Text = "Facture N° " + label9.Text;
                r.crystalReportViewer1.ReportSource = f;
                r.Show();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
