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
                new Event{Name="Toys For Tots", Date=DateTime.Parse("12/01/2018"), StartTime=DateTime.Parse("8:00"), EndTime=DateTime.Parse("12:00")},
                new Event{Name="Blood Drive", Date=DateTime.Parse("11/01/2018"), StartTime=DateTime.Parse("9:00"), EndTime=DateTime.Parse("12:00")},
                new Event{Name="Adoption Event", Date=DateTime.Parse("10/01/2018"), StartTime=DateTime.Parse("10:00"), EndTime=DateTime.Parse("12:00")},
            };

            events.ForEach(e => context.Event.Add(e));
            context.SaveChanges();

            var organizations = new List<Organization>
            {
                new Organization{Name="Kosair", Cause="children's charity", Phone="5025551234", Website="www.kosair.org"},
                new Organization{Name="Red Cross", Cause="medical needs", Phone="5025556789", Website="www.redcross.org"},
                new Organization{Name="Animal Shelter", Cause="animal welfare", Phone="5025554321", Website="www.animals.org"},
            };

            organizations.ForEach(o => context.Organization.Add(o));
            context.SaveChanges();

            var volunteers = new List<Volunteer>
            {
                new Volunteer{Name="Bob Dylan", Email="bob@gmail.com", Phone="5024567896"},
                new Volunteer{Name="Jane Turner", Email="jane@gmail.com", Phone="5027891245"},
                new Volunteer{Name="Jack White", Email="jack@gmail.com", Phone="5024986532"},
                new Volunteer{Name="Helen Troy", Email="helen@gmail.com", Phone="5027844455"},
                new Volunteer{Name="Henri Matisse", Email="henri@gmail.com", Phone="5022230145"},
            };

            volunteers.ForEach(v => context.Volunteer.Add(v));
            context.SaveChanges();
        }
    }
}