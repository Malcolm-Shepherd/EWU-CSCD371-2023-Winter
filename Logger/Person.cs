using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Person(FullName PersonName) : BaseEntity
{
    /*People have full names, so it only makes sense to take in a FullName*/
    public override string Name {
        get
        {
            return PersonName.MiddleName == null ? PersonName.FirstName + " " + PersonName.LastName: PersonName.FirstName + " " + PersonName.MiddleName + " " + PersonName.LastName;
        }
             
    }
}
