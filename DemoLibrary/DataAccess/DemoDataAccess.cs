using DemoLibrary.Models;

namespace DemoLibrary.DataAccess;

public class DemoDataAccess : IDemoDataAccess
{
    private List<PersonModel> people = new();

    public DemoDataAccess()
    {
        people.Add(new PersonModel() { Id = 1, FirstName = "Vinícius", LastName = "Rossi" });
        people.Add(new PersonModel() { Id = 2, FirstName = "Érico", LastName = "Padilha" });
    }

    public List<PersonModel> GetPeople()
    {
        return people;
    }

    public PersonModel InsertPerson(string firstName, string lastName)
    {
        PersonModel p = new() { FirstName = firstName, LastName = lastName };
        p.Id = people.Max(x => x.Id) + 1;
        people.Add(p);
        
        return p;
    }
}