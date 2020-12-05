using System;
using System.Collections.Generic;
using System.Linq;
using Advent_of_Code;

namespace AoC2020
{
     public class Day3
    {
        inputParser _ip;
        public Day3(inputParser ip){
            _ip = ip;
            Execute();
            //Part2();
        }

        public void Execute(){
            List<List<char>> trees = new List<List<char>>();
            foreach(string line in _ip.lines){
                trees.Add(line.ToCharArray().ToList());
            }
            List<Tuple<int,int>> slopes = new List<Tuple<int, int>>{
                new Tuple<int, int>(1,1),
                new Tuple<int, int>(3,1),
                new Tuple<int, int>(5,1),
                new Tuple<int, int>(7,1),
                new Tuple<int, int>(1,2),

            };
            
            int Part1Count = 0;
            long  TreeTotal = 0;
            foreach(Tuple<int,int> slope in slopes){
                int slopeX = slope.Item1;
                int slopeY = slope.Item2;

                int treeCount = 0;
                int width = trees[0].Count();
                int x = 0;
                int y = 0;

                while(y < trees.Count()){                
                    if(trees[y][x] == '#'){
                        treeCount++;
                    }
                    x = (x+slopeX) % width;
                    y = y + slopeY;
                }

                if(slopeX == 3 && slopeY == 1){
                    Part1Count = treeCount;
                }

                if(TreeTotal == 0){
                    TreeTotal = treeCount;
                }else{
                    TreeTotal = TreeTotal * treeCount;
                }
            }
            Console.WriteLine("Part 1: " + Part1Count.ToString());
            Console.WriteLine("Part 2: " + TreeTotal.ToString());


        }
    }
}