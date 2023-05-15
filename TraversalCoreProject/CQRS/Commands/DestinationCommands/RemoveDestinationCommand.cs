﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
