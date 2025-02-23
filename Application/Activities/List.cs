using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        //////////////////////////// MEDIATOR QUERY //////////////////////////////
        # region This is where the Query is formed
        #endregion
        public class Query : IRequest<List<Activity>>{}


        // HANDLER
        # region This is where the Query is passed
        #endregion
        public class Handler : IRequestHandler<Query , List<Activity>> 
        {
            private readonly DataContext _context;
        
            public Handler(DataContext context)
            {
                  _context = context;
            }

            // RETURN THE LIST OF ACTIVITIES
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
               return await _context.Activities.ToListAsync(); 
            } 
        }
    }
}