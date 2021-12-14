using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatciVeUlkeleri2.Data
{
    [Table("Sanatcilar")]
    public class Sanatci
    {
        public int Id { get; set; }

        public string Ad { get; set; }
        public int? UlkeId { get; set; }

        public virtual Ulke Ulke { get; set; }
    }
}
