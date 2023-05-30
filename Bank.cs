namespace Heist
{
    public class Bank
    {
        public string BankName { get; set; }
        public int DifficultyLevel { get; set; }

        public int successRuns { get; set; }
        public int failedRuns { get; set; }

        public Bank()
        {
            BankName = "The Bank";
            DifficultyLevel = 0;
            successRuns = 0;
            failedRuns = 0;
        }
    }
}