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

namespace Itshort.UserControll.LivraisonUc
{
    public partial class CreationLiv : UserControl
    {
        public CreationLiv()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        SqlDataReader read;
        DataTable t = new DataTable();
        private void CreationLiv_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                com.CommandText = "select CodeLivr,CodeChargement,Datelivraison from Livraison";
                this.panel2.Controls.Clear();
                Title fact = new Title();
                fact.Dock = DockStyle.Top;
                this.panel2.Controls.Add(fact);
                fact.BringToFront();
                read = com.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        Ligne ligne = new Ligne(int.Parse(read[0].ToString()), int.Parse(read[1].ToString()), (DateTime)read[2]);
                        ligne.Dock = DockStyle.Top;
                        this.panel2.Controls.Add(ligne);
                        ligne.BringToFront();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
