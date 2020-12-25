using Microsoft.AspNetCore.Identity;
using myScoreApp.Models.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.Models
{
    public class Mekan
    {
        public int mekanId { get; set; }

        [Display(Name = "Kategori")]
        public string CatName { get; set; }
        
        [Display(Name = "Mekanın Uzaklığı")]
        public string UzaklikTip { get; set; }

        [Display(Name = "Mekan Adı")]
        public string mekanAdi { get; set; }

        [Display(Name = "Mekan Açıklaması")]
        public string mekanAciklamasi { get; set; }
       
        [Display(Name = "Mekana Ait Resim")]
        public string mekanResim { get; set; }

        [Display(Name = "Tarih")]
        public DateTime tarih { get; set; }
        public List<MainComment> MainComments { get; set; }
        public IdentityUser user { get; set; }
    }
}
