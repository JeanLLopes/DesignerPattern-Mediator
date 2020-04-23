using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Mediator.Structural
{
    public class Colleague1 : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"{nameof(Colleague1)} receives a notification message {message}");
        }
     }
}
