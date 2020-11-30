﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    sealed public class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
            _eat = 50;
            _consume = 5;
        }
    }
}