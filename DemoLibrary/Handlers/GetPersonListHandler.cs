using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary;

public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
{
    public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
