using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Mediator_2022_12_05
{
    public interface IFaceBookGroup
    {
        void PublishMessage(string message, IMember user);
        void Register(params IMember[] userslist);
    }
}
