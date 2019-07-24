using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itshort.Models
{
    class Client
    {
       private int CodeClient;
       private string Cin, Nom, Prenom, Tel, Adresse, Email;

        public Client(int codeClient, string cin, string nom, string prenom, string tel, string adresse, string email)
        {
            CodeClient1 = codeClient;
            Cin1 = cin;
            Nom1 = nom;
            Prenom1 = prenom;
            Tel1 = tel;
            Adresse1 = adresse;
            Email1 = email;
        }

        public int CodeClient1 { get => CodeClient; set => CodeClient = value; }
        public string Cin1 { get => Cin; set => Cin = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public string Tel1 { get => Tel; set => Tel = value; }
        public string Adresse1 { get => Adresse; set => Adresse = value; }
        public string Email1 { get => Email; set => Email = value; }
    }
}
