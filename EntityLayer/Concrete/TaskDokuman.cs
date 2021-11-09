using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TaskDokuman
    {
        [Key]
        public int DokumanId { get; set; }
        public string DokumanBaslık { get; set; }
        public string DokumanAciklama { get; set; }
        public string DokumanUrl { get; set; }
        public int TaskId { get; set; }
        public TaskDetay TaskDetay { get; set; }
    }
}
