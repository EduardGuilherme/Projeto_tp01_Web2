using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace tp01web
{
    class Book
    {
        
        public string Name { get; set; }
        public Author[] Authors { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book(string _name,Author[] _author,double _price)
        {
            Name = _name;
            Authors = _author;
            Price = _price;
            Qty = 0;
           
        }
        public Book(string _name, Author[] _author, double _price,int _qty)
        {
            Name = _name;
            Authors = _author;
            Price = _price;
            Qty = _qty;
        }

        public override string ToString()
        {
            string aux = "";

            foreach (Author a in Authors)
            {

                aux += "\n"+a.Name + "|"+a.Email+"|"+a.Gender+"|\n";


            }
          
            return $" \n{Name}\n{aux}|{Price}|{Qty}";
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
