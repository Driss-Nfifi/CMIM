using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Facturation.Models
{
    class Product
    {
        private int codeProduct;
        private string designation;
        private int qStock;
        private decimal price;
        private string unite;

        public Product(int codeProduct, string designation, int qStock, decimal price, string unite)
        {
            this.codeProduct = codeProduct;
            this.designation = designation;
            this.qStock = qStock;
            this.price = price;
            this.unite = unite;
        }
        public Product(Product P)
        {
            this.CodeProduct = P.CodeProduct;
            this.Designation = P.Designation;
            this.QStock = P.QStock;
            this.Price = P.Price;
            this.Unite = P.Unite;
        }


        public int CodeProduct { get => codeProduct; set => codeProduct = value; }
        public string Designation { get => designation; set => designation = value; }
        public int QStock { get => qStock; set => qStock = value; }
        public decimal Price { get => price; set => price = value; }
        public string Unite { get => unite; set => unite = value; }
    }
}
