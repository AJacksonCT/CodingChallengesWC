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
        public int GetByteCount(string fileName)
        {
            var fileBytes = File.ReadAllBytes(fileName);
            return GetByteCount(fileBytes);
        }
        public int GetByteCount(byte[] bytesToCount)
        {
            return bytesToCount.Length;
        }

        public int GetLineCount(string fileName)
        {
            var fileString = File.ReadLines(fileName);
            return GetLineCount(fileString);
        }

        public int GetLineCount(IEnumerable<string> linesToCount)
        {
            return linesToCount.Count();
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
    }
}
