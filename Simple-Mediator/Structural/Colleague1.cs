using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Mediator.Structural
{
    public class Colleague1 : Colleague
    {
        public Colleague1(Mediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"{nameof(Colleague1)} receives a notification message {message}");
        }
     }
}
