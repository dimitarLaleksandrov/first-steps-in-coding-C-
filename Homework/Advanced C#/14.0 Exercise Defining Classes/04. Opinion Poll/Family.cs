using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Opinion_Poll
{
    internal class Family
    {
        private List<Person> familyMembers;
        public List<Person> FamilyMembers { get; set; }
        public Person Familymembers { get; set; }
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
            int membersMoreThen = 30;
            //int maxAge = this.familyMembers.Max(member => member.Age);
            return this.familyMembers.First(member => member.Age >= membersMoreThen);
        }
    }
}
