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
                var arr = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = arr[0];
                string username = arr[1];

                if (command == "register")
                {
                    string licensePlateNumber = arr[2]; 
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
                else if (command == "unregister")
                {
                    if (dict.ContainsKey(username))
                    {
                        dict.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var kpv in dict)
            {
                Console.WriteLine($"{kpv.Key} => {kpv.Value}");
            }
        }
    }
}
