using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TaskAksiyon
    {

        [Key]
        public int AksiyonId { get; set; }
        public string AksiyonAciklama { get; set; }
        public int TaskId { get; set; }
        public DateTime AksiyonKayitTarihi { get; set; }
        public DateTime AksiyonBaslangicTarihi { get; set; }
        public DateTime AksiyonBitisTarihi { get; set; }
        public TaskDetay TaskDetay { get; set; }
    }
}
