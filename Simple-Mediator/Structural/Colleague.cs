using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Mediator.Structural
{
    public abstract class Colleague
    {
        private Mediator mediator;

        protected Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            this.mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}
