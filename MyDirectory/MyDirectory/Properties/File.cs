using System;
using System.Collections.Generic;
using System.Text;

namespace MyDirectory.Properties
{
    class File: MyObject
    {
        //public int _Weight;
        public File(string name, MyObject parent, int weight) : base(name,parent)
        {
            _Weight = weight;
        }
    }
}
