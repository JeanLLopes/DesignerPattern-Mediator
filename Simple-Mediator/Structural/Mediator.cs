using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Mediator.Structural
{
    public abstract class Mediator
    {
        public abstract void Send(string Message, Colleague colleague);
    }
}
