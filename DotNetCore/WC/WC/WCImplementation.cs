using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WC
{
    public class WcImplementation
    {
        public string FileName { get; set; } = "";

        public int GetByteCount()
        {
            return GetByteCountFromFile(FileName);
        }
        public int GetByteCountFromFile(string fileName)
        {
            var fileBytes = File.ReadAllBytes(fileName);
            return GetByteCount(fileBytes);
        }
        public int GetByteCount(byte[] bytesToCount)
        {
            return bytesToCount.Length;
        }

        public int GetLineCount()
        {
            return GetLineCountFromFile(FileName);
        }
        public int GetLineCountFromFile(string fileName)
        {
            var fileString = File.ReadLines(fileName);
            return GetLineCount(fileString);
        }
        public int GetLineCount(IEnumerable<string> linesToCount)
        {
            return linesToCount.Count();
        }

        public int GetWordCount()
        {
            return GetWordCountFromFile(FileName);
        }
        public int GetWordCountFromFile(string fileName)
        {
            var fileString = File.ReadAllText(fileName);
            return GetWordCount(fileString??"");
        }

        public int GetWordCount(string wordsToCount)
        {
            var count = 0;
           
            wordsToCount = wordsToCount.ReplaceLineEndings(" ");
            while (wordsToCount.Contains("  "))
            {
                wordsToCount = wordsToCount.Replace("  ", " ");
            }

            foreach (var character in wordsToCount.ToCharArray())
            {
                if (character == ' ')
                    count++;
            }
            return count;

            //var splitWords = wordsToCount.Split(" ");

            //return splitWords.Length;
        }

        public int GetCharacterCount()
        {
            return GetCharacterCountFromFile(FileName);
        }
        public int GetCharacterCount(string charactersToCount)
        {
            return charactersToCount.Length;
        }

        public int GetCharacterCountFromFile(string fileName)
        {
            var fileString = File.ReadAllText(fileName);
            return GetCharacterCount(fileString ?? "");
        }

        public string HandleArgs(string? fileName, string? input, string[] args)
        {
            if (fileName is not null)
            {
                return HandleArgsFromFile(fileName, args);
            }
            else
            {
                return HandleArgs(input ?? "", args);
            }
        }

        public string HandleArgs(string input, string[] args)
        {
            var returnValue = "";
            
            foreach (var arg in args)
                switch (arg.ToLower())
                {
                    case "-c":
                    {

                        returnValue += GetByteCount(Encoding.ASCII.GetBytes(input));
                        break;
                    }
                    case "-l":
                    {
                        returnValue += GetLineCount(input.Split(Environment.NewLine));
                        break;
                    }
                    case "-w":
                    {
                        returnValue += GetWordCount(input);
                        break;
                    }
                    case "-m":
                    {
                        returnValue += GetCharacterCount(input);
                        break;
                    }
                    default:
                    {
                        returnValue += GetByteCount(Encoding.ASCII.GetBytes(input));
                        returnValue += "     " + input.Split(Environment.NewLine);
                        returnValue += "     " + GetWordCount(input);
                        break;
                    }
                }
            returnValue += "     " + input;

            return returnValue;
        }

        public string HandleArgsFromFile(string fileName, string[] args)
        {
            var returnValue = "";

            foreach (var arg in args)
                switch (arg.ToLower())
                {
                    case "-c":
                    {

                        returnValue += GetByteCountFromFile(fileName);
                        break;
                    }
                    case "-l":
                    {
                        returnValue += GetLineCountFromFile(fileName);
                        break;
                    }
                    case "-w":
                    {
                        returnValue += GetWordCountFromFile(fileName);
                        break;
                    }
                    case "-m":
                    {
                        returnValue += GetCharacterCountFromFile(fileName);
                        break;
                    }
                    default:
                    {
                        returnValue += GetByteCountFromFile(fileName);
                        returnValue += "     " + GetLineCountFromFile(fileName);
                        returnValue += "     " + GetWordCountFromFile(fileName);
                        break;
                    }
                }
            returnValue += "     " + fileName;

            return returnValue;
        }
    }

    }

