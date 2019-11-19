using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Models
{
    public class TeamMessagingDetail
    {
        [Required]
        public Guid UserID { get; set; }
        [Key]
        public int MessageID { get; set; }
        public int TeamID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] FileContent { get; set; }
        public DateTimeOffset? CreatedUtc { get; set; }
        public DateTimeOffset? Modifiedutc { get; set; }
    }
}
