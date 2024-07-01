using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Exceptions
{
    public class ProjectedAlreadyStartedException : Exception
    {
        protected ProjectedAlreadyStartedException() : base("Projected has already started status")
        {            
        }
    }
}