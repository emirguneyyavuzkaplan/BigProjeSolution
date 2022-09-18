using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProje.Entities
{
    public class Uyeler : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }

        #region Kullanici girisi icin alanlar
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        #endregion

        
    }
}
