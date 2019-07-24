using Itshort;
using Itshort.UserControll;
using Project_Facturation.Project_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Facturation
{
    public partial class Form1 : Form
    {
        bool isCharged = false;
        UserControl UC;

        public Form1()
        {
            InitializeComponent();
            toolTipButtons.SetToolTip(btnClose, "Fermer L'application");
            toolTipButtons.SetToolTip(btnMinimize, "Réduire");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
        }
    
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(isCharged)
            {
                if (this.WindowState == FormWindowState.Maximized)
                    toolTipButtons.SetToolTip(btnMaximize, "Rétablir Précedent");
                else
                    toolTipButtons.SetToolTip(btnMaximize, "Agrandir");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            isCharged = true;
        }

        private void setBackColor(Button B)
        {
            B.BackColor = Color.FromArgb(146, 211, 109);
            foreach(Control C in panelMenu.Controls)
            {
                if(C is Button)
                {
                    if(C != B)
                        C.BackColor = Color.White;
                }
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC = new Command_UC();
            UC.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(UC);
            setBackColor(btnCommande);
        }

        private void btnMAJ_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC = new MAJ_UC();
            UC.Dock = DockStyle.Fill;
            setBackColor(btnMAJ);
            panelContainer.Controls.Add(UC);
            setBackColor(btnMAJ);
        }

        private void btnLivraison_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Livraison liv = new Livraison();
            this.panelContainer.Controls.Add(liv);
            liv.Dock = DockStyle.Fill;
            liv.BringToFront();
            setBackColor(btnLivraison);
        }

        private void btnFacturation_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            setBackColor(btnFacturation);
            Facture fac = new Facture();
            this.panelContainer.Controls.Add(fac);
            fac.Dock = DockStyle.Fill;
            fac.BringToFront();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRessources_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Resources fac = new Resources();
            this.panelContainer.Controls.Add(fac);
            fac.Dock = DockStyle.Fill;
            fac.BringToFront();
            setBackColor(btnRessources);
        }
    }
}
