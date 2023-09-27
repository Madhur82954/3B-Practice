using System;
using System.Collections.Generic;
using System.Text;

namespace _3B_PracticeProblem
{
    class Constructors
    {
        public string model;
        public Constructors()//Normal Constructor
        {
            model = "Hero";
        }
        public Constructors(string modelname)//parameterised constructor
        {
            model = modelname;
        }
    }
}
