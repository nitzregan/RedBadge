using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBadge.Data;
using RedBadge.Models;
using RedBadgeProject.Data;

namespace RedBadge.Services
{
    class TeamMessagingService
    {
        private readonly Guid _userID;

        public TeamMessagingService(Guid userID)
        {
            _userID = userID;
        }

        public bool CreateTeamMessaging(TeamMessagingCreate model)
        {
            Stream fs = model.File.InputStream;
            BinaryReader br = new BinaryReader(fs);
            byte[] bytes = br.ReadBytes((Int32)fs.Length);

            var entity =
                new TeamMessaging()
                {
                    FileContent = bytes,
                    
                }
        }
    }
}
