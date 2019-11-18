using RedBadge.Data.Data_Tables;
using RedBadge.Models;
using RedBadgeProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Services
{
    public class EventService
    {
        private readonly Guid _userId;

        public EventService(Guid userId)
        {
            _userId = userId;
        }

        //public bool CreateEvent(EventCreate model)
        //{

        //    var entity =
        //        new Event()
        //        {
        //            //OwnerID = _userId,
                    
        //            CalendarID = model.CalendarID,
        //            Title = model.Title,
        //            Content = model.Content,
        //            AllDayEvent = model.AllDayEvent,
        //            Start = model.Start,
        //            End = model.End
        //        };
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        ctx.Event.Add(entity);
        //        return ctx.SaveChanges() == 1;
        //    }
        //}
        ////added in from eleven Note section 8.01
        //public Event GetEventById(int ID)
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //                .Event
        //                .Single(e => e.EventID == ID);
        //        var some = entity.CalendarVariable.TeamEvents;
        //        //return
        //            //new EventDetail
        //            //{
        //            //    EventID = entity.EventID,
        //            //    CalendarID = entity.CalendarID,
        //            //    Title = entity.Title,
        //            //    Content = entity.Content,
        //            //    AllDayEvent = entity.AllDayEvent,
        //            //    Start = entity.Start,
        //            //    End = entity.End
        //            //};
        //    }
        //}
        ////added in from eleven note section 9.01

        
        //public bool UpdatEvent(EventEdit model)
        //{
           

        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //                .Event
        //                .Single(e => e.EventID == model.EventID /*&& e.CalendarID == _userId*/);

        //            entity.CalendarID = model.CalendarID;
        //            entity.Title = model.Title;
        //            entity.Content = model.Content;
        //            entity.AllDayEvent = model.AllDayEvent;
        //            entity.Start = model.Start;
        //            entity.End = model.End;

        //        return ctx.SaveChanges() == 1;
        //    }
        //}
        //public bool DeleteEvent(int EventID)
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //                .Event
        //                //.Single(e => e.EventID == EventID && /*e.CalendarID == _userId*/);

        //        ctx.Event.Remove(entity);

        //        return ctx.SaveChanges() == 1;
        //    }
        //}
        //public IEnumerable<Event> GetEvents()
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var query =
        //            ctx
        //                .Event
        //                //.Where(e => e.UserID == _userId)
        //                .Select(
        //                    e =>
        //                        new Event
        //                        {
                                    

        //                        }
        //                );
        //        return query.ToArray();
        //    }

        //}
       
    }
}

