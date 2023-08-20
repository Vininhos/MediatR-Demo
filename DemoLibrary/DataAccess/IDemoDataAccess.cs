using DemoLibrary.Models;

namespace DemoLibrary.DataAccess;

public interface IDemoDataAccess
{
    List<PersonModel> GetPoeple();
    PersonModel InsertPerson(string firstName, string lastName);
}