using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Calendar

{
    public partial class Pictures_Calendar_Beta : Form
    {
        
        public Pictures_Calendar_Beta()
        {
            InitializeComponent();
            show_picture();
        }

        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            show_picture();
        }
            private void show_picture() { 
            string month = monthCalendar1.SelectionStart.Month.ToString();
            int intmonth = int.Parse(month);
            
            switch (intmonth)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("12months\\January.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("12months\\February.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("12months\\March.jpg");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("12months\\April.jpg");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("12months\\May.jpg");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("12months\\June.jpg");
                    break;
                case 7:
                    pictureBox1.Image = Image.FromFile("12months\\July.jpg");
                    break;
                case 8:
                    pictureBox1.Image = Image.FromFile("12months\\August.jpg");
                    break;
                case 9:
                    pictureBox1.Image = Image.FromFile("12months\\September.jpg");
                    break;
                case 10:
                    pictureBox1.Image = Image.FromFile("12months\\October.jpg");
                    break;
                case 11:
                    pictureBox1.Image = Image.FromFile("12months\\November.jpg");
                    break;
                case 12:
                    pictureBox1.Image = Image.FromFile("12months\\December.jpg");
                    break;
            }


        }

      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            monthCalendar1.Visible = !monthCalendar1.Visible;
        }
    }
}

