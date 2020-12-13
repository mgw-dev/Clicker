using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Clicker
{
    public static class Mouse
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const uint LEFTDOWN = 0x02;
        private const uint LEFTUP = 0x04;
        private const uint RIGHTDOWN = 0x08;
        private const uint RIGHTUP = 0x10;

        public enum Button
        {
            Left,
            Right
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
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;

            switch (b)
            {
                case Button.Left:
                    mouse_event(LEFTDOWN | LEFTUP, X, Y, 0, 0);
                    break;
                case Button.Right:
                    mouse_event(RIGHTDOWN | RIGHTUP, X, Y, 0, 0);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(b), b, null);
            }
        }
    }
}
