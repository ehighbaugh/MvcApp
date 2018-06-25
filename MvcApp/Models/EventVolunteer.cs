using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class EventVolunteer
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int VolunteerId { get; set; }
        public int OrganizationId { get; set; }

        public virtual Event Event { get; set; }
        public virtual Volunteer Volunteer { get; set; }
        public virtual Organization Organization { get; set; }
    }
}