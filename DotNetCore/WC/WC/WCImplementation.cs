using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            throw new NotImplementedException();
        }

        public int GetWordCount(string wordsToCount)
        {
            throw new NotImplementedException();
        }
    }
}
