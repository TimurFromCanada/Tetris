using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    static class Program
    {

        static void Main()
        {
            Application.EnableVisualStyles(); //включаем визуальные стили приложения
            Application.Run(new Form1()); //запуск Form1
        }
    }
}
