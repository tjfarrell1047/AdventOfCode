using System;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;

namespace AoC2015
{
    public class Day1
    {
        inputParser _ip;
        public Day1(inputParser ip){
            _ip = ip;
            Execute();
        }

        void Execute(){
            int counter = 0;
            int goal = 0;
            int floor = 0;
            bool found = false;
            foreach(char c in _ip.input){
                counter++;
                switch(c){
                    case '(':
                        floor++;
                        break;
                    case ')':
                        floor--;
                        break;
                }
                if(floor == -1 && !found){
                    goal = counter;
                    found = true;
                }
            }
            Console.WriteLine("Part 1: " + floor.ToString());
            Console.WriteLine("Part 2: " + goal.ToString());
        }
    }

}