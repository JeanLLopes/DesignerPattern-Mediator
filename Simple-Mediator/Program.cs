using Simple_Mediator.Structural;
using System;

namespace Simple_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var c1 = mediator.CreateColleague<Colleague1>();
            var c2 = mediator.CreateColleague<Colleague2>();
            
            c1.Send("Hello (from c1)");
            c2.Send("Hello (from c2)");
        }
    }
}
