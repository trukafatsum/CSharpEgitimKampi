using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

/*
 Field-Variable-Property

**Code First yaklaşımında otomatik artan ve birincil anahtar olarak algılaması için sınıfın adı yazılmalı ve sonuna Id getirilmelidir.
**Category sınıfı için CategoryId doğru tanımdır. Category sınıfı için ProductId veya AbcId yazılırsa bunu birincil anahtar olarak oluşturmaz.**


Bire çok ilişki için List<Product> Products tanımlandı.
 */