using System;
using System.Collections.Generic;
using System.Linq;
using Advent_of_Code;

namespace AoC2020
{
     public class Day2
    {
        inputParser _ip;
        public Day2(inputParser ip){
            _ip = ip;
            Execute();
            //Part2();
        }

        public void Execute(){
            int validCount = 0;
            int validCount2 = 0;
            foreach(string line in _ip.lines){

                //Split line into password and policy
                string password = line.Split(":")[1].Trim();
                string policy = line.Split(":")[0].Trim();

                int min = int.Parse(policy.Split(" ")[0].Split("-")[0]);
                int max = int.Parse(policy.Split(" ")[0].Split("-")[1]);              
                char letter = char.Parse(policy.Split(" ")[1]);
                int count = password.Count(x => x == letter);

                if(count >= min && count <= max){
                    validCount++;
                }

                char positionA = password[min - 1];
                char positionB = password[max - 1];
                if(                    
                    (positionA == letter && positionB != letter) || 
                    (positionA != letter && positionB == letter)                   
                    ){
                    validCount2++;
                }

                
            }
            Console.WriteLine("Part 1: " + validCount.ToString());
            Console.WriteLine("Part 2: " + validCount2.ToString());
        }
    }
}