using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Book(string Name) : BaseEntity
{
    /*Takes in a Name (title).*/
    public override string Name { get; } = Name;
}
