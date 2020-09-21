using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using tp01web;

namespace tp01web2
{
    class ArquivoCSV
    {
        private static readonly string nomeArquivoCSV = "C:\\Users\\Eduardo\\source\\repos\\tp01web2\\tp01web2\\Autor.csv";
        
        public ArquivoCSV()
        {

        }

        public List<Book> buscarNomes()
        {
            using (var file = File.OpenText(ArquivoCSV.nomeArquivoCSV))
            {
                var lBooks = new List<Book>();
                Author[] authors = new Author[2];
                
                while (!file.EndOfStream)
                {
                    var textBook = file.ReadLine();

                    if (string.IsNullOrEmpty(textBook))
                    {
                        continue;
                    }
                    var infoBook = textBook.Split(';');

                    var firstAuthor = new Author();
                    firstAuthor.Name = infoBook[4];

                    authors.SetValue(firstAuthor, 0);

                    if (infoBook.Length == 6)
                    {
                        var secondAuthor = new Author();
                        firstAuthor.Name = infoBook[5];
                    }
                    
                    var book = new Book(infoBook[0], authors, double.Parse(infoBook[2]), int.Parse(infoBook[3]));

                    

                    lBooks.Add(book);
                
                }
                return lBooks;
            }
        }
        
    }

}
