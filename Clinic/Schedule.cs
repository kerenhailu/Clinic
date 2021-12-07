using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    internal class Schedule
    {
        
      //public static void array()
      //  {
      //      int[,] diary = new int[4, 7];
      //      Random Random = new Random();
      //      for (int i = 0; i < diary.GetLength(0); i++)
      //      {
      //          Console.WriteLine($"diary : {i}  ");
      //          for (int j = 0; j < diary.GetLength(1); j++)
      //          {
      //              diary[i, j] = Random.Next(1, 10);
      //          }
      //      }
      //  }
        public static void fiveCase(int numDays,int numWeeks)
        {
            int[,] diary = new int[numWeeks, numDays];
            Random Random = new Random();
            for (int i = 0; i < diary.GetLength(0); i++)
            {
                for (int j = 0; j < diary.GetLength(1); j++)
                {
                    diary[i, j] = Random.Next(1, 10);
                }
            }

            for (int i = 0; i < diary.GetLength(0); i++)
            {
                Console.WriteLine($"diary : {i}  ");
                for (int j = 0; j < diary.GetLength(1); j++)
                {
                    if (j == 6)
                    {
                        diary[i, 6] = 0;
                    }
                    else
                    {
                        diary[i, j] = Random.Next(1, 10);

                    }
                    Console.Write($" {diary[i, j]} ");
                    
                }Console.WriteLine();
            }
            
        }

        public static void sixCase(int numDays, int numWeeks)
        {
            int[,] diary = new int[numWeeks,numDays];
            Random Random = new Random();
            for (int i = 0; i < diary.GetLength(0); i++)
            {
                for (int j = 0; j < diary.GetLength(1); j++)
                {
                    diary[i, j] = Random.Next(1, 10);
                }
            }
            //string text = "bussy";
            for (int i = 0; i < diary.GetLength(0); i++)
            {
                Console.WriteLine($"diary : {i}  -");
                for (int j = 0; j < diary.GetLength(1); j++)
                {
                    if (j >= 5)
                    {
                        diary[i, j] = 888;
                        //diary[i, j] = sprintf(diary[i, j], "%d", text);
                    }
                    else
                    {
                        diary[i, j]=diary[i,j];
                    }
                    Console.Write(diary[i, j]);
                    Console.WriteLine();
                }
            }
        }
    }
}
