using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
