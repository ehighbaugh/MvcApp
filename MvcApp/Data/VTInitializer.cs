using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApp.Data
{
    public class VTInitializer : DropCreateDatabaseIfModelChanges<VTContext>
    {
        protected override void 
            
            
            Seed(VTContext context)
        {
            var events = new List<Event>
            {
                new Event{Id=1, Name="Toys For Tots", Date=DateTime.Parse("12/12/2018 12:00:00 AM"), StartTime=DateTime.Parse("8:00"), EndTime=DateTime.Parse("12:00")},
                new Event{Id=2, Name="Blood Drive", Date=DateTime.Parse("11/01/2018"), StartTime=DateTime.Parse("9:00"), EndTime=DateTime.Parse("18:00")},
                new Event{Id=3, Name="Adoption Event", Date=DateTime.Parse("10/01/2018"), StartTime=DateTime.Parse("10:00"), EndTime=DateTime.Parse("14:00")},
            };

            events.ForEach(e => context.Event.Add(e));
            context.SaveChanges();

            var organizations = new List<Organization>
            {
                new Organization{Id=1, Name="Kosair", Cause="children's charity", Phone="5025551234", Website="www.kosair.org"},
                new Organization{Id=2, Name="Red Cross", Cause="medical needs", Phone="5025556789", Website="www.redcross.org"},
                new Organization{Id=3, Name="Animal Shelter", Cause="animal welfare", Phone="5025554321", Website="www.animals.org"},
            };

            organizations.ForEach(o => context.Organization.Add(o));
            context.SaveChanges();

            var volunteers = new List<Volunteer>
            {
                new Volunteer{Id=1, Name="Bob Dylan", Email="bob@gmail.com", Phone="5024567896"},
                new Volunteer{Id=2, Name="Jane Turner", Email="jane@gmail.com", Phone="5027891245"},
                new Volunteer{Id=3, Name="Jack White", Email="jack@gmail.com", Phone="5024986532"},
                new Volunteer{Id=4, Name="Helen Troy", Email="helen@gmail.com", Phone="5027844455"},
                new Volunteer{Id=5, Name="Henri Matisse", Email="henri@gmail.com", Phone="5022230145"},
            };

            volunteers.ForEach(v => context.Volunteer.Add(v));
            context.SaveChanges();

            var eventVolunteers = new List<EventVolunteer>
            {
                new EventVolunteer{Id=1, EventId=1, VolunteerId=1, OrganizationId=1},
                new EventVolunteer{Id=2, EventId=1, VolunteerId=3, OrganizationId=2},
                new EventVolunteer{Id=3, EventId=1, VolunteerId=4, OrganizationId=3},
                new EventVolunteer{Id=4, EventId=2, VolunteerId=2, OrganizationId=1},
                new EventVolunteer{Id=5, EventId=2, VolunteerId=5, OrganizationId=2},
                new EventVolunteer{Id=6, EventId=2, VolunteerId=1, OrganizationId=3},
                new EventVolunteer{Id=7, EventId=3, VolunteerId=4,  OrganizationId=1},
                new EventVolunteer{Id=8, EventId=3, VolunteerId=5, OrganizationId=2},
                new EventVolunteer{Id=9, EventId=3, VolunteerId=2, OrganizationId=3}
            };

            eventVolunteers.ForEach(ev => context.EventVolunteers.Add(ev));
            context.SaveChanges();
        }
    }
}