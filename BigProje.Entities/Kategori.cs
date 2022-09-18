using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProje.Entities
{
    public class Kategori : BaseEntity
    {

        public string KategoriAdi { get; set; }
        public string Acıklama { get; set; }
        public IList<Yemekler> yemekler { get; set; }
    }
}
