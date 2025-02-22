using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Domain;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        /// Represents a request to perform an action or make a change
        /// it does not expect a response
        /// The Command is used to perform an action, 
        //  and once the action is done, there is no need for any data or 
        /// result to be returned to the caller.
        public class Command : IRequest
        {
            public Activity ? Activity {get; set;}

        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Activities.Add(request.Activity);
                await _context.SaveChangesAsync();
                //return Unit.Value;
            }
        }
    }
}