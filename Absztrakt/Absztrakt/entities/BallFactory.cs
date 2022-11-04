using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt.entities
{
    public class BallFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
