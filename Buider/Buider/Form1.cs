using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Builder build = new lanternBuilder();
            Director director = new Director(build);
            lantarn lat = director.Buildpiz();
            richTextBox1.Text += lat.Data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Builder build = new GoodlanternBuilder();
            Director director = new Director(build);
            lantarn lat = director.Buildpiz();
            richTextBox1.Text += lat.Data();
            for (int i = 0; i < 3; i++)
            {
                lantern clone = lat.Copy();
                richTextBox1.Text += "Копія" + (i + 1) + " " + ((lantarn)clone).pillar + ((lantarn)clone).pillar + ((lantarn)clone).wiring + "\n";
            }
        }
    }
}
