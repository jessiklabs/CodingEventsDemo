﻿using System.Collections.Generic;
using System.Data.Common;

namespace CodingEventsDemo.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Event> events { get; set; }

        public EventCategory()
        {

        }
        public EventCategory(string name)
        {
            Name = name;
        }
    }
}
