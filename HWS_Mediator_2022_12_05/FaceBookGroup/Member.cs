using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Mediator_2022_12_05
{
    public class Member : IMember
    {
        //Properties
        private readonly IFaceBookGroup? _mediator;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }

        //full constructor
        public Member(IFaceBookGroup? mediator, string? firstName, string? lastName, string? nickName)
        {
            _mediator = mediator;
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
        }

        //implementing IMember Interface
        public void Recieve(string msg)
        {
            Console.WriteLine($"{NickName} recived messege: {msg}"); ;
        }
        public void Publish(string msg)
        {
            Console.WriteLine($">>>{NickName} sending messege: {msg}\n"); ;
            _mediator?.PublishMessage(msg, this);
        }
    }
}
