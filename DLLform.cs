using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MessageBoxes;
using StringLibrary;


namespace SystemProg
{
    public partial class DLLform : Form
    {
        [DllImport("user32.dll")]       // указываем из какой длл берем функции
        private                                 //
            static                              //  влл подключеник - только статик
            extern                              //указываем, что метод описан в другом модуле
            uint                                //
            MessageBoxA(                // имя функции - поиск по имени, должно быть как в модуле
            IntPtr hWnd,                    //типы данных 
            String message,                 //если нет прямого совпадения типов 
            String caption,                 //выбирается наиболее близко
            uint type);                         //
       
        public DLLform()
        {
            InitializeComponent();
        }

        private void DLLform_Load(object sender, EventArgs e)
        {

        }

        private void buttonAlert_Click(object sender, EventArgs e)
        {
            MessageBoxA((IntPtr)0, "Alert", "Message", 0x40);
        }

        private void buttonЕггог_Click(object sender, EventArgs e)
        {
            MessageBoxA((IntPtr)0, "Error", "Message", 0x10);
        }

        private void buttonWarn_Click(object sender, EventArgs e)
        {
            //  MessageBoxA((IntPtr)0, "Warning", "Message", 0x31);
            Alerts.Warning("From DLL", "Warning");
          
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            // MessageBoxA((IntPtr)0, "Question", "Message", 0x24);
            Alerts.Question("From DLL", "Question");
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;          
            StringExtensions.Reverse(str);
            textBox1.Clear();
            textBox1.Text = str.Reverse();
        }

        private void buttonSingleSpace_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            StringLib.SingleSpace(str);
            textBox1.Clear();
            textBox1.Text = str;
        }
    }
}
/*
 *DLL - библиотека динамической компановки
 * + уменьшение исполнимого кода за счет отделения общих функций
 * в DLL
 * - переносимость? при копировании программы нужно не забыть 
 * DDL 
 * + возможность использовать функции ДДЛ в разных языках
 * возможно прийдется  подключать неуправляемый код
 * + улучшенная (по сравнению с открытым кодом) защита авторских прав
 * +удобства обновления программы - замена некоторых DDL
 * 
 * в  .Net  мы можем иметь дело с управлениями DLL (библиотека классов)
 * и неуправляемыми (обычно, созданные при помощи других языков)
 * 
 
 */
