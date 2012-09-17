using System;
using System.Collections.Generic;
namespace File_Shredder
{
    public static class Globalvariables
    {
        static string _Path = "";
        static List<byte> _Passes = new List<byte>() {};
        static bool _Delete = true;
        static bool _SmallBuff = false;
        static bool _LrgBuff = false;
        static bool _Custom = true;
        static int _Size = 65536;
        public static string Filepath
        {
            get
            {
                return _Path;
            }
            set
            {
                _Path = value;
            }
        }
        public static bool Delete
        {
            get
            { 
                return _Delete; 
            }
            set
            {
                _Delete = value;
            }
        }
        public static List<byte> Passes
        {
            get
            {
                return _Passes;
            }
            set
            {
                _Passes = value;
            }
        }
        public static bool FullBuffer
        {
            get
            {
                return _LrgBuff;
            }
            set
            {
                _LrgBuff = value;
            }
        }
        public static bool OneByte
        {
            get
            {
                return _SmallBuff;
            }
            set
            {
                _SmallBuff = value;
            }
        }
        public static bool CustomBuffer
        {
            get
            {
                return _Custom;
            }
            set
            {
                _Custom = value;
            }
        }
        public static int BufferSize
        {
            get
            {
                return _Size;
            }
            set
            {
                _Size = value;
            }
        }
    }
}
