using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand : IRequest
    {
   
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
      
        public bool Status { get; set; }
    }
}
