using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itshort.Models
{
    class Produit
    {
        private int CodeProduit, Qstock;
        private string Designation, Unite;
        private decimal PrixUnitaire;

        public Produit(int codeProduit,string designation, int qstock, decimal prixUnitaire,string unite)
        {
            CodeProduit1 = codeProduit;
            Qstock1 = qstock;
            Designation1 = designation;
            Unite1 = unite;
            PrixUnitaire1 = prixUnitaire;
        }

        public int CodeProduit1 { get => CodeProduit; set => CodeProduit = value; }
        public int Qstock1 { get => Qstock; set => Qstock = value; }
        public string Designation1 { get => Designation; set => Designation = value; }
        public string Unite1 { get => Unite; set => Unite = value; }
        public decimal PrixUnitaire1 { get => PrixUnitaire; set => PrixUnitaire = value; }
    }
}
