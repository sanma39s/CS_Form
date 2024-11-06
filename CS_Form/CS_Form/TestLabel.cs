using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Form
{
    class TestLabel : Label
    {
        public TestLabel(string str, int x, int y, int width, int height)
        {
            Text = str;

            Location = new Point(x, y);

            Size = new Size(width, height);
        }
        public void TextUpdate(string str)
        {
            Text = str;
        }
    }
    
}
