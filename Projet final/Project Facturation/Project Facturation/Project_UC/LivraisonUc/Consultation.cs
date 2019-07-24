using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Facturation;

namespace Itshort.UserControll.LivraisonUc
{
    public partial class Consultation : UserControl
    {
        public Consultation(int codediv)
        {
            InitializeComponent();
            textBox8.Text = codediv.ToString();
        }
        SqlConnection con;
        SqlCommand com;
        SqlDataReader read;
        DataSet set = new DataSet();
        SqlDataAdapter data = new SqlDataAdapter();
        private void Consultation_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
            com = new SqlCommand();
            com.Connection = con;
           try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                com.CommandText = @"select Livraison.CodeChargement,Datelivraison, DateChargement, CodeCamion, Commande.CodeClient,CodeDepot, Codecommande,
Nom,PreNom,CIN from Livraison 
inner join Chargement on Chargement.CodeChargement = Livraison.CodeChargement
inner join Tournee on Tournee.NumeroTournee = Chargement.CodeTournee
inner join Commande on Commande.numTournee = Tournee.NumeroTournee
inner join Client on Commande.CodeClient = Client.Codeclient
where CodeLivr = " + textBox8.Text;
                read = com.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    textBox9.Text = read[0].ToString();
                    textBox2.Text = read[4].ToString();
                    textBox3.Text = read[5].ToString();
                    textBox1.Text = read[3].ToString();
                    textBox5.Text = read[7].ToString() + " " + read[8].ToString();
                    textBox4.Text = read[9].ToString();
                    textBox7.Text = ((DateTime)read[2]).ToShortDateString();
                    textBox6.Text = ((DateTime)read[1]).ToShortDateString();
                    textBox10.Text = read[6].ToString();
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                data = new SqlDataAdapter("select * from Livraison where CodeLivr=" + textBox8.Text,con);
                data.Fill(set,"Livraison");
                data = new SqlDataAdapter("select cha.* from Charge_Commande as cha inner join Chargement as ch on ch.CodeChargement=cha.CodeChargement inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + textBox8.Text, con);
                data.Fill(set, "Charge_Commande");
                data = new SqlDataAdapter("select ch.* from Chargement as ch  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + textBox8.Text, con);
                data.Fill(set, "Chargement");
                data = new SqlDataAdapter("select chau.* from chauffeur as chau  inner join Chargement as ch on chau.CodeChauffeur=ch.CodeChauf  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + textBox8.Text, con);
                data.Fill(set, "Chauffeur");
                data = new SqlDataAdapter("select C.* from Commande as C inner Join Charge_Commande as char on C.Codecommande=char.CodeCommande  inner join Chargement as ch on ch.CodeChargement=char.CodeChargement  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + textBox8.Text, con);
                data.Fill(set, "Commande");
                data = new SqlDataAdapter("select Cl.* from Client as Cl inner Join Commande as C on C.CodeClient=Cl.Codeclient inner Join Charge_Commande as char on C.Codecommande=char.CodeCommande  inner join Chargement as ch on ch.CodeChargement=char.CodeChargement  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + textBox8.Text, con);
                data.Fill(set, "Client");
                BonLivraison b = new BonLivraison();
                b.SetDataSource(set);
                Report_Viewer_Form r = new Report_Viewer_Form();
                r.Text = "Bon de Livraison N° " + textBox8.Text;
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
