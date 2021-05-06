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
        ProcessWorkingMachine work = new ProcessWorkingMachine();
        public Empty(ProcessWorkingMachine w)
        {
            InitializeComponent();
            work = w;
            MaximizeBox = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            work.CountEmpty = Convert.ToInt32(numericUpDown1.Value);
            Close();
        }
    }
}
