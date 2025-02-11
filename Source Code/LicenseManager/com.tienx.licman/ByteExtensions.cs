﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TienX.License
{
    class ByteExtensions
    {
        public static byte[] StringToByteArray(String hex)
        {
            try
            {
                int NumberChars = hex.Length / 2;
                byte[] bytes = new byte[NumberChars];
                using (var sr = new StringReader(hex))
                {
                    for (int i = 0; i < NumberChars; i++)
                        bytes[i] =
                          Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
                }
                return bytes;
            }
            catch (Exception ex)
            {
                return new byte[0];
            }
        }
    }
}
