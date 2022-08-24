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
    public partial class Tri : Form
    {
       
        
        
        public Tri()
        {
            InitializeComponent();
        }

        private void Tri_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rect rect4 = new Rect();
                rect4.Show();
                this.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Square square4 = new Square();
                square4.Show();
                this.Close();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Circular circular4 = new Circular();
                circular4.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string base1 = textBox1.Text.Trim();
            string height1 = textBox2.Text.Trim();
            int b = 1;
            if (int.TryParse(base1, out b) && int.TryParse(height1, out b))
            {
                decimal m = Convert.ToDecimal(base1);
                decimal n = Convert.ToDecimal(height1);
                decimal Tran = (decimal)2.54;
                decimal two = (decimal)0.5;
                string company1 = comboBox1.Text;
                string company2 = comboBox2.Text;
                if (company1 == "英寸（in）")
                {
                    m = m * Tran;
                }
                if (company2 == "英寸（in）")
                {
                    n = n * Tran;
                }
                decimal MeasureArea = m * n * two;
                String str = MeasureArea.ToString("0.000");
                string Measure = str + " ";
                textBox3.Text = Measure;
            }
            else 
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("非法输入！");
            }
        }
    }
}
