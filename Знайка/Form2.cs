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



            Form ifrm = new Form3();
            ifrm.Show(); // отображаем Form3
            this.Hide(); // скрываем Form2 (this - текущая форма)
        }
    }
}
