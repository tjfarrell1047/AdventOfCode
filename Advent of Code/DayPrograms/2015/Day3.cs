using System;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;

namespace AoC2015
{
    public class Day3
    {
        inputParser _ip;
        public Day3(inputParser ip){
            _ip = ip;
            Execute();
            Execute2();
        }

        void Execute(){
            int x = 0;
            int y = 0;
            Dictionary<Tuple<int, int>, int> houses = new Dictionary<Tuple<int, int>, int>();
            houses.Add(new Tuple<int, int>(0,0), 1);
            foreach(char c in _ip.input){
                switch(c){
                    case '>':
                        x++;
                        break;
                    case '<':
                        x--;
                        break;
                    case 'v':
                        y--;
                        break;
                    case '^':
                        y++;
                        break;
                }
                Tuple<int,int> house = new Tuple<int,int>(x,y);
                if(!houses.ContainsKey(house)){
                    houses.Add(house,0);
                }
                houses[house] += 1;             
            }
            Dictionary<Tuple<int, int>, int> housesDelivered = houses.Where(p => p.Value > 0).ToDictionary(p => p.Key, p => p.Value);
            Console.WriteLine("Part 1: " + housesDelivered.Count());
        }

        void Execute2(){
            int santaX = 0;
            int santaY = 0;
            int roboX = 0;
            int roboY = 0;
            bool santa = true;
            Dictionary<Tuple<int, int>, int> houses = new Dictionary<Tuple<int, int>, int>();
            houses.Add(new Tuple<int, int>(0,0), 1);
            foreach(char c in _ip.input){
                switch(c){
                    case '>':
                        if(santa){santaX++;}else{roboX++;}
                        break;
                    case '<':
                        if(santa){santaX--;}else{roboX--;}
                        break;
                    case 'v':
                        if(santa){santaY++;}else{roboY++;}
                        break;
                    case '^':
                        if(santa){santaY--;}else{roboY--;}
                        break;
                }
                Tuple<int,int> house = santa ?  new Tuple<int,int>(santaX,santaY) : new Tuple<int,int>(roboX,roboY);
                if(!houses.ContainsKey(house)){
                    houses.Add(house,0);
                }
                houses[house] += 1;          
                santa = !santa;   
            }
            Dictionary<Tuple<int, int>, int> housesDelivered = houses.Where(p => p.Value > 0).ToDictionary(p => p.Key, p => p.Value);
            Console.WriteLine("Part 2: " + housesDelivered.Count());
        }
    }
}