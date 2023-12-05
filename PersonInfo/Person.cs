using System;

namespace PersonInfo;

public class Person
{
    private string _firstname;
    private string _lastname;
    private int _age;
    private const int Name_Min_leinght = 3;

    public Person(string firstname, string lastname, int age)
    {
        this._firstname = firstname;
        this._lastname = lastname;
        this._age = age;
    }

    public string FirstName
    {
        get { return _firstname; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            _firstname = value;
        }
    }

    public string LastName
    {
        get { return _lastname; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            _lastname = value;
        }
    }
    public int Age
    {
        get { return (int)_age; }
        private set
        {
            if (_age <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            _age = value;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }

}