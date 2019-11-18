using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RedBadge.Models
{
    public class TeamMessagingEdit
    {
        [Required]
        public Guid UserID { get; set; }
        [Key]
        public int MessageID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public DateTimeOffset? CreatedUtc { get; set; }
        public DateTimeOffset? Modifiedutc { get; set; }
    }
}
