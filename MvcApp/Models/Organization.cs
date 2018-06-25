
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }   
        public string Cause { get; set; }

        public virtual ICollection<EventVolunteer> EventVolunteers { get; set; }
    }
}