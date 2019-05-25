using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestPass = new Dictionary<string, string>();
            var userContestPoints = new SortedDictionary<string, Dictionary<string, int>>();

            var inputContestPass = string.Empty;

            while ((inputContestPass = Console.ReadLine()) != "end of contests")
            {
                var tokens = inputContestPass
                    .Split(":")
                    .ToArray();

                var contest = tokens[0];
                var pass = tokens[1];

                if (!contestPass.ContainsKey(contest))
                {
                    contestPass[contest] = pass;
                }
            }

            var inputNameContestPoints = string.Empty;

            while ((inputNameContestPoints = Console.ReadLine()) != "end of submissions")
            {
                var tokens = inputNameContestPoints
                    .Split("=>")
                    .ToArray();

                var contest = tokens[0];
                var pass = tokens[1];
                var name = tokens[2];
                var points = int.Parse(tokens[3]);

                if (contestPass.ContainsKey(contest) && contestPass[contest] == pass)
                {
                    if (!userContestPoints.ContainsKey(name))
                    {
                        userContestPoints[name] = new Dictionary<string, int>();
                    }

                    if (!userContestPoints[name].ContainsKey(contest))
                    {
                        userContestPoints[name][contest] = points;
                    }
                    else
                    {
                        if (userContestPoints[name][contest] < points)
                        {
                            userContestPoints[name][contest] = points;
                        }
                    }
                }
            }
            var maxSum = 0;
            var currentSum = 0;
            var bestCandicateName = string.Empty;

            foreach (var kvp in userContestPoints)
            {
                foreach (var kvp2 in kvp.Value)
                {
                    currentSum += kvp2.Value;
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestCandicateName = kvp.Key;                   
                }
                currentSum = 0;
            }

            Console.WriteLine($"Best candidate is {bestCandicateName} with total {maxSum} points.");

            Console.WriteLine("Ranking:");

            foreach (var kvp in userContestPoints)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var kvp2 in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp2.Key} -> {kvp2.Value}");
                }
            }
        }
    }
}
