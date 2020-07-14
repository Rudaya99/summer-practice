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
        int[] answer;
        String[] filename = 
        {
         ".\\Фауна\\Фауна 1.jpg",".\\Фауна\\Фауна 2.jpg",".\\Фауна\\Фауна 3.jpg",
         ".\\Фауна\\Фауна 4.jpg",".\\Фауна\\Фауна 5.jpg",".\\Фауна\\Фауна 6.jpg",".\\Фауна\\Фауна 7.jpg",".\\Фауна\\Фауна 8.jpg"
    };
        

        public Form4()
        {
            InitializeComponent();
            answer = new int[8];
        }
        private void DemonstratePropertyItem(PaintEventArgs e)
        {

            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
               a= Image.FromFile(filename[ind]);
        
             

        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {

            
           // Draw the image.
           e.Graphics.DrawImage(a, 0.0F, 0.0F,816.0F, 489.0F);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ind++;
            if (ind > 7) ind = 7;
            a = Image.FromFile(filename[ind]);
            Invalidate();
            switch (answer[ind])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    break;
                case 4:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 7:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    break;
                case 8:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ind--;
            if (ind < 0) ind = 0;
            a = Image.FromFile(filename[ind]);
            Invalidate();
            switch (answer[ind])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    break;
                case 4:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 7:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    break;
                case 8:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;



            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((a = 0) && (radioButton1.Checked = true)) MessageBox.Show("Правильно!");
            answer[ind] = 1;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer[ind] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[ind] = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answer[ind] = 4;
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
    }
}
