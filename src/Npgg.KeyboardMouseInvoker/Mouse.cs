
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Npgg.KeyboardMouseInvoker
{
    public class Mouse
    {

        public static void LeftDown() => InputSender.SendMouseInput(new MouseInput() { dwFlags = MouseEventF.LeftDown });
        public static void LeftUp() => InputSender.SendMouseInput(new MouseInput() { dwFlags = MouseEventF.LeftUp });

        public static void RightDown() => InputSender.SendMouseInput(new MouseInput() { dwFlags = MouseEventF.RightDown });
        public static void RightUp() => InputSender.SendMouseInput(new MouseInput() { dwFlags = MouseEventF.RightUp });

        public static void MouseEvent(MouseInput input) => InputSender.SendMouseInput(input);


        public static bool SetPosition(int x, int y)=> InputSender.SetCursorPos(x, y);

        public static Position GetPosition()
        {
            InputSender.GetCursorPos(out Position position);
            return position;
        }

        public static void MovePosition(int x, int y)
        {
            var pos = GetPosition() + new Position(x, y);

            SetPosition(pos.X, pos.Y);
        }
    }
}
