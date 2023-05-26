namespace Heist
{
    public class Bank
    {
        public string BankName { get; set; }
        public int DifficultyLevel { get; set; }

        public Bank()
        {
            BankName = "The Bank";
            DifficultyLevel = 100;
        }
    }
}