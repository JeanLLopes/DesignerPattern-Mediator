using ChatApp_Mediator.ChatApp;
using System;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamChatRoom = new TeamChatRoom();

            var Dev1 = new Developer("Developer One");
            var Dev2 = new Developer("Developer Two");
            var Dev3 = new Developer("Developer Three");
            var Tester1 = new Tester("Tester One");
            var Tester2 = new Tester("Tester Two");

            teamChatRoom.RegisterMembers(Dev1, Dev2, Dev3, Tester1, Tester2);

            //WITH THIS WE SEND A MESSAGE TO A GROUP
            Dev1.SendTo<Developer>("Hey we're developers");
            //Tester1.SendTo<Tester>("Hey we're tester");
        }
    }
}
