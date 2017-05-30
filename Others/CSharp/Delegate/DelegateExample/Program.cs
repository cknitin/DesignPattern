using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public class PlayerStats
    {
        public string Name { get; set; }
        public int Kills { get; set; }
        public int Life { get; set; }
        public int FlagCaptured { get; set; }

    }

    public class DisplayPlayerName
    {
        delegate int ScoreDelegate(PlayerStats playerStat);

        public void OnGameOver(PlayerStats[] allPlayerStats)
        {
            // Ordinary Code
            string playerNameMostKills = GetPlayerNameMostKills(allPlayerStats);
            string playerNameMostFlagCaptured = GetPlayerNameMostFlagCaptured(allPlayerStats);
            Console.WriteLine("--- Ordinary Code ---");
            Console.WriteLine(string.Format("Player Name Most Kills# {0} and Player Name Most FlagCaptured# {1}", playerNameMostKills, playerNameMostFlagCaptured));

            // Using Delegate
            string mostKilled = GetPlayerNameTopScore(allPlayerStats, ScoreByKillCount);
            string mostFlagCaptured = GetPlayerNameTopScore(allPlayerStats, ScoreByFlagCapturedCount);
            Console.WriteLine("--- Using Delegate ---");
            Console.WriteLine(string.Format("Player Name Most Kills# {0} and Player Name Most FlagCaptured# {1}", mostKilled, mostFlagCaptured));


            // Using Delegate another approch
            string mostKilled1 = GetPlayerNameTopScore(allPlayerStats, stat => stat.Kills);
            string mostFlagCaptured1 = GetPlayerNameTopScore(allPlayerStats, stat => stat.FlagCaptured);
            Console.WriteLine("--- Using Delegate another approch ---");
            Console.WriteLine(string.Format("Player Name Most Kills# {0} and Player Name Most FlagCaptured# {1}", mostKilled1, mostFlagCaptured1));


        }


        int ScoreByKillCount(PlayerStats playerStat)
        {
            return playerStat.Kills;
        }

        int ScoreByFlagCapturedCount(PlayerStats playerStat)
        {
            return playerStat.FlagCaptured;
        }


        string GetPlayerNameTopScore(PlayerStats[] allPlayerStats, ScoreDelegate scoreCalculator)
        {

            int bestScore = 0;
            string playerName = string.Empty;

            foreach (var playerStat in allPlayerStats)
            {
                int score = scoreCalculator(playerStat);

                if (score > bestScore)
                {
                    bestScore = score;
                    playerName = playerStat.Name;
                }

            }
            return playerName;
        }



        string GetPlayerNameMostFlagCaptured(PlayerStats[] allPlayerStats)
        {
            int bestScore = 0;
            string playerName = string.Empty;

            foreach (var playerStat in allPlayerStats)
            {

                int score = playerStat.FlagCaptured;

                if (score > bestScore)
                {
                    bestScore = score;
                    playerName = playerStat.Name;
                }

            }
            return playerName;
        }


        string GetPlayerNameMostKills(PlayerStats[] allPlayerStats)
        {
            int bestScore = 0;
            string playerName = string.Empty;

            foreach (var playerStat in allPlayerStats)
            {

                int score = playerStat.Kills;

                if (score > bestScore)
                {
                    bestScore = score;
                    playerName = playerStat.Name;
                }

            }
            return playerName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerName displayGame = new DisplayPlayerName();

            PlayerStats[] allPlayerStats = new PlayerStats[5];
            allPlayerStats[0] = new PlayerStats { Name = "Ninja", Life = 5, FlagCaptured = 100, Kills = 50 };
            allPlayerStats[1] = new PlayerStats { Name = "Doctor Dang", Life = 5, FlagCaptured = 101, Kills = 10 };
            allPlayerStats[2] = new PlayerStats { Name = "Mortar", Life = 5, FlagCaptured = 50, Kills = 500 };
            allPlayerStats[3] = new PlayerStats { Name = "Jackal", Life = 5, FlagCaptured = 10, Kills = 5000 };
            allPlayerStats[4] = new PlayerStats { Name = "Markol", Life = 5, FlagCaptured = 100, Kills = 50 };


            displayGame.OnGameOver(allPlayerStats);

            Console.ReadLine();
        }
    }
}
