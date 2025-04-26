namespace MontyHallApplication.Server.Services
{
    public class MontyHallSimulator
    {
        private readonly Random _random = new();

        public (int wins, int losses) RunSimulations(int numberOfGames, bool switchChoice)
        {
            int wins = 0;

            for (int i = 0; i < numberOfGames; i++)
            {
                int carDoor = _random.Next(0, 3); 
                int playerChoice = _random.Next(0, 3); 

                List<int> availableDoors = new() { 0, 1, 2 };
                int montyOpens = availableDoors
                    .Where(d => d != playerChoice && d != carDoor)
                    .OrderBy(x => _random.Next()).First();

                int finalChoice = playerChoice;

                if (switchChoice)
                {
                    finalChoice = availableDoors
                        .First(d => d != playerChoice && d != montyOpens);
                }
                if (finalChoice == carDoor)
                    wins++;
            }
            return (wins, numberOfGames - wins);
        }
    }
}
