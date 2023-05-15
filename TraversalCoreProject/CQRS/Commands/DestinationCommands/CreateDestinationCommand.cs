﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
    }
}
