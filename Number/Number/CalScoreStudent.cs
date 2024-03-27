using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    internal class CalScoreStudent
    {
        static void Main(string[] args)
        {
            int student;
            int[] coursework;
            int[] midterm;
            int[] final;
            int[] sum;
            Console.Write("Please enter the number of students : ");
            student = Convert.ToInt32(Console.ReadLine());

            coursework = new int[student];
            midterm = new int[student];
            final = new int[student];
            sum = new int[student];
            //-----------------------------------------------------------------for
            for (int i = 0; i < student; i++)
            {
                Console.Write("Please enter coursework mark (30) of student#{0}: ", i + 1);
                coursework[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter midterm mark (30) of student#{0}: ", i + 1);
                midterm[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter final mark (40) of student#{0}: ", i + 1);
                final[i] = Convert.ToInt32(Console.ReadLine());

                sum[i] = coursework[i] + midterm[i] + final[i];
                Console.WriteLine("---------------------------------------------------------------------");
            }
            int j = 1;
            foreach (int sumScore in sum)
            {
                Console.WriteLine("Total marks of student#{0} : {1}", j, sumScore);
                j++;
            }


        }
    }
}
