﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTraceRegex
{
    class Program
    {
        static List<byte[]> listArr = new List<byte[]>();
        static void Main(string[] args)
        {
            int counter = 50;
            while (counter-- > 0)
            {
                listArr.Add(new byte[80999990]);
                System.Threading.Thread.Sleep(500);
            }
            throw new Exception();
        }

        static void RegularStatements(string StringValue)
        {

        }
    }
}
