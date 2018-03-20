using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ImplementsISomeInterface : ISomeInterface
    {
        public string this[int index]
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

        public string SomeProperty
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

        public event EventHandler SomeEvent;

        public void SomeMethod(string b)
        {
            throw new NotImplementedException();
        }

        public void SomeMethod(int a)
        {
            throw new NotImplementedException();
        }
    }
}
