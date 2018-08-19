using System.Collections.Generic;

namespace crud_people.Models
{

    public class PersonRepository
    {

        public static List<Person> people = new List<Person>();
    
        public PersonRepository()
        {           
        }


        public void Create(Person person)
        {
            people.Add(person);

        }
        public void Delete(int id)
        {
            people.Remove(people.Find(x=>x.id == id));
        }

        public void Update(Person person)
        {
            Delete(person.id);
            Create(person);
        }

        public Person GetById(int id)
        {
            return people.Find(x=>x.id == id);
        }

        public List<Person> GetAll()
        {
            return people;
        }
    }
}