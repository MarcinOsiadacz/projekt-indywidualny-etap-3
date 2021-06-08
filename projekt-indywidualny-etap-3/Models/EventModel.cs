using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace projekt_indywidualny_etap_3.Models
{
    [Table("Events")]
    public class EventModel : AbstractEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string OrganizedBy { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public long EventTypeId { get; set; }
        public EventTypeModel EventType { get; set; }
        public long EventCategoryId { get; set; }
        public EventCategoryModel EventCategory { get; set; }
        public int AvailableSlots { get; set; }
    }
}