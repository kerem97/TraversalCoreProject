using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
