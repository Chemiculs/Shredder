using System;
using System.Collections.Generic;
using Chemiculs.IO;
using System.IO;
namespace File_Shredder
{
    public static class Utils
    {
        public static string StringToHex(string str)
        {
            string returns = "";
            byte[] buffer = Chemiculs.Other.Encodings.ANSI.GetBytes(str);
            for (int i = 0; i < buffer.Length; i++)
            {
                returns += buffer[i].ToString("X2");
            }
            return returns;
        }
        public static string HexToString(string Hex)
        {
            string Fixed = Hex.Replace(" ", "");
            byte[] buffer = new byte[Hex.Length / 2];
            for (int i = 0; i < buffer.Length; i ++)
            {
                buffer[i] = Convert.ToByte(Fixed.Substring(i * 2, 2), 16);
            }
            return Chemiculs.Other.Encodings.ANSI.GetString(buffer);
        }
        public static bool CompareArray(byte[] Array1, byte[] Array2)
        {
            if (Array1.Length != Array2.Length)
                return false;
            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] != Array2[i])
                    return false;
            }
            return true;
        }
        public static bool FileCompare(string first, string second)
        {
            FileInfo F1 = new FileInfo(first);
            FileInfo F2 = new FileInfo(second);
            if(F1.Length != F2.Length)
            {
                return false;
            }
            using(FileStreamEx fs1 = new FileStreamEx(first, FileMode.Open))
            {
                using(FileStreamEx fs2 = new FileStreamEx(second, FileMode.Open))
                {
                    int Blocksize = 65536;
                    long Progress = 0;
                    byte[] buffer = new byte[Blocksize];
                    byte[] buffer2 = new byte[Blocksize];
                    while (Progress < fs1.Length)
                    {
                        if ((Progress + Blocksize) <= fs1.Length)
                        {
                            buffer = fs1.ReadBytes(Blocksize);
                            buffer2 = fs2.ReadBytes(Blocksize);
                            if (!CompareArray(buffer, buffer2))
                                return false;
                            Progress += Blocksize;
                        }
                        else
                        {
                            int Remaining = (int)(fs1.Length - Progress);
                            byte[] Rem1 = fs1.ReadBytes(Remaining);
                            byte[] Rem2 = fs2.ReadBytes(Remaining);
                            if (!CompareArray(Rem1, Rem2))
                                return false;
                            Progress += Remaining;
                        }
                    }
                }
            }
            return true;
        }
        public static void FillBuffer(ref byte[] buffer, byte val)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = val;
            }
        }
        public static string GetLength(double Size)
        {
            double RawSize = Math.Round(Size);
            if ((RawSize >= 1000) && (RawSize < 1000000))
            {
                return (RawSize / 1000).ToString() + "  kb";
            }
            else if ((RawSize >= 1000000) && (RawSize < 1000000000))
            {
                return (RawSize / 1000000).ToString() + "  mb";
            }
            else if (RawSize >= 1000000000)
            {
                return (RawSize / 1000000000).ToString() + "  gb";
            }
            else
            {
                return RawSize.ToString() + "  bytes";
            }
        }
    }
}
