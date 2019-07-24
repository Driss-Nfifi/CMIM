using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itshort.Models
{
    class Camion
    {
        private int codecamm, Modele;
        private string Matricule, Marque;

        public Camion(int codecamm, string matricule, string marque, int modele)
        {
            this.Codecamm = codecamm;
            Modele1 = modele;
            Matricule1 = matricule;
            Marque1 = marque;
        }

        public int Codecamm { get => codecamm; set => codecamm = value; }
        public int Modele1 { get => Modele; set => Modele = value; }
        public string Matricule1 { get => Matricule; set => Matricule = value; }
        public string Marque1 { get => Marque; set => Marque = value; }
    }
}
