using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Models
{
    public class Organiser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrganiser { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Event_Organiser> Event_Organiser { get; set; }
    }
}
