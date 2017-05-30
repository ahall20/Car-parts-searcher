using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parts
{
    public partial class Form1 : Form
    {

        public static string car = "";
        public static string year = "";
        public static string mod = "";
        public Form1()
        {
            InitializeComponent();
            search.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Makelist.Items.Add("Honda");
            Makelist.Items.Add("Ford");
            Makelist.Items.Add("Toyota");
            Makelist.Items.Add("Chevy");
            Makelist.Items.Add("Mazda");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
            //Drawing_test tst = new Drawing_test();
           // tst.Tag = this;
            //tst.Show(this);
        }

        private void Makelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = Makelist.SelectedItem.ToString();
            
            if (item == "Ford")
            {
                Modellist.Items.Clear();
                Typelist.Items.Clear();
                Yearlist.Items.Clear();
                Modellist.Items.Add("Focus");
                Modellist.Items.Add("Taurus");
                Modellist.Items.Add("F150");             
                
            }
            
            else if (item == "Honda")
            {
                Modellist.Items.Clear();
                Typelist.Items.Clear();
                Yearlist.Items.Clear();
                Modellist.Items.Add("Civic");
                Modellist.Items.Add("Accord");
            }
            else if (item == "Chevy")
            {
                Modellist.Items.Clear();
                Typelist.Items.Clear();
                Yearlist.Items.Clear();
                Modellist.Items.Add("Malibu");
            }
            else if (item == "Mazda")
            {
                Modellist.Items.Clear();
                Typelist.Items.Clear();
                Yearlist.Items.Clear();
                Modellist.Items.Add("CX5");
            }
            else
            {
                Modellist.Items.Clear();
                Typelist.Items.Clear();
                Yearlist.Items.Clear();
            }
            if (Typelist.Items.Count <= 0)
            {
                search.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process st = new Process();
            st.StartInfo.FileName = "C:\\Users\\wwstudent\\Documents\\Visual Studio 2017\\Projects\\Reader\\Reader\\obj\\Debug\\Reader.exe";
            st.Start();
        }

        private void Modellist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string mod = Modellist.SelectedItem.ToString();
            car = mod;
            if (mod == "Focus")
            {
                Yearlist.Items.Clear();
                Typelist.Items.Clear();
                Yearlist.Items.Add("2017");
            }
            
            else if (mod == "Civic")
            {
                Yearlist.Items.Clear();
                Typelist.Items.Clear();
                Yearlist.Items.Add("2017");
            }
            else if (mod == "Taurus")
            {
                Yearlist.Items.Clear();
                Typelist.Items.Clear();
                Yearlist.Items.Add("2000");
                Yearlist.Items.Add("2001");
                Yearlist.Items.Add("2002");
                Yearlist.Items.Add("2003");
                Yearlist.Items.Add("2004");
                Yearlist.Items.Add("2017");
            }
            if (Typelist.Items.Count <= 0)
            {
                search.Hide();
            }

        }

        private void Typelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string typ = Typelist.SelectedItem.ToString();
            string type = Typelist.SelectedItem.ToString();
            mod = type;
            search.Visible = Visible;
            
        }

        private void Yearlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string yr = Yearlist.SelectedItem.ToString();
            year = yr;
            if (yr == "2017")
            {
                if (car == "Civic")
                {
                    Typelist.Items.Clear();
                    Typelist.Items.Add("LX");
                }
               else
                {
                    Typelist.Items.Clear();
                    Typelist.Items.Add("SE");
                }
            }
            else if (yr == "2000")
            {
                Typelist.Items.Clear();
                Typelist.Items.Add("SES");
                Typelist.Items.Add("LX");
                Typelist.Items.Add("SE");
                Typelist.Items.Add("SEL");
            }
            else if (yr == "2001")
            {
                Typelist.Items.Clear();
                Typelist.Items.Add("SES");
                Typelist.Items.Add("LX");
                Typelist.Items.Add("SE");
                Typelist.Items.Add("SEL");
            }
            else if (yr == "2002")
            {
                Typelist.Items.Clear();
                Typelist.Items.Add("SES");
                Typelist.Items.Add("LX");
                Typelist.Items.Add("SE");
                Typelist.Items.Add("SEL");
            }
            else if (yr == "2003")
            {
                Typelist.Items.Clear();
                Typelist.Items.Add("SES");
                Typelist.Items.Add("LX");
                Typelist.Items.Add("SE");
                Typelist.Items.Add("SEL");
            }
            else if (yr == "2004")
            {
                Typelist.Items.Clear();
                Typelist.Items.Add("SES");
                Typelist.Items.Add("LX");
                Typelist.Items.Add("SE");
                Typelist.Items.Add("SEL");
            }
            if (Typelist.Items.Count <= 0)
            {
                search.Hide();

            }
            
            

        }
        
    }
    
}
