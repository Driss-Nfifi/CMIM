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
    public partial class Add_Commande_UC : UserControl
    {
        private Dictionary<int, Product> listProduits;
        public int usedProduct = -1;
        AddedProduct_UC uc;

        internal Dictionary<int, Product> ListProduits { get => listProduits; set => listProduits = value; }

        public Add_Commande_UC()
        {
            InitializeComponent();
        }

        private void txtDateOperation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Add_Commande_UC_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdd, "Ajouter Le Produit à la liste des achats");
            toolTip1.SetToolTip(btnValidateCommande, "Valider La Commande");

            txtDateOperation.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm");
            cmbClient.DataSource = SqlServer_Classes.executeAndReturnTable("select Codeclient, Cin + ' : ' + Upper(Nom) + ' ' + Lower(Prenom) as Name from Client order by Nom Asc, Prenom Asc");
            cmbClient.ValueMember = "Codeclient";
            cmbClient.DisplayMember = "Name";
            Product_UC productItemm;
            ListProduits = SqlServer_Classes.getAllProducts(" 1 = 1", null);

            foreach(Product produit in ListProduits.Values)
            {
                productItemm = new Product_UC(produit.Designation, produit.QStock, produit.Price, produit.Unite);
                productItemm.Name = produit.CodeProduct.ToString();
                panelProduct.Controls.Add(productItemm);
            }
            panelProduct.AutoScroll = false;
            panelProduct.HorizontalScroll.Enabled = false;
            panelProduct.HorizontalScroll.Visible = false;
            panelProduct.HorizontalScroll.Maximum = 0;
            panelProduct.AutoScroll = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public int getPrecedentControl(int ProductCode)
        {
            foreach(AddedProduct_UC uc in panelCommandeProducts.Controls)
            {
                if (uc.lblCodeproduit.Text.Equals(ProductCode.ToString()))
                    return panelCommandeProducts.Controls.IndexOf(uc);
            }
            return -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(usedProduct != -1)
            {
                if (int.Parse(txtQte.Text) > 0)
                {
                    if (getPrecedentControl(usedProduct) == -1)
                    {
                        uc = new AddedProduct_UC(usedProduct, listProduits[usedProduct].Designation, int.Parse(txtQte.Text), listProduits[usedProduct].Unite, listProduits[usedProduct].Price * int.Parse(txtQte.Text));
                        uc.Dock = DockStyle.Top;
                        panelCommandeProducts.Controls.Add(uc);
                    }
                    else
                    {
                        uc = (AddedProduct_UC)panelCommandeProducts.Controls[getPrecedentControl(usedProduct)];
                        uc.lblQteCommande.Text = (int.Parse(uc.lblQteCommande.Text.Split(' ')[0]) + int.Parse(txtQte.Text)).ToString() + " " + uc.lblQteCommande.Text.Split(' ')[1];
                        uc.lblMontant.Text = string.Format("{0:0.00} Dhs", int.Parse(uc.lblQteCommande.Text.Split(' ')[0]) * listProduits[int.Parse(uc.lblCodeproduit.Text)].Price);
                        lblMontantTotal.Text = string.Format("{0:0.00} Dhs", getMontantTotal());
                    }
                    txtProduct.ResetText();
                    txtQte.Text = "0";
                    usedProduct = -1;
                }
                else
                    MessageBox.Show("Veuillez Saisir une quantité supérieur à 0", "Quantité invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isInteger(string caracetere)
        {
            try
            {
                if(int.TryParse(caracetere, out int result))
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception)
            {
                return false;
            }
        }

        private decimal getMontantTotal()
        {
            decimal price = 0;
            foreach(AddedProduct_UC uc in panelCommandeProducts.Controls)
            {
                price += decimal.Parse(uc.lblMontant.Text.Split(' ')[0]);
            }
            return price;
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar))
            {
                if (!isInteger(e.KeyChar.ToString()))
                    e.Handled = true;
            }
        }

        private void panelCommandeProducts_ControlAdded(object sender, ControlEventArgs e)
        {
            lblMontantTotal.Text = string.Format("{0:0.00} Dhs", getMontantTotal());
            panelCommandeProducts.AutoScroll = false;
            panelCommandeProducts.HorizontalScroll.Enabled = false;
            panelCommandeProducts.HorizontalScroll.Visible = false;
            panelCommandeProducts.HorizontalScroll.Maximum = 0;
            panelCommandeProducts.AutoScroll = true;
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (panelCommandeProducts.Controls.Count == 0)
            {
                panelCommandeProducts.Controls.Clear();
                txtDateOperation.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm");
            }
            else
            {
                DialogResult result = MessageBox.Show("En cas de confirmation de ce message, vous perdez tous les commandes effectué au client précédent", "Message De Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    createAnotherCommande();
            }*/
        }

        private void btnValidateCommande_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedIndex != -1)
            {
                if (panelCommandeProducts.Controls.Count > 0)
                {
                    DialogResult result = MessageBox.Show("En cas de validation de ce message, la commande sera confirmé et affecté au client", "Message De Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SqlParameter[] parametres = new SqlParameter[]
                        {
                            new SqlParameter("@DateCommande", DateTime.Now),
                            new SqlParameter("@CodeDepot", Program.CodeDepot),
                            new SqlParameter("@CodeClient", cmbClient.SelectedValue)
                        };
                        SqlServer_Classes.ExecuteQuery("insert into Commande(DateCommande, CodeDepot, CodeClient) values(@DateCommande, @CodeDepot, @CodeClient)", parametres);
                        int CodeCommande = int.Parse(SqlServer_Classes.ExecuteScalar("select IDENT_Current('Commande')").ToString());
                        foreach (AddedProduct_UC uc in panelCommandeProducts.Controls)
                        {
                            parametres = new SqlParameter[]
                            {
                                 new SqlParameter("@CodeComm", CodeCommande),
                                new SqlParameter("@CodeProduit", uc.lblCodeproduit.Text),
                                new SqlParameter("@Qte", int.Parse(uc.lblQteCommande.Text.Split(' ')[0]))
                            };
                            SqlServer_Classes.ExecuteQuery("insert into ligneCommande values(@CodeComm, @CodeProduit, @Qte)", parametres);
                        }

                        parametres = new SqlParameter[]
                        {
                            new SqlParameter("@CodeComm", CodeCommande),
                            new SqlParameter("@dateComm", DateTime.Now),
                            new SqlParameter("@Mt", getMontantTotal())
                        };
                        SqlServer_Classes.ExecuteQuery("insert into Facture values(@CodeComm, @dateComm, @Mt)", parametres);

                        MessageBox.Show("La Commande N°: " + CodeCommande + " Du Client: " + cmbClient.Text + " a bien été Ajouter", "Commande ajouter avec succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        DialogResult resultChar = MessageBox.Show("Voulez-vous effectuer les opérations sur la commande N°= " + CodeCommande + " ?", "Message De Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(resultChar == DialogResult.Yes)
                        {
                            Choices_After_Commande frm = new Choices_After_Commande(CodeCommande);
                            frm.ShowDialog(this);
                        }
                        createAnotherCommande();
                    }
                }
                else
                    MessageBox.Show("Cette commande ne contient aucun produit, veuillez les ajouter", "Commande contient pas des produits", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Veuillez Sélectionner Le Client Qui a effectué la commande", "Aucun client n'a été sélectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void createAnotherCommande()
        {
            txtDateOperation.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm");
            panelCommandeProducts.Controls.Clear();
        }

        private void txtSearchProduct_TextChanged_1(object sender, EventArgs e)
        {
            Product_UC productItemm;
            panelProduct.Controls.Clear();
            SqlParameter para = new SqlParameter("@Designation", "%" + txtSearchProduct.Text + "%");
            ListProduits = SqlServer_Classes.getAllProducts(" Designation like @Designation", para);
            foreach (Product produit in ListProduits.Values)
            {
                productItemm = new Product_UC(produit.Designation, produit.QStock, produit.Price, produit.Unite);
                productItemm.Name = produit.CodeProduct.ToString();
                panelProduct.Controls.Add(productItemm);
            }
            panelProduct.AutoScroll = false;
            panelProduct.HorizontalScroll.Enabled = false;
            panelProduct.HorizontalScroll.Visible = false;
            panelProduct.HorizontalScroll.Maximum = 0;
            panelProduct.AutoScroll = true;
        }

        

        private void ConfirmerChargement_PrintBonChargement(int CodeCommande)
        {

        }

    }
}