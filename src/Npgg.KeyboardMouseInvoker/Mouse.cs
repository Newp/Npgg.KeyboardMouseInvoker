using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Npgg.KeyboardMouseInvoker
{
    public class Mouse
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Position
        {
            public int X;
            public int Y;

            public Position(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public static Position operator +( Position a, Position b) => new Position() { X = a.X + b.X, Y = a.Y + b.Y };
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetMessageExtraInfo();

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out Position position);

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        public static bool SetPosition(int x, int y)=> SetCursorPos(x, y);

        public static Position GetPosition()
        {
            GetCursorPos(out Position position);
            return position;
        }

        //public static void SetCursorPosition(int x, int y)
        //{
        //    SetCursorPosition(x, y);
        //}
        public static void MovePosition(int x, int y)
        {
            var pos = GetPosition() + new Position(x, y);

            SetPosition(pos.X, pos.Y);
        }
    }
}
