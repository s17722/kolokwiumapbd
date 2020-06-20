using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Models
{
    public class Event_Organiser
    {
        public int IdEvent { get; set; }

        public int IdOrganiser { get; set; }

        [ForeignKey("IdEvent")]
        public virtual Event Event { get; set; }

        [ForeignKey("IdOrganiser")]
        public virtual Organiser Organiser { get; set; }

    }
}
