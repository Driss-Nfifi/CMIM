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

namespace Itshort.UserControll.LivraisonUc
{
    public partial class Ligne : UserControl
    {
        public Ligne(int codelive,int codechar,DateTime date)
        {
            InitializeComponent();
            label9.Text = codelive.ToString();
            label11.Text = codechar.ToString();
            label4.Text = date.ToShortDateString().ToString();
        }
        SqlConnection con=new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet set = new DataSet();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Consultation fac = new Consultation(int.Parse(label9.Text));
            var App = Application.OpenForms["Form1"] as Form1;
            App.panelContainer.Controls.Clear();
            Livraison f = new Livraison();
            App.panelContainer.Controls.Add(f);
            f.panelContainer.Controls.Clear();
            f.panelContainer.Controls.Add(fac);
            fac.Dock = DockStyle.Fill;
            fac.BringToFront();
            f.Dock = DockStyle.Fill;
            f.BringToFront();
        }

        private void btnPrintBonCmd_Click(object sender, EventArgs e)
        {
            try
            {
                data = new SqlDataAdapter("select * from Livraison where CodeLivr=" + label9.Text, con);
                data.Fill(set, "Livraison");
                data = new SqlDataAdapter("select cha.* from Charge_Commande as cha inner join Chargement as ch on ch.CodeChargement=cha.CodeChargement inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + label9.Text, con);
                data.Fill(set, "Charge_Commande");
                data = new SqlDataAdapter("select ch.* from Chargement as ch  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + label9.Text, con);
                data.Fill(set, "Chargement");
                data = new SqlDataAdapter("select chau.* from chauffeur as chau  inner join Chargement as ch on chau.CodeChauffeur=ch.CodeChauf  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + label9.Text, con);
                data.Fill(set, "Chauffeur");
                data = new SqlDataAdapter("select C.* from Commande as C inner Join Charge_Commande as char on C.Codecommande=char.CodeCommande  inner join Chargement as ch on ch.CodeChargement=char.CodeChargement  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + label9.Text, con);
                data.Fill(set, "Commande");
                data = new SqlDataAdapter("select Cl.* from Client as Cl inner Join Commande as C on C.CodeClient=Cl.Codeclient inner Join Charge_Commande as char on C.Codecommande=char.CodeCommande  inner join Chargement as ch on ch.CodeChargement=char.CodeChargement  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + label9.Text, con);
                data.Fill(set, "Client");
                BonLivraison b = new BonLivraison();
                b.SetDataSource(set);
                Report_Viewer_Form r = new Report_Viewer_Form();
                r.Text = "Bon de Livraison N° " + label9.Text;
                r.crystalReportViewer1.ReportSource = b;
                r.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
