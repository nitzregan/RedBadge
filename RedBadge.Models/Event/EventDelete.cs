using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Models
{
    public class EventDelete
    {
        public int EventID { get; set; }
        public int CalendarID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool AllDayEvent { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
    }
}
