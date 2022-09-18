using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BigProje.Areas.Admin.Models.DTOs.Kategoris
{

    [Area("Admin")]
    public class KategoriUpdateDTO
    {
        public int KategoriId { get; set; }
        [Required(ErrorMessage = "KategoriAdi Alani Bos Gecilemez")]
        [StringLength(maximumLength: 20, ErrorMessage = "20 karakterden fazla Girilemez")]
        public string KategoriAdi { get; set; }
        [Required(ErrorMessage = "Aciklama Alani Bos Gecilemez")]

        public string Aciklama { get; set; }
    }
}
