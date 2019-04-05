using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isObtained = false;

            var dictKeyMaterials = new Dictionary<string, int>()
            {
                { "shards",0 },
                { "fragments",0 },
                { "motes",0 }
            };

            var dictJunkMaterials = new Dictionary<string, int>();

            string obtainedMaterial = string.Empty;

            while (!isObtained)
            {
                var arr = Console.ReadLine()
                .Split()
                .ToArray();

                int quantity = 0;

                for (int i = 0; i < arr.Length; i++)
                {

                    var type = string.Empty;

                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(arr[i]);
                    }
                    else
                    {
                        type = arr[i].ToLower();
                        if (type == "shards" || type == "fragments" || type == "motes")
                        {
                            if (dictKeyMaterials.ContainsKey(type))
                            {
                                dictKeyMaterials[type] += quantity;
                            }
                            else
                            {
                                dictKeyMaterials.Add(type, quantity);
                            }
                        }
                        else
                        {
                            if (dictJunkMaterials.ContainsKey(type))
                            {
                                dictJunkMaterials[type] += quantity;
                            }
                            else
                            {
                                dictJunkMaterials.Add(type, quantity);
                            }
                        }
                    }

                    foreach (var item in dictKeyMaterials)
                    {
                        if (item.Value >= 250)
                        {
                            obtainedMaterial = item.Key;
                            isObtained = true;
                            break;
                        }
                    }

                    if (isObtained)
                    {
                        break;
                    }
                }
            }

            if (obtainedMaterial == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (obtainedMaterial == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (obtainedMaterial == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            dictKeyMaterials[obtainedMaterial] -= 250;

            var dictKeyMaterials2 = dictKeyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            var dictJunkMaterials2 = dictJunkMaterials.OrderBy(x => x.Key);

            foreach (var item in dictKeyMaterials2)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in dictJunkMaterials2)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
