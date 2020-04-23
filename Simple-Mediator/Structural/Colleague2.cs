using System;

namespace Simple_Mediator.Structural
{
    public class Colleague2 : Colleague
    {
        public Colleague2(Mediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"{nameof(Colleague2)} receives a notification message {message}");
        }
    }
}
