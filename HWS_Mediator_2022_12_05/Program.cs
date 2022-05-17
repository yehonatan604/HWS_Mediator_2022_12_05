using System;

namespace HWS_Mediator_2022_12_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FaceBookGroup faceGroup = new();

            IMember[] members =
            {
                new Member(faceGroup, "joe", "Rogan", "FunnyGuy"),
                new Member(faceGroup, "Richard", "Starkey", "RingoStarr"),
                new Member(faceGroup, "Merv", "Pepler", "EatStatic"),
                new Member(faceGroup, "Jimmi", "Henderix", "TheKing"),
            };
            faceGroup.Register(members);

            members.ToList().ForEach(u => u.Publish($"<{u.NickName}>: Hello everybody my name is {u.FirstName} {u.LastName}"));
        }
    }
}
