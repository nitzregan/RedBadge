using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Models
{
    public class TeamMessagingListItem
    {
        public int MessageID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name = "File Content")]
        public byte[] FileContent { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset? CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset? Modifiedutc { get; set; }
    }
}
