using System;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;

namespace AoC2015
{
    public class Day2
    {
        inputParser _ip;
        public Day2(inputParser ip){
            _ip = ip;
            Execute();
        }

        void Execute(){
            int paperTotal = 0;
            int ribbonTotal = 0;
            foreach(string str in _ip.lines){
                List<int> dims = str.Split('x').Select(int.Parse).ToList(); 
                List<int> sortedDims = dims.GetRange(0, dims.Count);  
                sortedDims.Sort();    
                int l,w,h, min;
                l = dims[0];
                w = dims[1];
                h = dims[2];
                List<int> sides = new List<int>{l*w, w*h, h*l};
                min = sides.Min();
                paperTotal += (2*sides[0]) + (2*sides[1]) + (2*sides[2]) + min;
                ribbonTotal += (2*sortedDims[0]) + (2*sortedDims[1]) + (l*w*h);
            }
            Console.WriteLine("Part 1: " + paperTotal.ToString());
            Console.WriteLine("Part 2: " + ribbonTotal.ToString());
        }
    }

}