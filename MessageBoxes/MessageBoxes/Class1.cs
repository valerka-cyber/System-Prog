using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MessageBoxes
{
    public class Alerts
    {
        [DllImport("user32.dll")]
        private static extern uint
            MessageBoxA(
            IntPtr hWnd,
            String message,
            String caption,
            uint type);

        public static void Alert(String caption, String message)
        {
            MessageBoxA((IntPtr)0, message, caption, 0x40);
        }

        public static void Error(String caption, String message)
        {
            MessageBoxA((IntPtr)0, message, caption, 0x10);
        }

        public static bool Warning(String caption, String message)
        {
            // 1 == IDOK
            return 1 == MessageBoxA((IntPtr)0, message, caption, 0x31);
        }

        public static bool Question(String caption, String message)
        {
            // 1 == IDOK
            return 1 == MessageBoxA((IntPtr)0, message, caption, 0x24);
        }
    }
}

