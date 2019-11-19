﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBadge.Data;
using RedBadge.Models;
using RedBadgeProject.Data;

namespace RedBadge.Services { }
//{
//    class TeamService
//    {
//        private readonly Guid _userID;

//        public TeamService(Guid userID)
//        {
//            _userID = userID;
//        }

//        public bool CreateTeam(TeamCreate model)
//        { 
//            var entity =
//                new Team()
//                {
//                    UserID = _userID,
//                    TeamName = model.TeamName,
//                    Roster = model.Roster,
//                    TeamEvents = model.TeamEvents
//                };
//            using (var ctx = new ApplicationDbContext())
//            {
//                ctx.Team.Add(entity);
//                return ctx.SaveChanges() == 1;
//            }
//        }

//        public IEnumerable<TeamListItem> GetTeams()
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                var query =
//                    ctx
//                    .Team
//                    .Where(e => e.UserID == _userID)
//                    .Select(
//                        e =>
//                            new TeamListItem
//                            {
//                                TeamID = e.TeamID,
//                                TeamName = e.TeamName,
//                                Roster = e.Roster,
//                                TeamEvents = e.TeamEvents
//                            }
//                        );
//                return query.ToArray();
//            }
//        }

//        public TeamDetail GetTeamById(int id)
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                var entity =
//                    ctx
//                    .Team
//                    .Single(e => e.TeamID == id);
//                if (entity.Roster.SingleOrDefault(e => e.UserID == _userID) != null)
//                {

//                    return
//                        new TeamDetail
//                        {
//                            TeamID = entity.TeamID,
//                            TeamName = entity.TeamName,
//                            Roster = entity.Roster,
//                            TeamEvents = entity.TeamEvents
//                        };
//                }
//                else
//                {
//                    return null;
//                };
//            }
//        }

//        public bool UpdateTeam(TeamEdit model)
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                var entity =
//                    ctx
//                        .Team
//                        .Single(e => e.TeamID == model.TeamID && e.UserID == _userID);

//                entity.TeamID = model.TeamID;
//                entity.TeamName = model.TeamName;
//                entity.Roster = model.Roster;
//                entity.TeamEvents = model.TeamEvents;

//                return ctx.SaveChanges() == 1;
//            }
//        }

//        public bool DeleteTeam(int TeamId)
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                var entity =
//                    ctx
//                        .Team
//                        .Single(e => e.TeamID == TeamId && e.UserID == _userID);

//                ctx.Team.Remove(entity);

//                return ctx.SaveChanges() == 1;
//            }
//        }
//    }
//}
