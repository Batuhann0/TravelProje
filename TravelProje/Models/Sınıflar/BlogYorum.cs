using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProje.Models.Sınıflar
{
    public class BlogYorum
    {
        //Bir Viewde Birden Fazla Tablo Listelemek için 

        public IEnumerable<Blog> Deger1 { get; set; } //IEnumerable belli bir sayıdaki değerleri koleksiyon formatında tutar
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}