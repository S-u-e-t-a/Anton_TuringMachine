using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class Empty : Form
    {
        Line line = new Line();
        public Empty(Line l)
        {
            InitializeComponent();
            line = l;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line.countEmpty = Convert.ToInt32(numericUpDown1.Value);
            Close();
        }
    }
}
