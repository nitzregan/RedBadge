using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Data.Data_Tables
{
    public class Event
    {
        [Required]
        public Guid UserID { get; set; }
        [Key]
        public int EventID { get; set; }
        [ForeignKey("CalendarVariable")]
        public int CalendarID { get; set; }
        public virtual  Calendar CalendarVariable { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool AllDayEvent { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
    }
}
