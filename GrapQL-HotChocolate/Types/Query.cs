using GrapQL_HotChocolate.Entity;
using GrapQL_HotChocolate.Query;
using GrapQL_HotChocolate.Type;
using MediatR;

namespace GrapQL_HotChocolate.Type
{
    public class Query(IMediator mediator)
    {
        private readonly IMediator _mediator = mediator;

        public string Hello()
        {
            return "Hello world";
        }

        public async Task<List<PlaylistData>> GetPlayList()
        {
            if (_mediator == null)
            {
                throw new InvalidOperationException("Mediator is disposed.");
            }

            return await _mediator.Send(new GetPlayListQuery());
        }
    }
}

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor.Field(t => t.Hello()).Type<StringType>();
    }
}
