using System;
using System.Collections.Generic;
using System.Linq;
using Advent_of_Code;
using System.Text.RegularExpressions;

namespace AoC2020
{
     public class Day4
    {
        inputParser _ip;
        public Day4(inputParser ip){
            _ip = ip;
            Execute();
            //Part2();
        }

        public void Execute(){
            
            List<string> requiredAtts = new List<String>{
                "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"
            };

            int Part1ValidCount = 0;
            int Part2ValidCount = 0;

            string[] people = _ip.input.Split(new string[] { "\r\n\r\n" },
                               StringSplitOptions.RemoveEmptyEntries);

            foreach(string person in people){
                bool Part1Valid = true;
                bool Part2Valid = true;
                Dictionary<string, string> dict = new Dictionary<string, string>();
                List<string> attributes = person.Replace("\n", " ").Replace("\r\n", " ").Replace("\r", " ").Split(" ").ToList();
                foreach(string att in attributes){
                    if(att != ""){
                       dict.Add(att.Split(":")[0], att.Split(":")[1]);
                    }
                }

                foreach(string att in requiredAtts){
                    if(!dict.ContainsKey(att)){
                        Part1Valid = false;
                    }
                    if(Part1Valid && Part2Valid){
                        string attributeValue = dict[att];

                        Part2Valid = testValidity(att,attributeValue);
                    }else{
                        Part2Valid = false;
                    }
                    
                }
                if(Part1Valid){Part1ValidCount++;}
                if(Part2Valid){Part2ValidCount++;}
            }
            Console.WriteLine("Part 1: " + Part1ValidCount.ToString());
            Console.WriteLine("Part 2: " + Part2ValidCount.ToString());

        }

        public bool testValidity(string attribute,string attributeValue){
            List<string> eyeColors = new List<String>{
                "amb", "blu", "brn", "gry", "grn", "hzl", "oth"
            };

            int intAtt;
            switch (attribute){
                case "byr":
                    intAtt = int.Parse(attributeValue);
                    if(intAtt < 1920 || intAtt > 2002){
                        return false;
                    }
                    break;
                case "iyr":
                    intAtt = int.Parse(attributeValue);
                    if(intAtt < 2010 || intAtt > 2020){
                        return false;
                    }
                    break;
                case "eyr":
                    intAtt = int.Parse(attributeValue);
                    if(intAtt < 2020 || intAtt > 2030){
                        return false;
                    }
                    break;
                case "hgt":
                    int height = int.Parse(Regex.Replace(attributeValue, "[^0-9.]", ""));
                    if(attributeValue.Contains("cm")){
                        if(height < 150 || height > 193){
                            return false;
                        }
                    }
                    else if(attributeValue.Contains("in")){
                        if(height < 59 || height > 76){
                            return false;
                        }
                    }
                    else{
                        return false;
                    }
                    break;
                case "hcl":

                    if(!Regex.Match(attributeValue, "#[a-f 0-9]{6}").Success){
                        return false;
                    }
                    break;
                case "ecl":
                    if(!eyeColors.Contains(attributeValue)){
                        return false;
                    }
                    break;
                case "pid":
                    int i = 0;
                    if(!(int.TryParse(attributeValue,out i) && attributeValue.Length==9)){
                        return false;
                    }
                    break;
                case "cid":
                    break;        
            }

            return true;






        }


    }
}