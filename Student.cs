using System;

class Student:Person
{
    private string StudentID;

    public Student(string name, string password, string type,string studentID) : base(name, password, type)
    {
        this.StudentID = studentID;
    }
}
