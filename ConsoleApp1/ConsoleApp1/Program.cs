using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 42.18;
            string stra = a.ToString();
        }

        public event KeyPressHandler KeyDown;
    }
}
