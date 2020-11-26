using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public class Lion : Animal
    {
        public Lion(string name) : base (name)
        {
            _eat = 25;
        }
    }
}
