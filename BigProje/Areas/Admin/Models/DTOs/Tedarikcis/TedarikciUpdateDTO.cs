using Microsoft.AspNetCore.Mvc;

namespace BigProje.Areas.Admin.Models.DTOs.Tedarikcis
{
    [Area("Admin")]
    public class TedarikciUpdateDTO
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gsm { get; set; }
        public string? Email { get; set; }
       
    }
}
