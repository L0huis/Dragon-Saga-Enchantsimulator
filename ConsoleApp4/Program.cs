using System;
using WindowsInput;
using WindowsInput.Native;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Hello()
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.SHIFT);
        }
    }
}
