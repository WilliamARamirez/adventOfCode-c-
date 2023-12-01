using System;
using System.IO;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventOfCode
{
    public class Day01
    {
        private string _path = "/Users/williamramirez/Projects/AdventOfCode/AdventOfCode/Day01/Day01.txt";
        private List<int> _inputs;

        private HashSet<string> set = new HashSet<string>() {"zero","one","two", "three", "four", "five", "six", "seven", "eight", "nine" };


        public Day01()
		{
            List<string> strings = File.ReadAllLines(_path).Select(v => v).ToList();
            List<int> nums = new List<int>();
            
            strings.ForEach(s =>
            {
                string numStringLine = "";

                for (int i = 0; i < s.Length; i++)
                {
                    bool success = int.TryParse(s[i].ToString(), out var calorie);
                    if (success)
                    {
                        numStringLine = numStringLine + s[i].ToString();
                    }
                    if(i == s.Length - 1)
                    {
                        if(numStringLine.Length == 1)
                        {
                            string twoStringLine = numStringLine[0].ToString() + numStringLine[0].ToString();
                            nums.Add(int.Parse(twoStringLine));
                        }
                        else
                        {
                            string twoStringLine = numStringLine[0].ToString() + numStringLine[numStringLine.Length - 1].ToString();
                            nums.Add(int.Parse(twoStringLine));
                        }

                      
                    }
                }
            });
            int sum = 0;
            nums.ForEach(n => sum = sum + n);

            
            Console.WriteLine(sum);
            Console.ReadLine();

        }
	}
}

