﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.CQRS.Results.DestinationResults
{
    public class GetDestinationByIDQueryResult
    {
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
    }
}
