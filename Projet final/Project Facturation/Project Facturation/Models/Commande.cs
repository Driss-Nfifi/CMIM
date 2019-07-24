using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Facturation.Models
{
    class Commande
    {
        private int codeCommande;
        private DateTime dateCommande;
        private int codeClient;
       

        public Commande(int codeCommande, DateTime dateCommande, int codeClient)
        {
            CodeCommande = codeCommande;
            DateCommande = dateCommande;
            CodeClient = codeClient;
        }

        public int CodeCommande { get => codeCommande; set => codeCommande = value; }
        public DateTime DateCommande { get => dateCommande; set => dateCommande = value; }
        public int CodeClient { get => codeClient; set => codeClient = value; }
    }
}
