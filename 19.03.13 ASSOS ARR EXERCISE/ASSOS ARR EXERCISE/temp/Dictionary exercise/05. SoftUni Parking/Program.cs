using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                string registerOrUnregister = tokens[0];
                string username = tokens[1];
                

                if (registerOrUnregister == "register")
                {
                    string licensePlateNumber = tokens[2];

                    if (!dict.ContainsKey(username))
                    {
                        dict[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dict[username]}");
                    }
                }
                else if (registerOrUnregister == "unregister")
                {
                    if (!dict.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        dict.Remove(username);
                    }
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
