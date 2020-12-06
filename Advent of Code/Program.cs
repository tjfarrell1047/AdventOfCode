using System;
using AoC2019;

namespace Advent_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.Write("It's AoC! Choose a year:");
            // int year = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Choose a day:");
            // int day = Convert.ToInt32(Console.ReadLine());

            int day = 6;
            int year = 2020;
            bool useEx = false;

            inputParser ip = new inputParser(day, year,useEx);
            switch(year){
                case 2015:
                    y2015(ip);
                    break;
                case 2019:
                    y2019(ip);
                    break;
                case 2020:
                    y2020(ip);
                    break;
                default: 
                    Console.WriteLine("Nothing here!");
                    break;
            }
        }

        static void y2015(inputParser ip){
            switch(ip.day){
                case 1:
                    Console.WriteLine("2015 Day 1");
                    AoC2015.Day1 d1 = new AoC2015.Day1(ip);
                    break;
                case 2:
                    Console.WriteLine("2015 Day 2");
                    AoC2015.Day2 d2 = new AoC2015.Day2(ip);
                    break;
                case 3:
                    Console.WriteLine("2015 Day 3");
                    AoC2015.Day3 d3 = new AoC2015.Day3(ip);
                    break;
                default: 
                    Console.WriteLine("Nothing here!");
                    break;
            }
        }
        static void y2019(inputParser ip){
            switch(ip.day){
                case 1:
                    Console.WriteLine("2019 Day 1");
                    AoC2019.Day1 d1 = new AoC2019.Day1(ip);
                    break;
                case 2:
                    Console.WriteLine("2019 Day 2");
                    AoC2019.Day2 d2 = new AoC2019.Day2(ip);
                    break;
                default: 
                    Console.WriteLine("Nothing here!");
                    break;
            }
        }

        static void y2020(inputParser ip){
            switch(ip.day){
                case 1:
                    Console.WriteLine("2020 Day 1");
                    AoC2020.Day1 d1 = new AoC2020.Day1(ip);
                    break;
                case 2:
                    Console.WriteLine("2020 Day 2");
                    AoC2020.Day2 d2 = new AoC2020.Day2(ip);
                    break;
                case 3:
                    Console.WriteLine("2020 Day 3");
                    AoC2020.Day3 d3 = new AoC2020.Day3(ip);
                    break;
                case 4:
                    Console.WriteLine("2020 Day 4");
                    AoC2020.Day4 d4 = new AoC2020.Day4(ip);
                    break;
                 case 5:
                     Console.WriteLine("2020 Day 5");
                     AoC2020.Day5 d5 = new AoC2020.Day5(ip);
                     break;
                 case 6:
                     Console.WriteLine("2020 Day 6");
                     AoC2020.Day6 d6 = new AoC2020.Day6(ip);
                     break;             
                // case 7:
                //     Console.WriteLine("2020 Day 7");
                //     AoC2020.Day7 d7 = new AoC2020.Day7(ip);
                //     break;
            }
        }

    }
}
