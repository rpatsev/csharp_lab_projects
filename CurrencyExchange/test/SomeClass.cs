using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class SomeClass
    {
        public abstract string SomeProperty { get; set; }
        public abstract string this[int index] { get; set; }
        public abstract void SomeMethod(int a);
        public abstract void SomeMethod(string b);
        public abstract event EventHandler SomeEvent;
    }
}
