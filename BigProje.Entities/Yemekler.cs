using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProje.Entities
{
    public class Yemekler:BaseEntity
    {
        public string YemekAdi { get; set; }
        public string Aciklama { get; set; }
        public string Aşcı { get; set; }
        
        public string? TeknikOzellikler { get; set; }
        public DateTime YapimTeknigi { get; set; }
        
        public string? Malzemeler { get; set; }
       
        public string? BarkodNo { get; set; }
        public Tedarikci? Tedarikci { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public string KategoriAdi { get; set; }

    }
}
