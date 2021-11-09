using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string PersonelAdSoyad { get; set; }
        public int DepartmanId { get; set; }
        public int YetkiId { get; set; }
        public string PersonelEmail { get; set; }
        public string PersonelKullaniciAdi { get; set; }
        public string PersonelSifre { get; set; }
        public List<TaskDetay> TaskDetays { get; set; }
        public Departman Departman { get; set; }
        public Yetki  yetkis { get; set; }

    }
}
