using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentW4
{
    public class Shape
    {
        //Virtual method within a base class which is intended to be overridden by derived class.
        public virtual float CalculateArea()
        {
            return 0;
        }
    }
}
