using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication83
{
    class Program
    {
        static int[,] FillArray(int[,] results)
        {
            Random random = new Random();
            int Rnd = 0;
            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    if (i!=j)
                    {
                        do
                        {
                            Rnd = random.Next(0, 4);
                            results[i, j] = Rnd;

                        } while (Rnd==2);
                    }
                    else
                    {
                        results[i, j] = 0;
                    }
                }
            }
            return results;
        }

        static void ShowScore(int[,] results)
        {
            string [] teamNames = new string[6];
            teamNames[0] = "Man Utd";
            teamNames[1] = "Arsenal";
            teamNames[2] = "Chelsea";
            teamNames[3] = "Fullham";
            teamNames[4] = "Pool\t";
            teamNames[5] = "Burnley";

            Console.WriteLine("\tMACFPB");
            for (int i = 0; i < results.GetLength(0); i++)
            {
                Console.WriteLine(teamNames[i]);
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    Console.Write(results[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void ContainsTeam(string choice)
        {
            Console.WriteLine("Please enter the name of your team to show you the index");
            switch (choice=Console.ReadLine())
            {
                case "Mand Utd":Console.WriteLine("1");break;
                case "Arsenal": Console.WriteLine("2"); break;
                case "Chelsea": Console.WriteLine("3"); break;
                case "Fullham": Console.WriteLine("4"); break;
                case "Pool": Console.WriteLine("5"); break;
                case "Burnley": Console.WriteLine("6"); break;
                default:Console.WriteLine("-1 invalid team");break;
            }
        }


        static void Main(string[] args)
        {
            int[,] results = new int[6, 6];
            int[,] FilledResults = FillArray(results);
            ShowScore(FilledResults);
            string choice = null;
            ContainsTeam(choice);
            Console.ReadLine();

            
        }
    }
}

