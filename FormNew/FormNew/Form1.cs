using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormNew
{
    public partial class Form1: Form
    {
        String[] imglist = new String[]
            {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg","10.jpg"};
        int index = 0;

    public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imglist.Length) index = 0;
            pictureBox3.Load("../../../Pictures/" + imglist[index + 0]);
            pictureBox2.Load("../../../Pictures/" + imglist[index + 1]);
            pictureBox4.Load("../../../Pictures/" + imglist[index + 2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            index = index - 1;
            if (index < 0) index = imglist.Length - 3;
            pictureBox3.Load("../../../Pictures/" + imglist[index + 0]);
            pictureBox2.Load("../../../Pictures/" + imglist[index + 1]);
            pictureBox4.Load("../../../Pictures/" + imglist[index + 2]);
        }
    }
}
