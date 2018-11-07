using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberTest
{
    class Member:IComparable
    {
        public static int memberCount = 0;

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string memberId { get; set; }
        public string membershipStatus { get; set; }
        public int age { get; set; }
        public decimal price { get; }
        
        public Member(string firstname, string lastname, string mebershipId, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.memberId = memberId;
            this.age = age;
            membershipStatus = "Expired";

            if(age < 18)
            {
                price = 50;
            }
            else
            {
                price = 150;
            }
            memberCount++;
        }

        public override string ToString()
        {
            return string.Format("\tFirstname: {0}, Lastname: {1}, Age: {2}, ID: {3}, Status: {4}, Price: {5}.", firstname, lastname, age, memberId, membershipStatus, price);
        }

        public void changeMembershipStatus()
        {
            if(membershipStatus == "Expired")
            {
                membershipStatus = "Current";
            }
            else
            {
                membershipStatus = "Expired";
            }
        }

        public int CompareTo(object obj)
        {
            Member other = (Member)obj;
            ////lastname
            //return this.lastname.CompareTo(other.lastname);

            //age
            if (this.age > other.age)
            {
                return 1;
            }
            else if (this.age < other.age)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
