using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Models
{
    class TeamMessagingCreate
    {   
       
        public int MessageID { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string Content { get; set; }
        [Display(Name = "File Name")]
        public string FileName { get; set; }
        [Display(Name = "File Content")]
        public byte[] FileContent { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset? CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset? Modifiedutc { get; set; }
    }
}
