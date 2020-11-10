using System;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Npgg;
using Npgg.KeyboardMouseInvoker;

namespace Example
{
    class Program
    {
        static async Task Main()
        {
            await Keyboard.MultiKeyPress(30, KeyboardKeys.LeftButton);

            //await Keyboard.KeyPress(20, KeyboardKeys.A, KeyboardKeys.B, KeyboardKeys.C); // PRESS A,B,C

            Console.WriteLine("Hello World!");

            Mouse.SetPosition(100, 100);

            Mouse.LeftDown();
            for (int i =0;i<100;i++)
            {
                Mouse.MovePosition(2, 2);
                await Task.Delay(5);
            }
            Mouse.LeftUp();
            Keyboard.KeyUp(KeyboardKeys.LeftButton);
        }
        
        static async Task AltTab()=> await Keyboard.MultiKeyPress(30, KeyboardKeys.Alt, KeyboardKeys.Tab);

        static async Task Window_E()=> await Keyboard.MultiKeyPress(30, KeyboardKeys.LeftWindows, KeyboardKeys.E);

        static async Task WriteWord() => await Keyboard.MultiKeyPress(30, KeyboardKeys.LeftWindows, KeyboardKeys.E);
    }
}
