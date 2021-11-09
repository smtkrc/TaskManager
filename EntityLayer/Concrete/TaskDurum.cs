using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TaskDurum
    {
        [Key]
        public int DurumId { get; set; }
        public string DurumAd { get; set; }
        public List<TaskDetay> TaskDetays { get; set; }
    }
}
