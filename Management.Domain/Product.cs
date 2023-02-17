using Management.Domain.Commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain
{
    public class Product: GenericEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
