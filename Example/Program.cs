using System;
using System.Threading.Tasks;
using Npgg.VirtualKeyboard;

namespace Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //

            //await VirtualKeyboard.MultiKeyPress(30, VirtualKeys.LeftWindows, VirtualKeys.E);

            await VirtualKeyboard.MultiKeyPress(30, VirtualKeys.LeftWindows, VirtualKeys.E);

            Console.WriteLine("Hello World!");
        }
        
        static async Task AltTab()=> await VirtualKeyboard.MultiKeyPress(30, VirtualKeys.Alt, VirtualKeys.Tab);

        static async Task Window_E()=> await VirtualKeyboard.MultiKeyPress(30, VirtualKeys.LeftWindows, VirtualKeys.E);

    }
}
