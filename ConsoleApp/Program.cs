using System;
using kmolenda.aisd.GraphLib;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGraphUnidirectedNonWeightedAdjacencyList();
        }

        static void TestGraphUnidirectedNonWeightedAdjacencyList()
        {
            string[] lines = new string[]
            {
                "..###.....#####.....#####",
                "..###.....#####.....#####",
                "..###.....#####.....#####",
                "...........###......#####",
                "......###...........#####",
                "...#..###..###......#####",
                "###############.#######..",
                "###############.#######.#",
                "###############.#######..",
                "................########.",
                "................#######..",
                "...#######..##.......##.#",
                "...#######..##.......##..",
                "...##...........########.",
                "#####...........#######..",
                "#####...##..##..#...#...#",
                "#####...##..##....#...#.."
            };
            bool[][] map = new bool[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                map[i] = lines[i].Select(c => c.ToString() == ".").ToArray();
            }
            foreach (var x in map)
            {
                foreach (var z in x)
                {
                    Console.WriteLine(z);
                }
            }

            var graph = new GraphNonWeightedAdjacencyList<int, EdgeNonWeighted<int> >();
            for(int i = 0; i < map.Length; i++)
            {
                for(int j = 0; j < map[i].Length; j++)
                {
                    var vertices[] = graph.AddVertex($"{i}-{j}");
                }
            }
            Console.WriteLine( graph.ToString<int>() );

        }
    }
}
