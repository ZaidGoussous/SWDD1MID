using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication74
{
    class Program
    {
      

        static int[,] Fill_Array(int[,] results)
        {
            Random rnd = new Random();//creating a new instance of Random 
            int tempRnd = 0;//variable for storing the value of Random.Next for the while loop to know when to exit (exclude number 2)
            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    if (i != j) //when i and j is different so e.g (results[1,3]) we assign a random number to that cell which cant be 2
                    {
                        do
                        {
                            tempRnd = rnd.Next(0, 4);
                            results[i, j] = tempRnd;

                        } while (tempRnd == 2);//Thats where the code runs to generate a number from 1-3 except 2!
                    }
                    else // this code runs when i and j are equal like (results[2,2]) because in that case the value has to be 0 (in the task it is mentioned as results[i,i])
                    {
                        results[i, j] = 0;
                    }
                }
            }
            return results;//we return the array the we gave as an input to the function after it is filled up
        }
       
        static void Show_Scores(int[,] results)
        {
            Console.WriteLine("\tMACFPB");// "\t" writes a tab in front of the character sequence that is coming after it this is so that it appears right above the numbers 
            for (int i = 0; i < results.GetLength(0); i++)
            {
                switch (i)//the switch will vary upon the value of i, the cases are in order according to the picture so in the first row "Man Utd" will go etc.
                {
                    case 0: Console.Write("Man Utd "); break;
                    case 1: Console.Write("Arsenal "); break;
                    case 2: Console.Write("Chelsea "); break;
                    case 3: Console.Write("Fullham "); break;
                    case 4: Console.Write("Pool\t"); break;
                    case 5: Console.Write("Burnley "); break;
                }
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    Console.Write(results[i, j]);//this is when we are actually writing out each cell in the array
                }
                Console.WriteLine();
            }
        }

        static string contains_team(string choice) //the string where I reply with the index number
        {
            Console.WriteLine("Enter the name of your team");
            switch (choice = Console.ReadLine())
            {
                case "Man Utd": Console.WriteLine("The index of your team is 1"); break;
                case "arsenal": Console.WriteLine("The index of your team is 2"); break;
                case "Chelsea": Console.WriteLine("The index of your team is 3"); break;
                case "Fullham": Console.WriteLine("The index of your team is 4"); break;
                case "Pool": Console.WriteLine("The index of your team is 5"); break;
                case "Burnley": Console.WriteLine("The index of your team is 6"); break;
                default: Console.WriteLine("-1"); break;

            }
            return null;
        }

    

        static void Main(string[] args)
        {
            int[,] results = new int[6, 6];//this is where we initalize the empty array
            int[,] filledResults = Fill_Array(results);//in filledResults array we store the results array after it is
            //being filled up since the "Fill_Array" is returning an array that we can store an int array type variable
            Show_Scores(filledResults);//here we call the "Show_Scores" function that prints out the array
            string choice = null;
            contains_team(choice);
           
            

            Console.ReadLine();
        }

       
    }
}

