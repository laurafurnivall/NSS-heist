using System;
using System.Collections.Generic;

namespace Heist
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Bank bank = new Bank();
            Console.WriteLine("What would you like your banks difficulty level to be?");
            string bankDifficulty = Console.ReadLine();
            int bankDifficultyNum = int.Parse(bankDifficulty);
            bank.DifficultyLevel = bankDifficultyNum;

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

            Console.WriteLine("How many times would you like to attempt the heist?");
            string heistAttempts = Console.ReadLine();
            int hesitAttemptsNum = int.Parse(heistAttempts);

            for (int i = 1; i <= hesitAttemptsNum; i++)
            {
                void RunBankHeist()
                {
                    Random random = new Random();
                    int luckLevel = random.Next(-10, 11);
                    int teamSkillLevel = 0;

                    foreach (KeyValuePair<string, TeamMember> member in heistGroup.heistGroup)
                    {
                        teamSkillLevel += member.Value.SkillLevel;
                    }

                    Console.WriteLine($"Your teams skill level is: {teamSkillLevel}");
                    Console.WriteLine($"And the banks difficulty level is: {bank.DifficultyLevel + luckLevel}");
                    if (teamSkillLevel >= bank.DifficultyLevel + luckLevel)
                    {
                        Console.WriteLine("\t Success! You robbed the bank!");
                        bank.successRuns += 1;
                    }
                    else if (teamSkillLevel < bank.DifficultyLevel + luckLevel)
                    {
                        Console.WriteLine("\t Oh no! You were caught!");
                        bank.failedRuns += 1;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"You robbed the bank successfully {bank.successRuns} times, and failed {bank.failedRuns} times.");
                }

                RunBankHeist();
            }
        }
    }
}
