using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberTest
{
    class MemberTest
    {
        static void Main(string[] args)
        {
            Member[] Members = new Member[] { new Member("Name 1", "Lastname 1", "1234", 30),
                new Member("Name 2", "ALastname 2", "1235a", 13),
                new Member("Name 3", "TheLastname 3", "1236a", 40),
                new Member("Name 4", "SomeLastname 4", "1237a", 30),
                new Member("Name 5", "OtherLastname 5", "1238a", 27)};

            displayAllMembers(Members);

            Members[1].changeMembershipStatus();
            Members[3].changeMembershipStatus();
            Array.Sort(Members);

            displayAllMembers(Members);

            Array.Reverse(Members);
            displayAllMembers(Members);
        }

        static void displayAllMembers(Member[] membersArr)
        {
            Console.WriteLine(" All members' information:");
            Console.WriteLine(string.Format(" {0} members in total.\n", Member.memberCount));
            foreach (Member item in membersArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
