using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatApp_Mediator.Structural
{
    public class ConcreteMediator : Mediator
    {
        private List<Colleague> colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
        }

        public T CreateColleague<T>() where T: Colleague, new()
        {
            var colleague = new T();
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
            return colleague;
        }

        public override void Send(string message, Colleague colleague)
        {
            this.colleagues.Where(c => c != colleague)
                .ToList()
                .ForEach(c => c.HandleNotification(message));
        }
    }
}
