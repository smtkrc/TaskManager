using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        public string DepartmanAd { get; set; }
        public List<Personel> Personels { get; set; }
    }
}
