using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();
            var subject = new Subject();
            subject.RegisterObserver(observerA);
            subject.RegisterObserver(observerB);
            subject.NotifyObservers();
            Console.WriteLine("--------------------");
            subject.UnregisterObserver(observerA);
            subject.NotifyObservers();
        }
    }
}
