using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Clicker
{
    public class Mouse
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out Point lpPoint);
        
        //Mouse actions
        private const uint MOUSEEVENTF_LEFTDOWN    = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP      = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN   = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP     = 0x0010;
        private const uint MOUSEEVENTF_MIDDLEDOWN  = 0x0020;   
        private const uint MOUSEEVENTF_MIDDLEUP    = 0x0040;
        private const uint MOUSEEVENTF_XDOWN       = 0x0080;
        private const uint MOUSEEVENTF_XUP         = 0x0100;
        private const uint XBUTTON1                = 0x0001;
        private const uint XBUTTON2                = 0x0002;

        public struct Point
        {
            public uint X;
            public uint Y;
            public Point(uint x, uint y)
            {
                X = x;
                Y = y;
            }
        }

        public enum Button
        {
            Left,
            Middle,
            Right,
            XButton1,
            XButton2,
        }

        public static void LeftClick()
        {
            Click(Button.Left);
        }

        public static void RightClick()
        {
            Click(Button.Right);
        }

        public static void Click(Button b)
        {
            if (!GetCursorPos(out Point cursorPosition)) return;

            switch (b)
            {
                case Button.Left:
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPosition.X, cursorPosition.Y, 0, 0);
                    break;
                case Button.Right:
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, cursorPosition.X, cursorPosition.Y, 0, 0);
                    break;
                case Button.Middle:
                    mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, cursorPosition.X, cursorPosition.Y, 0, 0);
                    break;
                case Button.XButton1:
                    mouse_event(MOUSEEVENTF_XDOWN | MOUSEEVENTF_XUP, cursorPosition.X, cursorPosition.Y, XBUTTON1, 0);
                    break;
                case Button.XButton2:
                    mouse_event(MOUSEEVENTF_XDOWN | MOUSEEVENTF_XUP, cursorPosition.X, cursorPosition.Y, XBUTTON2, 0);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(b), b, null);
            }

        }
    }
}
