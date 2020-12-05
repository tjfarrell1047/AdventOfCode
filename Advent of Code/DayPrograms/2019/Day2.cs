using System;
using System.Collections.Generic;
using System.Linq;
using Advent_of_Code;

namespace AoC2019
{
    public class Day2
    {
        inputParser _ip;
        List<int> opsPure;

        public Day2(inputParser ip){
            _ip = ip;
            opsPure = _ip.input.Split(',').Select(int.Parse).ToList();

            Part1();
            Part2();
        }

        public void Part1(){
            List<int> ops = opsPure.GetRange(0, opsPure.Count);
            vMachine m = new vMachine(ops,12,2);
            m.Operate();
            Console.WriteLine("Part 1: " + m.returnOps()[0]);
        }

        public void Part2(){
            foreach (int noun in Enumerable.Range(0, 99)){
                foreach (int verb in Enumerable.Range(0, 99)){
                    List<int> ops = opsPure.GetRange(0, opsPure.Count);
                    vMachine m = new vMachine(ops, noun,verb);
                    m.Operate();
                    if(m.returnOps()[0] == 19690720){
                        Console.WriteLine("Part 2: " + (100 * noun + verb).ToString());
                        return;
                    }
                }
            }
            Console.WriteLine("Part 2: OOPS");
        }

    }

    public class vMachine{
        List<int> o;
        public vMachine(List<int> ops, int noun, int verb){
            o = ops;
            o[1] = noun;
            o[2] = verb;
        }
        public List<int> returnOps(){
            return o;
        }

        public void Operate(){
            int index = 0;
            int value1 = 0;
            int value2 = 0;
            int destination = 0;

            bool operate = true;
            while(operate){
                var op = o[index];
                switch(op){
                    case 1:
                        value1 = o[index+1];
                        value2 = o[index+2];
                        destination = o[index+3];
                        o[destination] = o[value1] + o[value2];
                        index += 4;
                        break;
                    case 2:
                        value1 = o[index+1];
                        value2 = o[index+2];
                        destination = o[index+3];
                        o[destination] = o[value1] * o[value2];
                        index += 4;
                        break;
                    case 99:
                        operate = false;
                        break;
                    default: break;
                }
            }

        }
    }
}