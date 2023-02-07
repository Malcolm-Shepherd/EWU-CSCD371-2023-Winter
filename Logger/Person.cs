using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Person(FullName PersonName) : Entity
{
    public override string Name { get; } = PersonName.ToString() ?? throw new ArgumentNullException(nameof(PersonName));
}
