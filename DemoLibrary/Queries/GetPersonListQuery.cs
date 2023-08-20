using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary;

public record GetPersonListQuery : IRequest<List<PersonModel>>;