using System.Collections.Generic;

namespace Heist
{
    public class Group
    {
        public Dictionary<string, TeamMember> heistGroup = new Dictionary<string, TeamMember>() { };

        public void AddToGroup(TeamMember person)
        {
            heistGroup.Add(person.Name, person);
        }
    }
}