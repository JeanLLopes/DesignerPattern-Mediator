using System;

namespace Simple_Mediator.Structural
{
    public class Colleague2 : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"{nameof(Colleague2)} receives a notification message {message}");
        }
    }
}
