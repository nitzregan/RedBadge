using RedBadgeProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Services
{
    class ProfileService
    {
        public bool CreateProfile(ProfileCreate model)
        {
            var entity =
                new Profile()
                {
                    //CategoryTitle = model.CategoryTitle,
                    //Profile properties
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Profile.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
