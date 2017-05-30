using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parts
{
    public partial class Form2 : Form
    {
        public string car;
        public string year;
        public string type;
        public Form2()
        {
            InitializeComponent();
            car = Form1.car;
            year = Form1.year;
            type = Form1.mod;
            textBox1.Text = year +  car;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (car == "Focus")
            {
                if (year == "2017")
                {
                    pic.Image = Image.FromFile("C: \\Users\\wwstudent\\Downloads\\Books\\focus.png");
                }
                else
                {
                    
                }

            }
            else if (car == "Taurus")
            {
                if (year == "2017")
                {
                    
                    pic.Image = Image.FromFile("C: \\Users\\wwstudent\\Downloads\\Books\\taurus.png");
                }
                else if (year == "2000")
                {
                    if (type == "SES")
                    {
                        pic.Image = Image.FromFile("C: \\Users\\wwstudent\\Downloads\\Books\\02taurus.jpg");
                    }
                    else if (type == "LX")
                    {
                        pic.Image = Image.FromFile("C: \\Users\\wwstudent\\Downloads\\Books\\tauruslx.jpg");
                    }
                }
                else if (year == "2001")
                {
                    pic.Image = Image.FromFile("C: \\Users\\wwstudent\\Downloads\\Books\\02taurus.jpg");
                }
                else if (year == "2002")
                {
                    pic.Image = Image.FromFile("C: \\Users\\wwstudent\\Downloads\\Books\\02taurus.jpg");
                }
                else if (year == "2003")
                {
                    pic.Image = Image.FromFile("C: \\Users\\wwstudent\\Downloads\\Books\\02taurus.jpg");
                }
                else if (year == "2004")
                {
                    pic.Image = Image.FromFile("C: \\Users\\wwstudent\\Downloads\\Books\\02taurus.jpg");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Tag = this;
            form1.Show(this);
            Hide();
        }
    }
}
