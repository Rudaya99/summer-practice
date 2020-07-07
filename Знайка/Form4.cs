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
        public Form4()
        {
            InitializeComponent();
        }
        private void DemonstratePropertyItem(PaintEventArgs e)
        {

            // Create two images.
            Image image1 = Image.FromFile("E:\\Фауна\\Фауна 1.jpg");
            Image image2 = Image.FromFile("E:\\Фауна\\Фауна 2.jpg");
            Image image3 = Image.FromFile("E:\\Фауна\\Фауна 3.jpg");
            Image image4 = Image.FromFile("E:\\Фауна\\Фауна 4.jpg");
            Image image5 = Image.FromFile("E:\\Фауна\\Фауна 5.jpg");
            Image image6 = Image.FromFile("E:\\Documents\\GitHub\\summer-practice\\Знайка\\Фауна\\Фауна 6.jpg");
            Image image7 = Image.FromFile("E:\\Documents\\GitHub\\summer-practice\\Знайка\\Фауна\\Фауна 7.jpg");
            Image image8 = Image.FromFile("E:\\Documents\\GitHub\\summer-practice\\Знайка\\Фауна\\Фауна 8.jpg");

            // Get a PropertyItem from image1.
            PropertyItem propItem = image1.GetPropertyItem(2036);

            // Change the ID of the PropertyItem.
            propItem.Id = 2036;

            // Set the PropertyItem for image2.
            image2.SetPropertyItem(propItem);

            // Draw the image.
            e.Graphics.DrawImage(image2, 20.0F, 20.0F);
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
