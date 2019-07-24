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

namespace Itshort.UserControll.FactureUc
{
    public partial class Creation : UserControl
    {
        public Creation()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        SqlDataReader read;
        DataTable t = new DataTable();
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet set = new DataSet();
        private void Creation_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                com.CommandText = "select CodeFacture,CodeComm,Total from facture";
                this.panel2.Controls.Clear();
                TitleFact fact = new TitleFact();
                fact.Dock = DockStyle.Top;
                this.panel2.Controls.Add(fact);
                fact.BringToFront();
                read = com.ExecuteReader();
                if (read.HasRows)
                {  
                    while (read.Read())
                    {
                        LigneFacture ligne = new LigneFacture(int.Parse(read[0].ToString()), int.Parse(read[1].ToString()), double.Parse(read[2].ToString()));
                        ligne.Dock = DockStyle.Top;
                        this.panel2.Controls.Add(ligne);
                        ligne.BringToFront();
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
        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  if (test == true)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    com.CommandText = "select C.DateCommande,C.CodeDepot,C.CodeClient,Cl.Nom,Cl.Prenom from Commande as C inner Join Client as Cl on C.CodeClient=Cl.Codeclient where C.Codecommande=" + comboBox1.Text;
                    read = com.ExecuteReader();
                    if (read.HasRows)
                    {
                        read.Read();
                        textBox2.Text = read[2].ToString();
                        textBox4.Text = read[3].ToString()+" "+ read[4].ToString();
                        textBox1.Text =read[1].ToString();
                        textBox5.Text = ((DateTime)read[0]).ToShortDateString();
                        read.Close();
                        com.CommandText = "select Sum(p.PrixUnitaire*l.QteCommande) from Produit as p inner join ligneCommande as l on l.CodeProduit = p.CodeProduit inner join Commande as C on C.Codecommande = l.Codecomm where C.Codecommande =" + comboBox1.Text;
                        read = com.ExecuteReader();
                        if (read.HasRows)
                        {
                            read.Read();
                            textBox3.Text = read[0].ToString()+"Dh";
                            total = double.Parse(read[0].ToString());
                        }
                            this.panel2.Controls.Clear();
                        FactureUc.Title tit = new FactureUc.Title();
                        this.panel2.Controls.Add(tit);
                        tit.Dock = DockStyle.Top;
                        tit.BringToFront();
                        read.Close();
                        com.CommandText = "select P.Designation,P.PrixUnitaire,l.QteCommande from Produit as P inner join ligneCommande as l on l.CodeProduit=P.CodeProduit inner join  Commande as C on C.Codecommande=l.Codecomm where C.Codecommande=" + comboBox1.Text;
                        read = com.ExecuteReader();
                        if (read.HasRows)
                        {
                            while (read.Read())
                            {
                                FactureUc.Ligne ligne = new FactureUc.Ligne(read[0].ToString(),int.Parse(read[2].ToString()),double.Parse(read[1].ToString()));
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
            }*/
        }
    }
}
