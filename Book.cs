using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF_Enviroment
{
    public class Book
    {
        public long Id { get; set; } 
        public string Tittle { get; set; }
        public DateTime PublicTime { get; set; }
        public double Price { get; set; }
        public string AuthorName { get; set; }

    }
}
