﻿using System.IO;
using System.Text;

namespace HDF5.NET
{
    public static class H5Utils
    {
        public static bool IsPowerOfTwo(ulong x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

        public static ulong FindMinByteCount(ulong value)
        {
            ulong lg_v = 1;

            while ((value >>= 1) != 0)
            {
                lg_v++;
            }

            ulong result = lg_v >> 3;

            if (lg_v != result << 3)
                result += 1;

            return result;
        }

        public static string ReadNullTerminatedString(BinaryReader reader, bool pad)
        {
            var stringBuilder = new StringBuilder();
            var c = reader.ReadChar();

            if (c != '\0')
                stringBuilder.Append(c);

            var result = stringBuilder.ToString();

            if (pad)
            {
                var paddingCount = result.Length % 8;
                reader.BaseStream.Seek(paddingCount, SeekOrigin.Current);
            }

            return result;
        }
    }
}
