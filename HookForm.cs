using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProg
{
    public partial class HookForm : Form
    {
        private const int WM_KEYDOWN = 0x0100; //номер события клавиатуры
        private const int WM_KEYBOARD_LL = 13; //номер хука
        private delegate IntPtr HookProc
            (int nCode,
            IntPtr wParam,
            IntPtr lParam );
        #region Import
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(
            int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(
            IntPtr hHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(String lpModuleName);
        #endregion

        private static HookProc kbProc = KbHookCallback;
        private static IntPtr kbHook;
        private static ListBox list1;

        private static IntPtr KbHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode >= 0 && wParam == (IntPtr) WM_KEYDOWN)
            {
                //Перехвачено событие нажатия клавиш
                int keyCode = Marshal.ReadInt32(lParam);
                Keys keyEnum = (Keys)keyCode;
                list1.Items.Add(keyEnum.ToString());
            }
            return CallNextHookEx(kbHook, nCode, wParam, lParam);
        }

       
        public HookForm()
        {
            InitializeComponent();
            list1 = listBox1;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            using (Process process = Process.GetCurrentProcess() )
                using(ProcessModule module = process.MainModule)
            {
                kbHook = SetWindowsHookEx(WM_KEYBOARD_LL, kbProc, GetModuleHandle(module.ModuleName), 0);
                
            }
            listBox1.Items.Add("kb start");
            buttonStop.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            UnhookWindowsHookEx(kbHook);
            listBox1.Items.Add("Kb Stop");
        }
    }
}
/*
 * Hooks (Системные хуки)
 *  Хуки (дословно - крюки) - технологии, позволяющие встраивать сообственные 
 *  коды в системную работу
 *  Обычно, хуки применяются для перехвата событий на подобие 
 *  клавиатуры или мыши.
 *  
 *  
 *  Суть хука: подменить адрес стандартного обработчика
 *  клавиша -- БИОС -- Intr ------OS |intr0|intr1....|intr255|
 *  (наш обработчик)
 *  
 * 
 */