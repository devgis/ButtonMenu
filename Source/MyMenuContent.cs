using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MyMenuContent : UserControl
    {
        public MyMenuContent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK3");
        }
    }
}
