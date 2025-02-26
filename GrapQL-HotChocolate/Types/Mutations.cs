using GrapQL_HotChocolate.Command;
using MediatR;

namespace GrapQL_HotChocolate.Types
{
    public class Mutations(IMediator mediator)
    {
        private readonly IMediator _mediator = mediator;
        public async Task<bool> AddPlaylist(string name)
        {
            if (_mediator == null)
            {
                throw new InvalidOperationException("Mediator is disposed.");
            }

            await _mediator.Send(new CreatePLayListCommand(name));
            return true;
        }
    }
}
