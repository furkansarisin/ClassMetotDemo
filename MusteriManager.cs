using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName
                + musteri.LastName + " Added");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName
                + musteri.LastName + " Deleted");
        }
    }
}
