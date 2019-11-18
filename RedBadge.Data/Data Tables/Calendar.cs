using RedBadge.Data.Data_Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Data
{
    public class Calendar
    {
        [Key]
        public int CalendarID { get; set; }
        public ICollection<Event> TeamEvents { get; set; }
    }
}
