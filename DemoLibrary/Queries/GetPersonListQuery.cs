using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary;

public record GetPersonListQuery : IRequest<List<PersonModel>>;
{
    public record GetPersonListQuery() 

    // public class GetPersonListQueryClass(): IRequest<List<PersonModel>>()
    // {
    // }
}
