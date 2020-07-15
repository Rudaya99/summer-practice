using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Знайка
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form ifrm = new Form1();
            ifrm.Show(); // отображаем Form1
            this.Hide(); // скрываем Form2 (this - текущая форма)
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Picture.F1 = ".\\Фауна\\Вопрос 1.jpg";
            Picture.F2 = ".\\Фауна\\Фауна 1.jpg";
            Picture.F3 = ".\\Фауна\\Вопрос 2.jpg";
            Picture.F4 = ".\\Фауна\\Фауна 2.jpg";
            Picture.F5 = ".\\Фауна\\Вопрос 3.jpg";
            Picture.F6 = ".\\Фауна\\Фауна 3.jpg";
            Picture.F7 = ".\\Фауна\\Вопрос 4.jpg";
            Picture.F8 = ".\\Фауна\\Фауна 4.jpg";
            Picture.F9 = ".\\Фауна\\Вопрос 5.jpg";
            Picture.F10 = ".\\Фауна\\Фауна 5.jpg";
            Picture.F11 = ".\\Фауна\\Вопрос 6.jpg";
            Picture.F12 = ".\\Фауна\\Фауна 6.jpg";
            Picture.F13 = ".\\Фауна\\Вопрос 7.jpg";
            Picture.F14 = ".\\Фауна\\Фауна 7.jpg";
            Picture.F15 = ".\\Фауна\\Вопрос 8.jpg";
            Picture.F16 = ".\\Фауна\\Фауна 8.jpg";
            Picture.F17 = ".\\Фауна\\Фауна.jpg";



            Form ifrm = new Form4();
            ifrm.Show(); // отображаем Form4
            this.Hide(); // скрываем Form2 (this - текущая форма)
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Picture.F1 = ".\\Флора\\Флора 1.jpg";
            Picture.F2 = ".\\Флора\\Вопрос 1.jpg";
            Picture.F3 = ".\\Флора\\Флора 2.jpg";
            Picture.F4 = ".\\Флора\\Вопрос 2.jpg";
            Picture.F5 = ".\\Флора\\Флора 3.jpg";
            Picture.F6 = ".\\Флора\\Вопрос 3.jpg";
            Picture.F7 = ".\\Флора\\Флора 4.jpg";
            Picture.F8 = ".\\Флора\\Вопрос 4.jpg";
            Picture.F9 = ".\\Флора\\Флора 5.jpg";
            Picture.F10 = ".\\Флора\\Вопрос 5.jpg";
            Picture.F11 = ".\\Флора\\Флора 6.jpg";
            Picture.F12 = ".\\Флора\\Вопрос 6.jpg";
            Picture.F13 = ".\\Флора\\Флора 7.jpg";
            Picture.F14 = ".\\Флора\\Вопрос 7.jpg";
            Picture.F15 = ".\\Флора\\Флора 8.jpg";
            Picture.F16 = ".\\Флора\\Вопрос 8.jpg";
            Picture.F17 = ".\\Флора\\Флора.jpg";


            Form ifrm = new Form4();
            ifrm.Show(); // отображаем Form3
            this.Hide(); // скрываем Form2 (this - текущая форма)
        }
    }
}
