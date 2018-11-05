using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberTest
{
    class member
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string memberId { get; set; }
        public string membershipStatus { get; set; }
        public int age { get; set; }

        public member(string firstanem, string lastname, string mebershipId, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.memberId = memberId;
            this.age = age;
            membershipStatus = "Expired";
        }

        public override string ToString()
        {
            return string.Format("Firstname:{0} Lastname:{1} Age:{2} ID:{3} Status:{4}",firstname,lastname,age,memberId,membershipStatus);
        }

    }
}
