using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Employee : Person
{
    /*Name is already implemented in Person and should be the same here.*/
    public Employee(FullName PersonName) : base(PersonName)
    {
    }

}
