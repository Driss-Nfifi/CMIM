using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Facturation.Models
{
    class ligneCommande
    {

        private int codeCommande;
        private int codeProduit;
        private int qte;

        public ligneCommande(int codeCommande, int codeProduit, int qte)
        {
            CodeCommande = codeCommande;
            CodeProduit = codeProduit;
            Qte = qte;
        }

        public int CodeCommande { get => codeCommande; set => codeCommande = value; }
        public int CodeProduit { get => codeProduit; set => codeProduit = value; }
        public int Qte { get => qte; set => qte = value; }
    }
}
