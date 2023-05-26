using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Time to add your Team Members!");
            Group heistGroup = new Group();

            void newMember()
            {
                Console.Write("What is your team member's name?");
                string memberName = Console.ReadLine();
                if (memberName == "")
                {
                    return;
                }
                TeamMember newMember = new TeamMember(memberName);
                Console.Write("What is your team members skill level(1-100)?");
                string memberSkillLevel = Console.ReadLine();
                newMember.SkillLevel = int.Parse(memberSkillLevel);
                Console.Write("What is your team members courage factor(0.0-2.0)?");
                string memberCourageFactor = Console.ReadLine();
                newMember.CourageFactor = double.Parse(memberCourageFactor);

                heistGroup.AddToGroup(newMember);
                addAnother();
            }
            newMember();


            void addAnother()
            {
                Console.WriteLine("Add another team member?\n\t1)Yes\n\t2)No");
                string answer = Console.ReadLine();
                int numAnswer = int.Parse(answer);

                switch (numAnswer)
                {
                    case 1:
                        newMember();
                        break;
                    case 2:
                        return;
                }
            }

            // void TeamRoster(Group heistGroup)
            // {
            //     int count = heistGroup.heistGroup.Count;
            //     Console.WriteLine($"You have {count} members in your group.");
            //     foreach (KeyValuePair<string, TeamMember> member in heistGroup.heistGroup)
            //     {
            //         Console.WriteLine($"{member.Value.Name} has a skill level of {member.Value.SkillLevel} and a courage factor of {member.Value.CourageFactor}.");
            //     }
            // }

            // TeamRoster(heistGroup);

            Bank bank = new Bank();
            // int teamSkillLevel;

            // foreach (KeyValuePair<string, TeamMember> member in heistGroup.heistGroup)
            // {
            //     int teamSkillLevel = +member.Value.SkillLevel;
            // }

            // Console.WriteLine($"{teamSkillLevel}");
            // if (teamSkillLevel >= bank.DifficultyLevel)
            // {
            //     Console.WriteLine("Success");
            // }
            // else if (teamSkillLevel < bank.DifficultyLevel)
            // {
            //     Console.WriteLine("Failure");
            // }

        }
    }
}
