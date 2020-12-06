using System;
using System.Collections.Generic;
using System.Linq;
using Advent_of_Code;
using System.Text.RegularExpressions;

namespace AoC2020
{
     public class Day6
    {
        inputParser _ip;
        public Day6(inputParser ip){
            _ip = ip;
            Execute();
            //part1();
            //part2();
        }

        public void Execute(){
            int P1Count = 0;
            int P2Count = 0;
            HashSet<int> answers = new HashSet<int>();
            string[] groups = _ip.input.Split(new string[] { "\r\n\r\n" },
                               StringSplitOptions.RemoveEmptyEntries);
           

            foreach(string group in groups){
                foreach (char c in group.Replace("\r\n", "")){
                    answers.Add(c);
                }
                P1Count += answers.Count();
                answers.Clear();
            }
            

            foreach(string group in groups)
                {
                    foreach (char c in group.Replace("\r\n", "")){
                        answers.Add(c);
                    }

                    foreach (string person in group.Split(new string[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries)){
                        foreach(char c in answers.ToList())
                        {
                            if (person.IndexOf(c) == -1)
                                answers.Remove(c);
                        }
                    }

                P2Count += answers.Count();
            }
            
            Console.WriteLine("Part 1: " + P1Count);
            Console.WriteLine("Part 2: " + P2Count);

        }

    }
}