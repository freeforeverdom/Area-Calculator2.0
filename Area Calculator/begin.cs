using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Calculator
{
    public partial class begin : Form
    {
        public begin()
        {
            InitializeComponent();
            radioButton5.Checked = true ;
        }

        private void begin_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rect rect1 = new Rect();
                rect1.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Square square1 = new Square();
            square1.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Tri tri1 = new Tri();
            tri1.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Circular circular1 = new Circular();
            circular1.Show();
        }
    }
}
