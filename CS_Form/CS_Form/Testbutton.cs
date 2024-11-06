using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Form
{
    internal class Testbutton : Button
    {
        public Testbutton()
        {
            Click += OnClick;
        }
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("おおおお");
        }
    }

    


}
