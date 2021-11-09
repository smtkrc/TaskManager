using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TaskDetay
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskBaslik { get; set; }
        public string TaskIcerik { get; set; }
        public DateTime TaskOlusturulmaTarihi { get; set; }
        public DateTime TaskBaslangicTarihi { get; set; }
        public DateTime TaskBitisTarihi { get; set; }
        public int DurumId { get; set; }
        public TaskDurum TaskDurum { get; set; }
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
        public int OncelikId { get; set; }
        public TaskOncelik TaskOncelik { get; set; }
        public List<TaskDokuman> TaskDokumans { get; set; }

    }
}
