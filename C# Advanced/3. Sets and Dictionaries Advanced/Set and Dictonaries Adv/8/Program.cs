using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictPass = new Dictionary<string, string>();
            var dictStrudents = new Dictionary<string, Dictionary<string, int>>();

            string inputPass = string.Empty;

            while ((inputPass = Console.ReadLine()) != "end of contests")
            {
                var tokens = inputPass.Split(":").ToArray();
                string contest = tokens[0];
                string pass = tokens[1];

                dictPass[contest] = pass;
            }

            string inputContestMark = string.Empty;

            while ((inputContestMark = Console.ReadLine()) != "end of submissions")
            {
                var tokens = inputContestMark
                    .Split("=>")
                    .ToArray();

                string contest = tokens[0];
                string pass = tokens[1];
                string name = tokens[2];
                int points = int.Parse(tokens[3]);

                if (dictPass.ContainsKey(contest) && dictPass[contest] == pass)
                {
                    if (!dictStrudents.ContainsKey(name))
                    {
                        dictStrudents[name] = new Dictionary<string, int>();
                    }

                    if (!dictStrudents[name].ContainsKey(contest))
                    {
                        dictStrudents[name][contest] = points;
                    }
                    else if (dictStrudents[name][contest] < points)
                    {
                        dictStrudents[name][contest] = points;
                    }                       
                }
                else
                {
                    continue;
                }
            }
            //string naaame = string.Empty;
            //var name1 = dictStrudents.OrderByDescending(s => s.Value.OrderByDescending(y => y.Value).ToDictionary(x => x.Key, x => x.Value));
            //if (name1 != null)
            //{
            //    naaame = $"{name1.FirstOrDefault().Key}";
            //}

            //Console.WriteLine(naaame);

            int currentPoints = 0;
            string bestCandidateName = string.Empty;
            int bestCandidatePoints = 0;

            foreach (var kvp in dictStrudents)
            {
                foreach (var kvp2 in kvp.Value)
                {
                    currentPoints += kvp2.Value;
                }

                if (currentPoints > bestCandidatePoints)
                {
                    bestCandidatePoints = currentPoints;
                    bestCandidateName = kvp.Key;
                }

                currentPoints = 0;
            }

            Console.WriteLine($"Best candidate is {bestCandidateName} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var kvp in dictStrudents.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var kvp2 in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp2.Key} -> {kvp2.Value}");
                }
            }
        }
    }
}
