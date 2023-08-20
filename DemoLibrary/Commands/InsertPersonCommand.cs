using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
    //public class InsertPersonCommand : IRequest<PersonModel>
    //{
    //    public InsertPersonCommand(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}
}
