using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Project_Facturation.Project_UC.Commande_Component;

namespace Project_Facturation.Models
{
    class SqlServer_Classes
    {
        private static SqlConnection Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
        private static SqlCommand Command;
        private static SqlDataReader reader;
        private static DataTable dt;
        private static SqlDataAdapter adapter;

        public static void ExecuteQuery(string Query)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Query, Connection);
                Command.ExecuteNonQuery();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur S'est Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }

        public static void ExecuteQuery(string Query, SqlParameter[] parameters)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddRange(parameters);
                Command.ExecuteNonQuery();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur S'est Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }

        public static void ExecuteQuery(string Query, List<SqlParameter> parameters)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Query, Connection);
                foreach(SqlParameter para in parameters)
                {
                    Command.Parameters.Add(para);
                }
                Command.ExecuteNonQuery();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur S'est Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }

        public static void ExecuteQuery(string Query, SqlParameter[] parameters, string Message, string Title)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddRange(parameters);
                Command.ExecuteNonQuery();
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur S'est Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }

        public static object ExecuteScalar(string Query)
        {
            object result = null;
            try
            {
                Connection.Open();
                Command = new SqlCommand(Query, Connection);
                result = Command.ExecuteScalar();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur S'est Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
            return result;
        }

        public static int getProgress(int CodeMAJ)
        {
            int result = 0;
            try
            {
                Connection.Open();
                Command = new SqlCommand(@"select distinct Cast([dbo].[getCount](Commande.numMAJ) as Float) / Cast([dbo].[getCountCommandeFromMAJ](@CodeMAJ) as float) * 100
                as Progress from Commande 
                left join Charge_Commande on Charge_Commande.CodeCommande = Commande.Codecommande
                where numMAJ is not null and CodeChargement is not null and numMAJ = @CodeMAJ", Connection);
                Command.Parameters.AddWithValue("@CodeMAJ", CodeMAJ);
                if(Command.ExecuteScalar() != null)
                    result = int.Parse(Command.ExecuteScalar().ToString());
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur S'est Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
            return result;
        }

        public static DataTable executeAndReturnTable(string Query)
        {
            try
            {
                dt = new DataTable();
                Connection.Open();
                Command = new SqlCommand(Query, Connection);
                reader = Command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            catch (Exception)
            {
                //return Err.Message;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static Dictionary<int, Product> getAllProducts(string condition, SqlParameter para)
        {
            Dictionary<int, Product> listDesProduits = new Dictionary<int, Product>();
            try
            {
                Connection.Open();
                Command = new SqlCommand("select* from Produit where " + condition, Connection);
                if (para != null)
                    Command.Parameters.Add(para);
                reader = Command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        listDesProduits.Add(reader.GetInt32(0), new Product(reader.GetInt32(0), reader.GetString(1),
                            reader.GetInt32(2), reader.GetDecimal(3), reader.GetString(4)));
                    }
                    reader.Close();
                }
            }
            catch(Exception)
            {

            }
            finally
            {
                Connection.Close();
            }
            return listDesProduits;
        }

        public static DataSet getBonCommande(int CodeCommande)
        {
            DataSet set = new DataSet();
            try
            {
                adapter = new SqlDataAdapter("select * from Client where CodeClient in (select CodeClient from Commande where Codecommande = '" + CodeCommande+"')", Connection);
                adapter.Fill(set, "Client");
                adapter = new SqlDataAdapter("select * from Commande where Codecommande = '" + CodeCommande + "'", Connection);
                adapter.Fill(set, "Commande");
                adapter = new SqlDataAdapter("select * from LigneCommande where Codecomm = '" + CodeCommande + "'", Connection);
                adapter.Fill(set, "ligneCommande");
                adapter = new SqlDataAdapter("select * from Produit where CodeProduit in (select CodeProduit from ligneCommande where Codecomm = '" + CodeCommande + "')", Connection);
                adapter.Fill(set, "Produit");
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return set;
        }

        public static DataSet getBonChargement(int CodeChargement)
        {
            DataSet Data_Set = new DataSet();
            try
            {
                /*adapter = new SqlDataAdapter("select distinct * from Chargement where CodeChargement = '" + CodeChargement + "'", Connection);
                adapter.Fill(Data_Set, "Chargement");

                adapter = new SqlDataAdapter("select distinct * from Charge_Commande where CodeChargement = '" + CodeChargement + "'", Connection);
                adapter.Fill(Data_Set, "Charge_Commande");

                adapter = new SqlDataAdapter("select Distinct Camion.* from Camion inner join Chargement on Chargement.CodeCamion = Camion.codecamm where CodeChargement = '"+CodeChargement+"'", Connection);
                adapter.Fill(Data_Set, "Camion");

                adapter = new SqlDataAdapter("select Distinct Chauffeur.* from Chauffeur inner join Chargement on Chargement.CodeChauf = Chauffeur.CodeChauffeur where CodeChargement = '" + CodeChargement + "'", Connection);
                adapter.Fill(Data_Set, "Chauffeur");

                adapter = new SqlDataAdapter(@"select Client.* from Client inner join Commande on Commande.CodeClient = Client.Codeclient
                inner join Charge_Commande on Charge_Commande.CodeCommande = Commande.Codecommande
                inner join Chargement on Charge_Commande.CodeChargement = Chargement.CodeChargement
                where Chargement.CodeChargement = '"+CodeChargement+"'", Connection);
                adapter.Fill(Data_Set, "Client");

                adapter = new SqlDataAdapter(@"select Produit.* from Produit
                inner join Charge_Commande on Charge_Commande.CodeProduit = Produit.CodeProduit
                where Charge_Commande.CodeChargement = '"+CodeChargement+"'", Connection);
                adapter.Fill(Data_Set, "Produit");

                adapter = new SqlDataAdapter(@"select distinct Commande.* from Commande
                inner join Charge_Commande on Charge_Commande.CodeCommande = Commande.Codecommande
                where Charge_Commande.CodeChargement = '" + CodeChargement + "'", Connection);
                adapter.Fill(Data_Set, "Commande");

                adapter = new SqlDataAdapter(@"select distinct ligneCommande.* from ligneCommande
                inner join Charge_Commande on Charge_Commande.CodeProduit = ligneCommande.CodeProduit
                where Codecomm in (select CodeCommande from Charge_Commande
                where Charge_Commande.CodeChargement = '" + CodeChargement + "')", Connection);
                adapter.Fill(Data_Set, "ligneCommande");*/

            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Data_Set;
        }

        public static void ConfirmerChargement_Commande(int CodeCommande, int CodeChauffeur, int CodeCamion)
        {
            try
            {
                string CodeTour = DateTime.Now.Year + "" + CodeCommande;
                int CodeTournee = int.Parse(CodeTour);

                ExecuteQuery("insert into Tournee values(@CodeTournee, @DateTournee)", new SqlParameter[] { new SqlParameter("@DateTournee", DateTime.Now), new SqlParameter("@CodeTournee", CodeTournee) });
                SqlParameter[] parametre = new SqlParameter[]
                     {
                                new SqlParameter("@CodeChauf", CodeChauffeur),
                                new SqlParameter("@CodeCamion", CodeCamion),
                                new SqlParameter("@CodeTournee", CodeTournee)
                                
                     };

                ExecuteQuery("update Commande set numTournee = @CodeTournee where Codecommande = @CodeComm", new SqlParameter[]
                {
                    new SqlParameter("CodeTournee", CodeTournee),
                    new SqlParameter("@CodeComm", CodeCommande)
                });

                ExecuteQuery("insert into Chargement(CodeChauf, CodeCamion, CodeTournee) values(@CodeChauf, @CodeCamion, @CodeTournee)", parametre);

                int CodeChargement = int.Parse(ExecuteScalar("select IDENT_CURRENT('Chargement')").ToString());

                DataSet Data_Set = getBonChargement(CodeChargement);

                BonDeChargement reportCommande = new BonDeChargement();
                reportCommande.SetDataSource(Data_Set);

                Report_Viewer_Form frm = new Report_Viewer_Form();
                frm.Text = "Bon De Chargement N°: " + CodeChargement + " pour la commande N°: " + CodeCommande;
                frm.crystalReportViewer1.ReportSource = reportCommande;
                frm.Show();

            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataSet getBonLivraison(int CodeLivraison)
        {
            DataSet set = new DataSet();
            try
            {
                adapter = new SqlDataAdapter("select * from Livraison where CodeLivr=" + CodeLivraison, Connection);
                adapter.Fill(set, "Livraison");
               /* adapter = new SqlDataAdapter("select cha.* from Charge_Commande as cha inner join Chargement as ch on ch.CodeChargement=cha.CodeChargement inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + CodeLivraison, Connection);
                adapter.Fill(set, "Charge_Commande"); */
                adapter = new SqlDataAdapter("select ch.* from Chargement as ch  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + CodeLivraison, Connection);
                adapter.Fill(set, "Chargement");
                adapter = new SqlDataAdapter("select chau.* from chauffeur as chau  inner join Chargement as ch on chau.CodeChauffeur=ch.CodeChauf  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + CodeLivraison, Connection);
                adapter.Fill(set, "Chauffeur");
                adapter = new SqlDataAdapter("select C.* from Commande as C inner Join Charge_Commande as char on C.Codecommande=char.CodeCommande  inner join Chargement as ch on ch.CodeChargement=char.CodeChargement  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + CodeLivraison, Connection);
                adapter.Fill(set, "Commande");
                adapter = new SqlDataAdapter("select Cli.* from Client as Cli inner join Commande as C on Cli.Codeclient=C.CodeClient inner Join Charge_Commande as char on C.Codecommande=char.CodeCommande  inner join Chargement as ch on ch.CodeChargement=char.CodeChargement  inner Join Livraison as l on l.CodeChargement=ch.CodeChargement where l.CodeLivr=" + CodeLivraison, Connection);
                adapter.Fill(set, "Client");
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return set;
        }

        public static void LivrerCommande_Print(int CodeCommande)
        {
            try
            {
                int CodeTournee = int.Parse(ExecuteScalar("select numTournee from Commande where Codecommande = '" + CodeCommande + "'").ToString());
                int CodeChargement = int.Parse(ExecuteScalar("select CodeChargement from Chargement where CodeTournee = '"+CodeTournee+"'").ToString());
                ExecuteQuery("insert into Livraison(CodeChargement) values('" + CodeChargement + "')");
                int CodeLivraison = int.Parse(ExecuteScalar("select IDENT_CURRENT('Livraison')").ToString());

                DataSet Data_Set = getBonLivraison(CodeLivraison);

                BonLivraison reportCommande = new BonLivraison();
                reportCommande.SetDataSource(Data_Set);

                Report_Viewer_Form frm = new Report_Viewer_Form();
                frm.Text = "Bon De Livraison N°: " + CodeLivraison + " pour la commande N°: " + CodeCommande;
                frm.crystalReportViewer1.ReportSource = reportCommande;
                frm.Show();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataSet getFacture(int CodeCommande)
        {
            DataSet set = new DataSet();
            try
            {
                adapter = new SqlDataAdapter("select * from Facture where CodeComm=" + CodeCommande, Connection);
                adapter.Fill(set, "Facture");
                adapter = new SqlDataAdapter("select * from Commande as C inner Join Facture as F on C.Codecommande=F.CodeComm where F.CodeComm=" + CodeCommande, Connection);
                adapter.Fill(set, "Commande");
                adapter = new SqlDataAdapter("select * from Client as Cl inner join Commande as C on C.CodeClient=Cl.Codeclient inner Join Facture as F on C.Codecommande=F.CodeComm where F.CodeComm=" + CodeCommande, Connection);
                adapter.Fill(set, "Client");
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return set;
        }

        public static void FacturerCommande_Print(int CodeCommande)
        {
            try
            {
                int CodeFacture = int.Parse(ExecuteScalar("select CodeFacture from Facture where CodeComm = '" + CodeCommande + "'").ToString());

                DataSet Data_Set = getFacture(CodeCommande);

                Facturation reportCommande = new Facturation();
                reportCommande.SetDataSource(Data_Set);

                Report_Viewer_Form frm = new Report_Viewer_Form();
                frm.Text = "Facture N°: " + CodeFacture + " pour la commande N°: " + CodeCommande;
                frm.crystalReportViewer1.ReportSource = reportCommande;
                frm.Show();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un Erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
