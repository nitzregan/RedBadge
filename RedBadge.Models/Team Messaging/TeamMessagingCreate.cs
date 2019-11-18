using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RedBadge.Models
{
    public class TeamMessagingCreate
    {   
       
        public int MessageID { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string Content { get; set; }
        public HttpPostedFileBase File { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset? CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset? Modifiedutc { get; set; }
    }
}
