using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ExtendsSomeClass : SomeClass
    {
        public override string this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string SomeProperty
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override event EventHandler SomeEvent;

        public override void SomeMethod(string b)
        {
            throw new NotImplementedException();
        }

        public override void SomeMethod(int a)
        {
            throw new NotImplementedException();
        }
    }
}
