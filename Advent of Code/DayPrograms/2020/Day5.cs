using System;
using System.Collections.Generic;
using System.Linq;
using Advent_of_Code;
using System.Text.RegularExpressions;

namespace AoC2020
{
     public class Day5
    {
        inputParser _ip;
        public Day5(inputParser ip){
            _ip = ip;
            Execute();
        }

        public void Execute(){
            
            int lowerRowStart = 0;
            int upperRowStart = 127;
            int lowerColStart = 0;
            int upperColStart = 7;
            // (row, column), seatID
            Dictionary<Tuple<decimal,decimal>, decimal> seats = new Dictionary<Tuple<decimal, decimal>, decimal>();
            foreach(string line in _ip.lines){
                char[] array = line.ToCharArray();
                decimal lowRow = lowerRowStart;
                decimal upRow = upperRowStart;
                decimal lowCol = lowerColStart;
                decimal upCol = upperColStart;
                decimal row = 0;
                decimal col = 0;
                for(int i = 0; i < 7; i++){
                    char instruction = array[i];
                    switch(instruction){
                        case 'F':
                            upRow = lowRow + Math.Floor((upRow-lowRow)/2);
                            break;
                        case 'B':
                            lowRow = lowRow + Math.Ceiling((upRow-lowRow)/2);
                            break;

                    }
                    //Console.WriteLine(instruction + " " + lowRow.ToString() + " " + upRow.ToString());
                }
                if(array[6] == 'F'){row = lowRow;}else{row = upRow;}
                for(int i = 7; i < 10; i++){
                    char instruction = array[i];
                    switch(instruction){
                        case 'L':
                            upCol = lowCol + Math.Floor((upCol-lowCol)/2);
                            break;
                        case 'R':
                            lowCol = lowCol + Math.Ceiling((upCol-lowCol)/2);
                            break;

                    }
                }
                if(array[9] == 'L'){col = lowCol;}else{col = upCol;}

                seats.Add(new Tuple<decimal, decimal>(row,col), (row*8) + col);
            }
            List<Tuple<decimal, decimal>> list = seats.Keys.ToList().OrderBy(x => x.Item1).ThenBy(x=> x.Item2).ToList();
            decimal lowest = list[0].Item1;
            decimal highest = list[list.Count-1].Item1;

            decimal missingValue = 0;
            for(decimal i = lowest + 1; i < highest; i++){
                List<Tuple<decimal, decimal>> subset = list.Where(x => x.Item1 == i).ToList();
                if(subset.Count != 8){

                    for(decimal x = 0; x < 8; x++){
                        if(!subset.Contains(new Tuple<decimal, decimal>(i,x))){
                            Console.WriteLine("Missing Seat:"+ i + " " + x);
                            missingValue = (i * 8) + x;
                        }
                    }
                }

            }  
            Console.WriteLine("Part 1: " + seats.Values.Max());
            Console.WriteLine("Part 2: " + missingValue);

        }

    }
}