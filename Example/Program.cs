using System;
using System.Threading.Tasks;
using Npgg;

namespace Example
{
    class Program
    {
        static async Task Main()
        {
            await Keyboard.KeyPress(20, KeyboardKeys.A, KeyboardKeys.B, KeyboardKeys.C); // PRESS A,B,C

            Console.WriteLine("Hello World!");
        }
        
        static async Task AltTab()=> await Keyboard.MultiKeyPress(30, KeyboardKeys.Alt, KeyboardKeys.Tab);

        static async Task Window_E()=> await Keyboard.MultiKeyPress(30, KeyboardKeys.LeftWindows, KeyboardKeys.E);

        static async Task WriteWord() => await Keyboard.MultiKeyPress(30, KeyboardKeys.LeftWindows, KeyboardKeys.E);
    }
}
