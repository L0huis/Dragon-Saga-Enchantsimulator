using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using System.Windows.Forms;
using CSharpTut;

namespace CSharpTutA
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(getBaseMatk(249));
            Console.WriteLine((int)getBaseMatk(249));
            Console.ReadLine();
        }

        public static double getBaseMatk(int INT)
        {
            return INT * Math.Log10(INT);
        }
    }
}