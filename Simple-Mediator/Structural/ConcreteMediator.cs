using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Mediator.Structural
{
    public class ConcreteMediator : Mediator
    {
        public Colleague1 Colleague1 { get; set; }
        public Colleague2 Colleague2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague.Equals(this.Colleague1))
            {
                this.Colleague1.HandleNotification(message);
            }
            else
            {
                this.Colleague2.HandleNotification(message);
            }
        }
    }
}
