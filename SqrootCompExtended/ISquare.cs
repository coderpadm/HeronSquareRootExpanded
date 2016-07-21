using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrootCompExtended
{
    interface ISquare
    {
       double errorMargin { get; }
            
       double Sqrt();
    }
}
