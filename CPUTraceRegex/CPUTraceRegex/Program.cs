using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTraceRegex
{
    class Program
    {
        static List<byte[]> listArr = new List<byte[]>();
        //These are some of the changes, I would like to make
        static void Main(string[] args)
        {
            int counter = 50;
            //Is this the right value?
            while (counter-- > 0)
            {
                listArr.Add(new byte[80999990]);
                System.Threading.Thread.Sleep(500);
            }

            throw new Exception("custom exception");
        }

        static void RegularStatements(string StringValue)
        {
            //TODO
            //This is another test
        }
    }
}
