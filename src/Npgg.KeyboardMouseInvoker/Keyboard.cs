using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Npgg
{

    public static class Keyboard
    {

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public static async Task KeyPress(ushort inputTerm, params KeyboardKeys[] keys)
        {
            foreach (var key in keys)
            {
                KeyDown(key);
                await Task.Delay(inputTerm);
                KeyUp(key);
            }
        }

        public static async Task MultiKeyPress(ushort inputTerm, params KeyboardKeys[] keys)
        {
            foreach (var key in keys)
            {
                KeyDown(key);
                await Task.Delay(inputTerm);
            }


            foreach (var key in keys.Reverse())
            {
                KeyUp(key);
                await Task.Delay(inputTerm);
            }
        }


        public static void KeyDown(KeyboardKeys key)
        {
            keybd_event((byte)key, 0, (uint)KeyboardAction.KeyDown, 0);
        }

        public static void KeyUp(KeyboardKeys key)
        {
            keybd_event((byte)key, 0, (uint)KeyboardAction.KeyUp, 0);
        }

    }
}
