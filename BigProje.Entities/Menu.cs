using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProje.Entities
{
    public class Menu:BaseEntity
    {
        public string MenuAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Acıklama { get; set; }
    }
}
