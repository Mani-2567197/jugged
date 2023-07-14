using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // creating jugged array 
             int[][] studentscores = new int[3][];
             studentscores[0] = new int[3] { 85, 92, 78 };
             studentscores[1] = new int[4] { 90,87,93,89 };
             studentscores[2] = new int[2] {76,88};

            // retriving the values by using nested loops
            double sum = 0, avg = 0, allsum = 0, allavg = 0;
            for (int i = 0; i <3; i++)
             {
                Console.WriteLine($"Student{i + 1} Marks");
                Console.WriteLine("======================================================");
                for (int j = 0; j < studentscores[i].Length; j++)
                 {
                    
                    sum += studentscores[i][j];
                    avg = sum/ studentscores[i].Length;
                    Console.WriteLine(studentscores[i][j] + "\t");
                   
                }
                Console.WriteLine("======================================================");
                Console.WriteLine($"Average score of student {i + 1} is:\t"+avg);
                Console.WriteLine("======================================================");
                allsum += avg;
                sum = 0;
                avg = 0;
                allavg = allsum / 3;
                
             }
            Console.WriteLine("=====================================================");
            Console.WriteLine("Average score of all students:\t"+allavg);

            Console.ReadKey();
        }
    }
}
