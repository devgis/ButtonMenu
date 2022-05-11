using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.LostFocus += Button1_LostFocus;
            button2.LostFocus += Button1_LostFocus;
            button3.LostFocus += Button1_LostFocus;
        }

        private void Button1_LostFocus(object sender, EventArgs e)
        {
            if (!button1.Focused && !button2.Focused && !button3.Focused)
            {
                //panel1.Visible = false;
                //MyMenuForm.Visible = false;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //panel1.Location = new Point((sender as Button).Location.X, panel1.Location.Y);
            //panel1.Visible = true;
            (sender as Button).Focus();
        }
        MyMenuContent MyMenuForm = new MyMenuContent();
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //panel1.Location = new Point((sender as Button).Location.X, panel1.Location.Y);
            //panel1.Visible = true;

            MyMenuForm.Location = new Point((sender as Button).Location.X, (sender as Button).Location.Y+ (sender as Button).Height);
            if (!this.FindForm().Controls.Contains(MyMenuForm))
            {
                this.FindForm().Controls.Add(MyMenuForm);
            }
            MyMenuForm.Visible = true;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //panel1.Location = new Point(e.X, panel1.Location.Y);
        }
    }
}
