using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CS_Form
{
    public partial class Form1 : Form
    {
        
        TestLabel _testLabel;
        TEXTBOX _textBox;
        public Form1()
        {
            InitializeComponent();
            string[] strs =
            {
                "sky",
                "htn",
                "ts",
                "tkm",
                "usgrs",
                "rr",
                "tmrnmru",
                "ntts",
                "kzt",
                "sjk"
            };
            for (int i = 0; i < 10; i++)
            {
                Testbutton testButton = new Testbutton(this, strs[i], (i % 5) * 100, (i / 5) * 100, 100, 100);

                Controls.Add(testButton);
            }
            _testLabel = new TestLabel("らべるでぃす。", 10, 250, 500, 50);

            Controls.Add(_testLabel);
            _textBox = new TEXTBOX(
                "てきすとぼっくすでぃす", 10, 300, 500, 100);
            Controls.Add(_textBox);
            
        }
        
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }


        public string ButtonLabelReplacement(string str)
        {
            string s = _textBox.TextReplacement(str);


            return s;
        }



    }
}