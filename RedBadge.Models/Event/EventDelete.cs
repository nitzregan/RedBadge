using RedBadge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Models
{
    public class EventDelete
    {
        [Required]
        public Guid UserID { get; set; }
        [Key]
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool AllDayEvent { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
    }
}
