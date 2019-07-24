using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Facturation.Models;
using System.IO;

namespace Project_Facturation
{
    public partial class MAJ_UC : UserControl
    {
        public MAJ_UC()
        {
            InitializeComponent();
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog Ds = new OpenFileDialog())
                {
                    Ds.Filter = "Fichier CSV|*Csv";
                    Ds.Multiselect = false;
                    if (Ds.ShowDialog() == DialogResult.OK)
                    {
                        Dictionary<int, Commande> commandes = new Dictionary<int, Commande>();
                        List<ligneCommande> lineCommandes = new List<ligneCommande>();

                        using (var reader = new StreamReader(Ds.FileName))
                        {
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();
                                if (line.Trim().Length != 0 && !line.Contains("affectée") && !line.Contains("affected") && !line.Contains("Codecommande"))
                                {
                                    if (!commandes.ContainsKey(int.Parse(line.Split(',')[0])))
                                    {
                                        commandes.Add(int.Parse(line.Split(',')[0]), new Commande(
                                            int.Parse(line.Split(',')[0]),
                                            DateTime.Parse(line.Split(',')[1]),
                                            int.Parse(line.Split(',')[3])
                                            ));
                                    }
                                    lineCommandes.Add(new ligneCommande(
                                        int.Parse(line.Split(',')[0].Trim()),
                                        int.Parse(line.Split(',')[6].Trim()),
                                        int.Parse(line.Split(',')[7].Trim())
                                        ));
                                }
                            }
                        }

                        SqlServer_Classes.ExecuteQuery("insert into MiseA_Jour values(DeFAULT)");

                        int CodeMAJ = int.Parse(SqlServer_Classes.ExecuteScalar("select IDENT_CURRENT('MiseA_Jour')").ToString());

                        List<SqlParameter> parameters = new List<SqlParameter>();

                        foreach (Commande commande in commandes.Values)
                        {
                            parameters.Clear();
                            parameters.Add(new SqlParameter("@dateComm", commande.DateCommande));
                            parameters.Add(new SqlParameter("@codeDepot", Program.CodeDepot));
                            parameters.Add(new SqlParameter("@CodeClient", commande.CodeClient));
                            parameters.Add(new SqlParameter("@numMAJ", CodeMAJ));
                            SqlServer_Classes.ExecuteQuery("insert into Commande values(@dateComm, @codeDepot, @CodeClient, @numMAJ)", parameters);

                            int CodeCommande = int.Parse(SqlServer_Classes.ExecuteScalar("select IDENT_CURRENT('Commande')").ToString());

                            foreach (ligneCommande ligneCommande in lineCommandes)
                            {
                                if (ligneCommande.CodeCommande == commande.CodeCommande)
                                {
                                    parameters.Clear();
                                    parameters.Add(new SqlParameter("@codeComm", CodeCommande));
                                    parameters.Add(new SqlParameter("@codeProduit", ligneCommande.CodeProduit));
                                    parameters.Add(new SqlParameter("@Qte", ligneCommande.Qte));
                                    SqlServer_Classes.ExecuteQuery("insert into ligneCommande values(@codeComm, @codeProduit, @Qte)", parameters);
                                }
                            }
                        }
                        loadDataMAJ();
                        MessageBox.Show("la mise à jour a bien été effectué de la base de donnée", "Opération Terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (IOException exept)
            {
                MessageBox.Show(exept.Message, "Un Erreur a été survenue lors de l'ouverture et lecture du fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadDataMAJ()
        {
            object o = SqlServer_Classes.ExecuteScalar("select idMAJ from MiseA_Jour order by DateMAJ desc");

            if (o != null)
            {
                DateTime dateM = DateTime.Parse(SqlServer_Classes.ExecuteScalar("select DateMAJ from MiseA_Jour where idMAJ = '" + int.Parse(o.ToString()) + "'").ToString());
                lblLastMAJ.Text = dateM.ToString("ddd dd/MM/yyyy à HH:mm");
                int Progress = SqlServer_Classes.getProgress(int.Parse(o.ToString()));
                lblProgress.Text = Progress + " %";
                progressMAJ.Value = Progress;
            }
            else
            {
                lblLastMAJ.Text = "Aucune mise à jour n'a été effectué";
                lblProgress.Text = "0 %";
                progressMAJ.Value = 0;
            }
        }

        private void MAJ_UC_Load(object sender, EventArgs e)
        {
            loadDataMAJ();
        }
    }
}
