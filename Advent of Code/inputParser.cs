using System;

namespace Advent_of_Code
{
    public class inputParser{
        string path = Environment.CurrentDirectory + "\\inputs\\";
        public int year;
        public int day;
        public string inputURL;
        public string[] lines;
        public string input;
        public inputParser(int day, int year, bool example = false){
            this.day = day;
            this.year = year;
            inputURL = path + year.ToString() + "\\Day" + day.ToString() + (example ? "EX":"") + ".txt";
            lines = System.IO.File.ReadAllLines(inputURL);
            input = System.IO.File.ReadAllText(inputURL);
        }

    }
}