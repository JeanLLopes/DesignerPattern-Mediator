using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp_Mediator.ChatApp
{
    public abstract class ChatRoom
    {
        public abstract void Register(TeamMember meamber);
        public abstract void Send(string from, string message);
        public abstract void SendTo<T>(string from, string message) where T : TeamMember;
    }
}
