using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BLL.Contracts.CQRS.Shared
{
    //Contient des attributs partagés(Shared) entre Queries & Commands 
    public abstract class BaseProducts
    {
        public DateTime CreationDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
