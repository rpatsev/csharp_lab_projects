﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserverA : IObserver
    {
        public void Update()
        {
            Console.WriteLine("ConcreteObserverA is notified");
        }

    }
}
