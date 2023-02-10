using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Student : Person
{
    /*Explicitly implemented as Name is already implemented in Person and should be the same here.*/
    public Student(FullName PersonName) : base(PersonName)
    {

    }
}

