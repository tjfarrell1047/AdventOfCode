using System;
using System.Collections.Generic;
using System.Linq;
using Advent_of_Code;

namespace AoC2020
{
     public class Day1
    {
        inputParser _ip;
        public Day1(inputParser ip){
            _ip = ip;
            Part1();
            Part2();
        }

        public void Part1(){
            int x = 0;
            int y = 0;


            foreach(string lineX in _ip.lines){
                int valX = int.Parse(lineX);
                foreach(string lineY in _ip.lines){
                    if(x!=y){
                        int valY = int.Parse(lineY);
                        if(valX + valY == 2020){
                            Console.WriteLine("Part 1: " + (valX*valY).ToString());
                            return;
                        }
                    }
                    y++;
                }
                x++;
            }
        }

        public void Part2(){
            int x = 0;
            int y = 0;
            int z = 0;

            foreach(string lineX in _ip.lines){
                int valX = int.Parse(lineX);
                foreach(string lineY in _ip.lines){
                    if(x != y){
                        int valY = int.Parse(lineY);
                        if(valX + valY < 2020){
                            foreach(string lineZ in _ip.lines){
                                
                                if(x != y && y != z && z != x){
                                    int valZ = int.Parse(lineZ);
                                     if(valX + valY + valZ == 2020){
                                        Console.WriteLine("Part 2: " + (valX*valY*valZ).ToString());
                                        return;
                                    }

                                }
                            }
                            z++;                       
                        }
                    }                    
                     y++;                         
                }
                x++;
            }
        }
    }
}
