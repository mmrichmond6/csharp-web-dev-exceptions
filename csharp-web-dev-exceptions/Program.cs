using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        private static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("y", "You cannot divide by zero!");
            }
            else
            {
                double score = Math.Round(x / y * 100);
                return score;
            }
        }
        
        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName == null || fileName =="")
            {
                throw new ArgumentNullException("fileName", "You must turn in a file to be reviewed!");
            }
            else
            {
                string substr = fileName.Substring(fileName.Length - 3, 3);
                if (substr == ".cs")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            double num1 = 8;
            double num2 = 0;

            try
            {
                Divide(num1, num2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.js");

            foreach (string s in students.Values)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(s));
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            

        }
    }
}
