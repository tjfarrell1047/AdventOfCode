using System;
using Advent_of_Code;

namespace AoC2019
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
            decimal total = 0;
            foreach(string line in _ip.lines){
                total += Math.Floor(Convert.ToDecimal(line) / 3) - 2;
            }
            Console.WriteLine("Part 1: " + total.ToString());
        }

        public void Part2(){
            decimal total = 0;
            decimal currentFuel = 0;

            foreach(string line in _ip.lines){
                currentFuel = Math.Floor(Convert.ToDecimal(line) / 3) - 2;

                while(currentFuel > 0){
                    total += currentFuel;
                    currentFuel = Math.Floor(currentFuel / 3) - 2;
                }

            }
            Console.WriteLine("Part 2: " + total.ToString());
        }


    }
}