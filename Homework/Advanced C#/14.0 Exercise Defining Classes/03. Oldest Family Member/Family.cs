using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Oldest_Family_Member
{
    internal class Family
    {
        private List<Person> familyMembers;
        public Family()
        {
            this.familyMembers = new List<Person>();
        }
        public void AddMembe(Person member)
        {
            this.familyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            int maxAge = this.familyMembers.Max(member => member.Age);
            return this.familyMembers.First(member => member.Age == maxAge);
        }
    }
}
