using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classses2
{
    class Book : Product
    {
       public string Genre;
    
       public Book(int no, string name, float price, string genre) : base(no, name, price)
        {
            Genre = genre;
        }
    }
     
}
