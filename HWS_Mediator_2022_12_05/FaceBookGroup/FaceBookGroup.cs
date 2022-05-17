using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Mediator_2022_12_05
{
    public class FaceBookGroup : IFaceBookGroup
    {
        //a List<IMember> that holds registered members:
        private readonly List<IMember> members = new();

        //implementing IFaceBookGroup Interface
        public void Register(params IMember[] userslist)
        {
            foreach (IMember user in userslist)
            {
                members.Add(user);
            }
        }
        public void SendMessage(string message, IMember user)
        {
            members.ForEach(u => { if (u != user) u.Recieve(message); });
            Console.WriteLine("\n");
        }
    }
}
