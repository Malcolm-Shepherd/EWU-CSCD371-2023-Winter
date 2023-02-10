using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public abstract record class BaseEntity : IEntity
{
    public virtual Guid Id { get; init; } = Guid.NewGuid();

    public abstract string Name { get; }    
} 
