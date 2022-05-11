using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class MyMenuButton:Button
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.Parent.Visible = false;
        }
    }
}
