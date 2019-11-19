using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Data.Data_Tables
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public string Title { get; set; }
        public bool AllDayEvent { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
    }
}
