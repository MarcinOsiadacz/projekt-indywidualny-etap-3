using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace projekt_indywidualny_etap_3.Models
{
    [Table("Types")]
    public class EventTypeModel : AbstractEntity
    {
        public string Name { get; set; }
        public ICollection<EventModel> Event { get; set; }
    }
}