using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatciVeUlkeleri2.Data
{
    [Table("Ulkeler")]
    public class Ulke
    {
        
        public int Id { get; set; }

        [Required, MaxLength(50)]

        public string Ad { get; set; }

        public virtual ICollection<Sanatci> Sanatcilar { get; set; }

    }
}
