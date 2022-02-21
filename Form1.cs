using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3, total; //set numbers
            num1=int.Parse(textBox1.Text);
            num2=int.Parse(textBox2.Text);
            num3=int.Parse(textBox3.Text);
            total = num1 + num2 + num3;

            float gnum1, gnum2, gnum3; //set graph numbers
            gnum1 = (num1 / total) * 360;
            gnum2 = (num2 / total) * 360;
            gnum3 = (num3 / total) * 360;
            label4.Text = "=" + gnum1.ToString() + "%";
            label5.Text = "=" + gnum2.ToString() + "%";
            label6.Text = "=" + gnum3.ToString() + "%";

            Pen p = new Pen(Color.Black); // it's the pen that we will draw a graph and color defines our color of pen, white-color, 4- thickess
            Graphics g=this.CreateGraphics();
            Rectangle rec = new Rectangle(300, 50, 250, 250); //300-distance from left(textbox1, 50-distance from above, 250-width(from left to right),250-weight(from up to down)

            Brush b1 = new SolidBrush(Color.Green);
            Brush b2 = new SolidBrush(Color.Red);
            Brush b3 = new SolidBrush(Color.Blue);

            g.Clear(Form1.DefaultBackColor);
            g.DrawPie(p, rec, 0, gnum1); // Pen variable, Rectangle variable, starting angle, finish angle
            g.FillPie(b1,rec,0, gnum1);
            g.DrawPie(p, rec, gnum1, gnum2);
            g.FillPie(b2, rec, gnum1, gnum2);
            g.DrawPie(p, rec, gnum1+gnum2, gnum3);
            g.FillPie(b3, rec,gnum1+gnum2, gnum3);




        }
    }
}
