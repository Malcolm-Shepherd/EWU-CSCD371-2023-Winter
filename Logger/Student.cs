using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Student : Person
{
    public Student(FullName PersonName) : base(PersonName)
    {
    }

    protected Student(Person original) : base(original)
    {
    }
}

