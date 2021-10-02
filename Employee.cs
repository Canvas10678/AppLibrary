using System;

class Employee : Person
{
    private string EmployeeID;

    public Employee(string name, string password, string type, string employeeID) : base(name, password, type)
    {
        this.EmployeeID = employeeID;
    }
}
