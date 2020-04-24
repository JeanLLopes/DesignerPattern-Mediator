using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp_Mediator.Structural
{
    public abstract class Mediator
    {
        public abstract void Send(string Message, Colleague colleague);
    }
}
