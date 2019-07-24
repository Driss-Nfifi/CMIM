using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itshort.Models
{
    class Chauffeur
    {
        private int CodeChauffeur;
        private string CIN, Nom, PreNom;

        public Chauffeur(int codeChauffeur, string cIN, string nom, string preNom)
        {
            CodeChauffeur1 = codeChauffeur;
            CIN1 = cIN;
            Nom1 = nom;
            PreNom1 = preNom;
        }

        public int CodeChauffeur1 { get => CodeChauffeur; set => CodeChauffeur = value; }
        public string CIN1 { get => CIN; set => CIN = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string PreNom1 { get => PreNom; set => PreNom = value; }
    }
}
