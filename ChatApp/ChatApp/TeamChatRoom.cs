using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatApp_Mediator.ChatApp
{
    public class TeamChatRoom : ChatRoom
    {
        private List<TeamMember> teamMembers = new List<TeamMember>();
        public override void Register(TeamMember member)
        {
            member.SetChatRoom(this);
            this.teamMembers.Add(member);
        }

        public override void Send(string from, string message)
        {
            this.teamMembers.ForEach(x => x.Receive(from, message));
        }

        public void RegisterMembers(params TeamMember[] teamMembers)
        {
            foreach (var member in teamMembers)
            {
                this.Register(member);
            }
        }

        public override void SendTo<T>(string from, string message)
        {
            this.teamMembers.OfType<T>().ToList().ForEach(x => x.Receive(from, message));
        }
    }
}
