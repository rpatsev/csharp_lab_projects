using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class ThreadSafeSingletonV2
    {
        private static ThreadSafeSingletonV2 _singleton;
        private static object _lockObject = new object(); 

        private ThreadSafeSingletonV2()
        {
           
        }

        public static ThreadSafeSingletonV2 Instance
        {
            get
            {
                if (_singleton == null)
                {
                    lock (_lockObject)
                    {
                        if(_singleton == null)
                        {
                            _singleton = new ThreadSafeSingletonV2();
                        }       
                    }
                    
                }

                return _singleton;
            }
        }

        public void DoWork()
        {

        }
    }
}
