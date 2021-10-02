using System;
using System.Collections.Generic;

class PersonList
{
    private List<Person> personLists;

    public PersonList() 
    {
     this.personLists = new List<Person>();
    }
    public void AddNewPerson(Person person) 
    {
        this.personLists.Add(person);
    }
}
