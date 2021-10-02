using System;
enum User{ Student = 1, Emplyee }

class Person 
{
    protected string Name;
    protected string Passworrd;
    protected string Type;

    public Person(string name,string password,string type) 
    {
        this.Name = name;
        this.Passworrd = password;
        this.Type = type;
    }
    public string GetName() 
    {
        return this.Name;
    }
}
