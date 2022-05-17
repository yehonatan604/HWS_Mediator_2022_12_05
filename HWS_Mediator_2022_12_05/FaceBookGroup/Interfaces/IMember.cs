using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Mediator_2022_12_05
{
    public interface IMember
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        string? NickName { get; set; }
        void Send(string msg);
        void Recieve(string msg);
    }
}
