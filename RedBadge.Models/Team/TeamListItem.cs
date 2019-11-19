using RedBadge.Data;
using RedBadge.Data.Data_Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Models
{
    public class TeamListItem
    {
        [Required]
        public Guid UserID { get; set; }
        [Key]
        public int TeamID { get; set; }
        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        public ICollection<Profile> Roster { get; set; }
        public ICollection<RedBadge.Data.Data_Tables.Event> TeamEvents { get; set; }

    }
}
