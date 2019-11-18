﻿using RedBadge.Data;
using RedBadge.Models;
using RedBadgeProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Services
{
    public class ProfileService
    {
        private readonly Guid _userID;

        public ProfileService(Guid userID)
        {
            _userID = userID;
        }

        public bool CreateProfile(ProfileCreate model)
        {
            var entity =
                new Profile()
                {
                    UserID = _userID,
                    ProfileID = model.ProfileID,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Birthday = model.Birthday,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    OtherInfo = model.OtherInfo,
                    MyTeams = model.MyTeams,
                    Comment = model.Comment,
                    CreatedUtc = model.CreatedUtc
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Profile.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public ProfileListItem GetProfile(Guid UserID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Profile
                        .Where(e => e.UserID == UserID)
                        .Single();
                return new ProfileListItem
                {
                    UserID = _userID,
                    ProfileID = query.ProfileID,
                    FirstName = query.FirstName,
                    LastName = query.LastName,
                    Birthday = query.Birthday,
                    Email = query.Email,
                    PhoneNumber = query.PhoneNumber,
                    OtherInfo = query.OtherInfo,
                    MyTeams = query.MyTeams,
                    Comment = query.Comment,
                    CreatedUtc = query.CreatedUtc
                };
            }
        }

        public IEnumerable<ProfileListItem> GetAllProfilesByTeam(int TeamID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Team
                        .Where(e => e.TeamID == TeamID)
                        .Single().Roster
                        .Select(
                            e =>
                                new ProfileListItem
                                {
                                    UserID = _userID,
                                    ProfileID = e.ProfileID,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    Birthday = e.Birthday,
                                    Email = e.Email,
                                    PhoneNumber = e.PhoneNumber,
                                    OtherInfo = e.OtherInfo,
                                    MyTeams = e.MyTeams,
                                    Comment = e.Comment,
                                    CreatedUtc = e.CreatedUtc
                                }
                        );
                return query.ToArray();
            }
        }

        public bool UpdateProfile(ProfileEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profile
                        .Single(e => e.ProfileID == model.ProfileID && e.UserID == _userID);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Birthday = model.Birthday;
                entity.Email = model.Email;
                entity.PhoneNumber = model.PhoneNumber;
                entity.OtherInfo = model.OtherInfo;
                entity.MyTeams = model.MyTeams;
                entity.Comment = model.Comment;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
