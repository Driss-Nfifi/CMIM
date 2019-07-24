using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itshort.Models;
using System.IO;
using System.Data.SqlClient;

namespace Itshort
{
    public partial class Resources : UserControl
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SqlCommand command;
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);

        public Resources()
        {
            InitializeComponent();
            ofd.Filter = "Fichier CSV | *CSV";
            ofd.Multiselect = false;
        }

        private void ExecuteQuery(string requete, SqlParameter[] parameters)
        {
            try
            {
                con.Open();
                command = new SqlCommand(requete, con);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message, "Un erreur s'est produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private object ExecuteScalar(string requete)
        {
            object o = null;
            try
            {
                con.Open();
                command = new SqlCommand(requete, con);
                o = command.ExecuteScalar();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Un erreur s'est produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return o;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MiseClient_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Dictionary<int, Client> listClient = new Dictionary<int, Client>();
                    using (var reader = new StreamReader(ofd.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (line.Trim().Length != 0 && !line.Contains("row") && !line.Contains("ligne") && !line.Contains("Codeclient"))
                            {
                                if (!listClient.ContainsKey(int.Parse(line.Split(',')[0])))
                                {
                                    listClient.Add(int.Parse(line.Split(',')[0]), new Client(int.Parse(line.Split(',')[0]),
                                        line.Split(',')[1], line.Split(',')[2], line.Split(',')[3], line.Split(',')[4], line.Split(',')[5], line.Split(',')[6]));
                                }
                            }
                        }
                        
                          foreach (Client C in listClient.Values)
                         {
                             string commande = @"if(not exists(select * from Client where Codeclient = @CodeClient)) 
                                             insert into Client values(@CodeClient, @Cin, @Nom, @prenom, @tel, @adresse, @email)
                                             else
                                             update Client set Nom = @Nom, Prenom = @prenom, Tel = @tel, Adresse = @adresse, Email = @email where Codeclient= @CodeClient";
                             SqlParameter[] parameters = new SqlParameter[]
                             {
                             new SqlParameter("@CodeClient", C.CodeClient1),
                             new SqlParameter("@Cin", C.Cin1),
                             new SqlParameter("@Nom", C.Nom1),
                             new SqlParameter("@prenom", C.Prenom1),
                             new SqlParameter("@tel", C.Tel1),
                             new SqlParameter("@adresse", C.Adresse1),
                             new SqlParameter("@email", C.Email1)
                             };
                             ExecuteQuery(commande, parameters);
                         }
                        MessageBox.Show("Mise à jour des clients a bien été effectué", "Mise à jour effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ExecuteQuery("insert into MAJ_Ressource(TypeM) values('Client')", null);
                        load();
                        
                    }
                }
                catch(Exception Err)
                {
                    MessageBox.Show(Err.Message, "Un erreur s'est produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void load()
        {
            object o = ExecuteScalar("select top 1 DateMAJ from MAJ_Ressource where TypeM = 'Client' order by DateMAJ desc");
            if(o != null)
            {
                lblD_Client.Text = DateTime.Parse(o.ToString()).ToString("ddd dd/MM/yyyy HH:mm");
            }

            o = ExecuteScalar("select top 1 DateMAJ from MAJ_Ressource where TypeM = 'Produit' order by DateMAJ desc");
            if (o != null)
            {
                lblD_Produit.Text = DateTime.Parse(o.ToString()).ToString("ddd dd/MM/yyyy HH:mm");
            }

            o = ExecuteScalar("select top 1 DateMAJ from MAJ_Ressource where TypeM = 'Camion' order by DateMAJ desc");
            if (o != null)
            {
                lblD_Camion.Text = DateTime.Parse(o.ToString()).ToString("ddd dd/MM/yyyy HH:mm");
            }
            o = ExecuteScalar("select top 1 DateMAJ from MAJ_Ressource where TypeM = 'Chauffeur' order by DateMAJ desc");
            if (o != null)
            {
                lbl_DChauffaure.Text = DateTime.Parse(o.ToString()).ToString("ddd dd/MM/yyyy HH:mm");
            }

            o = ExecuteScalar("select top 1 DateMAJ from MAJ_Ressource order by DateMAJ desc");
            if (o != null)
            {
                lblLastMAJ.Text = DateTime.Parse(o.ToString()).ToString("ddd dd/MM/yyyy HH:mm");
            }
        }

        private void Resources_Load(object sender, EventArgs e)
        {
            load();
        }

        private void MiseAjourButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Dictionary<int, Produit> listClient = new Dictionary<int, Produit>();
                    using (var reader = new StreamReader(ofd.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (line.Trim().Length != 0 && !line.Contains("row") && !line.Contains("ligne") && !line.Contains("CodeProduit"))
                            {
                                if (!listClient.ContainsKey(int.Parse(line.Split('|')[0])))
                                {
                                    listClient.Add(int.Parse(line.Split('|')[0]), new Produit(int.Parse(line.Split('|')[0]), line.Split('|')[1], int.Parse(line.Split('|')[2]),decimal.Parse(line.Split('|')[3]), line.Split('|')[4]));
                                }
                            }
                        }

                        foreach (Produit P in listClient.Values)
                        {
                            string commande = @"if(not exists(select * from Produit where CodeProduit=@Codeprod))
                                             insert into Produit(CodeProduit, Designation, QStock, PrixUnitaire, Unite) values(@Codeprod,@desi,@qst,@prix,@unite)
                                             else
                                             update Produit set Designation= @desi, Qstock = @qst, PrixUnitaire= @prix, Unite = @unite where CodeProduit=@Codeprod";
                            SqlParameter[] parameters = new SqlParameter[]
                            {
                             new SqlParameter("@Codeprod",P.CodeProduit1),
                             new SqlParameter("@desi", P.Designation1),
                             new SqlParameter("@prix", P.PrixUnitaire1),
                             new SqlParameter("@unite", P.Unite1),
                             new SqlParameter("@qst",P.Qstock1)
                            };
                            ExecuteQuery(commande, parameters);
                        }
                        MessageBox.Show("Mise à jour des produit a bien été effectué", "Mise à jour effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ExecuteQuery("insert into MAJ_Ressource(TypeM) values('Produit')", null);
                        load();
                    }
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message, "Un erreur s'est produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MiseAjourCamion_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Dictionary<int, Camion> listClient = new Dictionary<int, Camion>();
                    using (var reader = new StreamReader(ofd.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (line.Trim().Length != 0 && !line.Contains("row") && !line.Contains("ligne") && !line.Contains("codecamm"))
                            {
                                if (!listClient.ContainsKey(int.Parse(line.Split(',')[0])))
                                {
                                    listClient.Add(int.Parse(line.Split(',')[0]), new Camion(int.Parse(line.Split(',')[0]), line.Split(',')[1], line.Split(',')[2],int.Parse(line.Split(',')[3])));
                                }
                            }
                        }

                        foreach (Camion C in listClient.Values)
                        {
                            string commande = @"if(not exists(select * from Camion where codecamm=@Codecom))
                                             insert into Camion values(@Codecom,@matri,@matr,@mode)
                                             else
                                             update Camion set Matricule=@matri,Marque=@matr,Modele=@mode where codecamm=@Codecom";
                            SqlParameter[] parameters = new SqlParameter[]
                            {
                             new SqlParameter("@Codecom",C.Codecamm),
                             new SqlParameter("@matri", C.Matricule1),
                             new SqlParameter("@matr", C.Marque1),
                             new SqlParameter("@mode", C.Modele1),
                            };
                            ExecuteQuery(commande, parameters);
                        }
                        MessageBox.Show("Mise à jour des Camion a bien été effectué", "Mise à jour effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ExecuteQuery("insert into MAJ_Ressource(TypeM) values('Camion')", null);
                        load();

                    }
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message, "Un erreur s'est produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MiseAjourChauffeur_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Dictionary<int, Chauffeur> listClient = new Dictionary<int, Chauffeur>();
                    using (var reader = new StreamReader(ofd.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (line.Trim().Length != 0 && !line.Contains("row") && !line.Contains("ligne") && !line.Contains("CodeChauffeur"))
                            {
                                if (!listClient.ContainsKey(int.Parse(line.Split(',')[0])))
                                {
                                    listClient.Add(int.Parse(line.Split(',')[0]), new Chauffeur(int.Parse(line.Split(',')[0]), line.Split(',')[1], line.Split(',')[2],line.Split(',')[3]));
                                }
                            }
                        }

                        foreach (Chauffeur C in listClient.Values)
                        {
                            string commande = @"if(not exists(select * from Chauffeur where CodeChauffeur=@Codech))
                                             insert into Chauffeur values(@Codech,@cin,@nom,@pren)
                                             else
                                             update Chauffeur set Nom=@nom,PreNom=@pren  where CodeChauffeur=@Codech";
                            SqlParameter[] parameters = new SqlParameter[]
                            {
                             new SqlParameter("@Codech",C.CodeChauffeur1),
                             new SqlParameter("@cin", C.CIN1),
                             new SqlParameter("@nom", C.Nom1),
                             new SqlParameter("@pren", C.PreNom1),
                            };
                            ExecuteQuery(commande, parameters);
                        }
                        MessageBox.Show("Mise à jour des Chauffeurs a bien été effectué", "Mise à jour effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ExecuteQuery("insert into MAJ_Ressource(TypeM) values('Chauffeur')", null);
                        load();

                    }
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message, "Un erreur s'est produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
