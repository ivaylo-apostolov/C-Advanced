using System;
using System.Linq;

namespace _04._Team
{
    class StrartUp
    {
        static void Main(string[] args)
        {
            int personNumber = int.Parse(Console.ReadLine());

            var team = new Team("Machines");

            for (int i = 0; i < personNumber; i++)
            {
                var arr = Console.ReadLine()
                    .Split()
                    .ToArray();

                var player = new Person(arr[0], arr[1], int.Parse(arr[2]), double.Parse(arr[3]));
                team.AddPlayer(player);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

            Console.WriteLine();
        }
    }
}
