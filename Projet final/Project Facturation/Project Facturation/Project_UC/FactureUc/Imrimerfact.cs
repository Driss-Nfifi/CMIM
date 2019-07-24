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

namespace Itshort.UserControll.FactureUc
{
    public partial class Imrimerfact : UserControl
    {
        public Imrimerfact(int code)
        {
            InitializeComponent();
            textBox6.Text = code.ToString();
        }
        SqlConnection con;
        SqlCommand com;
        SqlDataReader read;
        DataTable t = new DataTable();
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet set = new DataSet();
        private void Imrimerfact_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                com.CommandText = "select C.DateCommande,C.CodeDepot,C.CodeClient,Cl.Nom,Cl.Prenom,F.Total from Commande as C inner Join Client as Cl on C.CodeClient=Cl.Codeclient inner Join Facture as F on C.Codecommande=F.CodeComm where C.Codecommande=" + textBox6.Text;
                read = com.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    textBox2.Text = read[2].ToString();
                    textBox4.Text = read[3].ToString() + " " + read[4].ToString();
                    textBox3.Text = read[5].ToString() + " Dh";
                    textBox1.Text = read[1].ToString();
                    textBox5.Text = ((DateTime)read[0]).ToShortDateString();
                    this.panel2.Controls.Clear();
                    FactureUc.Title tit = new FactureUc.Title();
                    this.panel2.Controls.Add(tit);
                    tit.Dock = DockStyle.Top;
                    tit.BringToFront();
                    read.Close();
                    com.CommandText = "select P.Designation,P.PrixUnitaire,l.QteCommande from Produit as P inner join ligneCommande as l on l.CodeProduit=P.CodeProduit inner join  Commande as C on C.Codecommande=l.Codecomm where C.Codecommande=" + textBox6.Text;
                    read = com.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            FactureUc.Ligne ligne = new FactureUc.Ligne(read[0].ToString(), int.Parse(read[2].ToString()), double.Parse(read[1].ToString()));
                            this.panel2.Controls.Add(ligne);
                            ligne.Dock = DockStyle.Top;
                            ligne.BringToFront();
                        }
                    }
                   
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                try
                {
                data = new SqlDataAdapter("select CodeFacture,Total from Facture where CodeComm=" + textBox6.Text, con);
                data.Fill(set, "Facture");
                data = new SqlDataAdapter("select C.CodeDepot,C.CodeClient,C.DateCommande,C.Codecommande from Commande as C inner Join Facture as F on C.Codecommande=F.CodeComm where F.CodeComm=" + textBox6.Text, con);
                data.Fill(set, "Commande");
                data = new SqlDataAdapter("select Cl.Nom,Cl.Prenom,Cl.Cin,Cl.Tel,Cl.Adresse,Cl.Email from Client as Cl inner join Commande as C on C.CodeClient=Cl.Codeclient inner Join Facture as F on C.Codecommande=F.CodeComm where F.CodeComm=" + textBox6.Text, con);
                data.Fill(set, "Client");
                Facturation f = new Facturation();
                    f.SetDataSource(set);
                Report_Viewer_Form r = new Report_Viewer_Form();
                r.Text = "Facture N° " + textBox6.Text;
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
