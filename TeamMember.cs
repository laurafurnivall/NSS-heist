namespace Heist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public TeamMember(string name)
        {
            Name = name;
            SkillLevel = 0;
            CourageFactor = 0;
        }
    }
}
