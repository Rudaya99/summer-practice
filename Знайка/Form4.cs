using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Знайка
{
    public partial class Form4 : Form
    { 
         Image a;
        int ind = 0;




        /* String[] filename =
         {
           ".\\Фауна\\Вопрос 1.jpg",".\\Фауна\\Фауна 1.jpg",".\\Фауна\\Вопрос 2.jpg",".\\Фауна\\Фауна 2.jpg",
           ".\\Фауна\\Вопрос 3.jpg",".\\Фауна\\Фауна 3.jpg",".\\Фауна\\Вопрос 4.jpg",".\\Фауна\\Фауна 4.jpg",
           ".\\Фауна\\Вопрос 5.jpg",".\\Фауна\\Фауна 5.jpg",".\\Фауна\\Вопрос 6.jpg",".\\Фауна\\Фауна 6.jpg",
           ".\\Фауна\\Вопрос 7.jpg",".\\Фауна\\Фауна 7.jpg",".\\Фауна\\Вопрос 8.jpg",".\\Фауна\\Фауна 8.jpg",".\\Фауна\\Фауна.jpg"
         };*/
        /* string[] filename =
         {
            "F1","F2","F3","F4",
            "F5","F6","F7","F8",
            "F9","F10","F11","F12",
            "F13","F14","F15","F16","F17"


         };*/
        String [] filename =
         {
            Picture.F1,Picture.F2,Picture.F3,Picture.F4,
            Picture.F5,Picture.F6,Picture.F7,Picture.F8,
            Picture.F9,Picture.F10,Picture.F11,Picture.F12,
            Picture.F13,Picture.F14,Picture.F15,Picture.F16,Picture.F17
        };



        public Form4()
        {
            InitializeComponent();
            
        }
        private void DemonstratePropertyItem(PaintEventArgs e)
        {

            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
               a= Image.FromFile(filename[ind]);
            button1.BackColor = Color.Transparent; //прозрачный цвет фона
            //button1.BackgroundImage = назначаем картинку
            button1.BackgroundImageLayout = ImageLayout.Center; //выравниваем её по центру
            button1.FlatStyle = FlatStyle.Flat;
            button1.Text = "Вперёд";
            button1.ForeColor = Color.Green;
            button1.TextAlign = ContentAlignment.BottomCenter; //позиция текста - внизу по центру
            button1.FlatAppearance.BorderSize = 0;//ширина рамки = 0
            button1.TextImageRelation = TextImageRelation.ImageAboveText; //картинка над текстом
            button1.TabStop = false;//делаем так, что бы при потере фокуса, вокруг кнопки не оставалась черная рамка


            button2.BackColor = Color.Transparent; //прозрачный цвет фона
            //button2.BackgroundImage = назначаем картинку
            button2.BackgroundImageLayout = ImageLayout.Center; //выравниваем её по центру
            button2.FlatStyle = FlatStyle.Flat;
            button2.Text = "Назад";
            button2.ForeColor = Color.Green;
            button2.TextAlign = ContentAlignment.BottomCenter; //позиция текста - внизу по центру
            button2.FlatAppearance.BorderSize = 0;//ширина рамки = 0
            button2.TextImageRelation = TextImageRelation.ImageAboveText; //картинка над текстом
            button2.TabStop = false;//делаем так, что бы при потере фокуса, вокруг кнопки не оставалась черная рамка



        }


        private void Form4_Paint(object sender, PaintEventArgs e)
        {

            
           // Draw the image.
           e.Graphics.DrawImage(a, 0.0F, 0.0F,1580.0F, 880.0F);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ind == 0)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

            else if ((ind == 1) && (radioButton3.Checked == true)) MessageBox.Show("Правильно!");
            
            else if (ind == 2)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else if ((ind == 3) && (radioButton4.Checked == true)) MessageBox.Show("Правильно!");
            else if (ind == 4)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else if ((ind == 5) && (radioButton4.Checked == true)) MessageBox.Show("Правильно!");
            else if(ind == 6)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else if ((ind == 7) && (radioButton1.Checked == true)) MessageBox.Show("Правильно!");
            else if(ind == 8)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else if ((ind == 9) && (radioButton2.Checked == true)) MessageBox.Show("Правильно!");
            else if(ind == 10)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else if ((ind == 11) && (radioButton2.Checked == true)) MessageBox.Show("Правильно!");
            else if(ind == 12)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else if ((ind == 13) && (radioButton3.Checked == true)) MessageBox.Show("Правильно!");
            else if (ind == 14)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

            }
            else if ((ind == 15) && (radioButton1.Checked == true)) MessageBox.Show("Правильно!");
            else if (ind == 16)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

            }
            else { MessageBox.Show("Неправильно! Подумай ещё ))"); ind--; }
            ind++;
            if (ind > 16) ind = 16;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false; 
            
            
            a = Image.FromFile(filename[ind]);
            Invalidate();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ind--;
            if (ind < 0) ind = 0;
            a = Image.FromFile(filename[ind]);
            Invalidate();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form3();
            ifrm.Show(); // отображаем Form4
            this.Hide(); // скрываем Form4 (this - текущая форма)
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
