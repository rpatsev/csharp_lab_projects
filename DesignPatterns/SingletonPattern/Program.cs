﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            singleton.DoWork();

            UserRepository userRepository = UserRepository.Instance;
            object user = userRepository.GetUser("login");
        }
    }
}
