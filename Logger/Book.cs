using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Book(string Name) : BaseEntity
{
    /*Implicity implemented as it takes in a Name (title).*/
    public override string Name { get; } = Name;
}
