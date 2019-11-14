using RedBadge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Models
{
    public class TeamEdit
    {
        public int TeamID { get; set; }
        [Required]
        public Guid UserID { get; set; }
        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        public ICollection<Profile> Roster { get; set; }
    }
}
