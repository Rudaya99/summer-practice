﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.Show(); // отображаем Form3
            this.Hide(); // скрываем Form3 (this - текущая форма)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form4();
            ifrm.Show(); // отображаем Form3
            this.Hide(); // скрываем Form3 (this - текущая форма)
        }
    }
}
