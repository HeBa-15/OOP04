using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Example03
{
    internal class Car : Vechile, IMoveable
    {
        public void Backward()
        {
            throw new NotImplementedException();
        }
        public void Forward()
        {
            throw new NotImplementedException();
        }
        public void Left()
        {
            throw new NotImplementedException();
        }
        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
