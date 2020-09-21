using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.IO;

namespace tp01web
{
    class Book
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public Author[] Authors { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book(string name,Author[] author,double price)
        {
            Name = name;
            Authors = author;
            Price = price;
            Qty = 0;
           
        }
        public Book(string name, Author[] author, double price,int qty)
        {
            Name = name;
            Authors = author;
            Price = price;
            Qty = qty;
        }

        public override string ToString()
        {
            var arquivoCSV = new StringBuilder();
            arquivoCSV.AppendLine($"{Name}");
            arquivoCSV.AppendLine($"Authors");


            foreach (Author a in Authors)
            {

                arquivoCSV.AppendLine($"{ a.Name}  {a.Email} { a.Gender}");


            }
            arquivoCSV.AppendLine($"  {Email}");
            arquivoCSV.AppendLine($"  {Price}");
            arquivoCSV.AppendLine($"  {Qty}");

            return arquivoCSV.ToString();
        }
        public string getAuthorNames()
        {
            string aux ="";
            
            foreach (Author a in Authors)
            {

                aux += a.Name+"-";
                
              
            }
            return aux;
                  

        }
    }
}
