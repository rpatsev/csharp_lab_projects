using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class ThreadSafeSingletonV1
    {
        private static ThreadSafeSingletonV1 _singleton = new ThreadSafeSingletonV1();

        private ThreadSafeSingletonV1()
        {

        }

        public static ThreadSafeSingletonV1 Instance
        {
            get
            {
                return _singleton;
            }
        }

        public void DoWork()
        {

        }
    }
}
