using System;
using System.Collections.Generic;

namespace Anisble_problem_solving
{
    public class PrintSequence
    {
        static void Main(string[] args)
        {
            PrintSequence p = new PrintSequence();
            var seq= p.GenerateSequence(100);

            seq.ForEach(x => { Console.WriteLine(x.ToString()); });
            Console.ReadLine();
        }

        /// <summary>
        /// Generates sequence from 1 to counter, 
        /// If the number is divisible by 3 print “ Ansible” next to the number, 
        /// if the number is divisible by 5 print “ Australia” next to the number, 
        /// otherwise if the number is divisible by 3 and 5 print “ Ansible Australia” next to the number.
        /// </summary>
        /// <param name="counter"></param>
        /// <returns> List of strings</returns>
        public List<string> GenerateSequence(int counter)
        {
            List<string> outputSeq = new List<string>();
            for (int x = 1; x <= counter; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    outputSeq.Add(x.ToString() + " Ansible Australia");
                }
                else if (x % 3 == 0)
                {
                    outputSeq.Add(x.ToString()+ " Ansible");
                }
                else if (x % 5 == 0)
                {
                    outputSeq.Add(x.ToString()+ " Australia");
                }
                else
                {
                    outputSeq.Add(x.ToString());
                }
            }
            return outputSeq;
        }
    }
}
