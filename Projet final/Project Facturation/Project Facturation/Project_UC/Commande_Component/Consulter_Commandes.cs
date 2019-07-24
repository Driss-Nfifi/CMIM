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
using System.Data.SqlClient;

namespace Project_Facturation.Project_UC.Commande_Component
{
    public partial class Consulter_Commandes : UserControl
    {
        UserControl userControl;

        public Consulter_Commandes()
        {
            InitializeComponent();
        }

        private void Consulter_Commandes_Load(object sender, EventArgs e)
        {
            DataTable dt = SqlServer_Classes.executeAndReturnTable(@"select Codecommande, DateCommande, Convert(varchar, Client.Codeclient) + ' : ' + Upper(Nom) + ' ' + Prenom 
            from Commande inner join Client on Client.Codeclient = Commande.CodeClient");
            foreach (DataRow r in dt.Rows)
            {
                userControl = new LCmd_Row(int.Parse(r[0].ToString()), DateTime.Parse(r[1].ToString()), r[2].ToString());
                userControl.Dock = DockStyle.Top;
                panelCommandes.Controls.Add(userControl);
            }
            userControl = new LCmd_Title();
            userControl.Dock = DockStyle.Top;
            panelCommandes.Controls.Add(userControl);
        }

        public void loadCommande(int CodeCommande)
        {
            panelProducts.Controls.Clear();
            DataTable dt = SqlServer_Classes.executeAndReturnTable(@"select Designation, QteCommande, Unite, QteCommande * PrixUnitaire as mtTotal, ligneCommande.CodeProduit from Commande inner join ligneCommande on Commande.Codecommande = ligneCommande.Codecomm
                    inner join Produit on Produit.CodeProduit = ligneCommande.CodeProduit
                    where Commande.Codecommande = '" + CodeCommande + "'");
            foreach (DataRow r in dt.Rows)
            {
                userControl = new Commande_Row(r[0].ToString(), int.Parse(r[1].ToString()), r[2].ToString(), decimal.Parse(r[3].ToString()), -1);
                userControl.Name = r[0].ToString();
                userControl.Dock = DockStyle.Top;
                panelProducts.Controls.Add(userControl);
            }
            userControl = new Commande_Title();
            userControl.Dock = DockStyle.Top;
            panelProducts.Controls.Add(userControl);
            panelProducts.AutoScroll = false;
            panelProducts.HorizontalScroll.Enabled = false;
            panelProducts.HorizontalScroll.Visible = false;
            panelProducts.HorizontalScroll.Maximum = 0;
            panelProducts.AutoScroll = true;
        }

        private List<int> selectedProducts()
        {
            List<int> listDesProduit = new List<int>();
            foreach(Control C in panelProducts.Controls)
            {
                if(C is Commande_Row)
                {
                    if (((Commande_Row)C).chk_Select.Checked)
                        listDesProduit.Add(int.Parse(C.Name));
                }
            }
            return listDesProduit;
        }

        private void btnConfirmerChargement_Click(object sender, EventArgs e)
        {
          /* if (cmbCodeCommande.SelectedIndex >= 0)
            {
                if(selectedProducts().Count > 0)
                {
                    using(choiceCamionAndChauffeur frm = new choiceCamionAndChauffeur())
                    {
                        if(frm.ShowDialog() == DialogResult.OK)
                        {
                            SqlParameter[] parametre = new SqlParameter[]
                            {
                                new SqlParameter("@CodeChauf", int.Parse(frm.cmbChauffeur.SelectedValue.ToString())),
                                new SqlParameter("@CodeCamion", int.Parse(frm.cmbCamion.SelectedValue.ToString()))
                            };
                            SqlServer_Classes.ExecuteQuery("insert into Chargement(CodeChauf, CodeCamion) values(@CodeChauf, @CodeCamion)", parametre);

                            int CodeChargement = int.Parse(SqlServer_Classes.ExecuteScalar("select IDENT_CURRENT('Chargement')").ToString());

                            foreach(int CodeProduct in selectedProducts())
                            {
                                parametre = new SqlParameter[]
                                {
                                new SqlParameter("@CodeChargement", CodeChargement),
                                new SqlParameter("@CodeComm", int.Parse(cmbCodeCommande.Text)),
                                new SqlParameter("@CodeProduit", CodeProduct)
                                };
                                SqlServer_Classes.ExecuteQuery("insert into Charge_Commande values(@CodeChargement, @CodeComm, @CodeProduit)", parametre);
                            }
                            loadCommande();
                            MessageBox.Show("La confirmation de chargement a bien été effectué", "Chargement effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            printBonChargemenet();
                        }
                    }
                }
                else
                    MessageBox.Show("Veuillez Sélectionner les produits qui ont été chargés", "Produits Non selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void printBonChargemenet()
        {
            int CodeChargement = int.Parse(SqlServer_Classes.ExecuteScalar("select IDENT_CURRENT('Chargement')").ToString());

            var App = Application.OpenForms["Form1"] as Form1;

            Command_UC ucComm = (Command_UC)App.panelContainer.Controls[0];

            DataSet Data_Set = SqlServer_Classes.getBonChargement(CodeChargement);

            BonDeChargement reportCommande = new BonDeChargement();
            reportCommande.SetDataSource(Data_Set);

            ReportViewer_UC viewer_UC = new ReportViewer_UC();
            viewer_UC.Dock = DockStyle.Fill;
            viewer_UC.crystalReportViewer1.ReportSource = reportCommande;
            viewer_UC.Refresh();

            App.panelContainer.Controls.Clear();
            App.panelContainer.Controls.Add(viewer_UC);
        }
    }
}
