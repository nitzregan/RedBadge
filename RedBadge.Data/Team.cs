using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        [Required]
        public Guid UserID { get; set; }
        [ForeignKey("CalendarVariable")]
        public int CalendarID { get; set; }
        public virtual Calendar CalendarVariable { get; set; }
        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        public ICollection<Profile> Roster { get; set; }
    }
}
