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
    public partial class Circular : Form
    {
        
        
        
        public Circular()
        {
            InitializeComponent();
        }

        private void Circular_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rect rect5 = new Rect();
                rect5.Show();
                this.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Square square5 = new Square();
                square5.Show();
                this.Close();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Tri tri5 = new Tri();
                tri5.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radius = textBox1.Text.Trim();
            int d = 1;
            if (int.TryParse(radius, out d))
            {
                decimal m = Convert.ToDecimal(radius);
                decimal pi = (decimal)3.1415916;
                decimal MeasureArea = m * m * pi;
                decimal Tran = (decimal)6.4516;
                string company = comboBox1.Text;
                if (company == "厘米（cm)")
                {
                    String str = MeasureArea.ToString("0.000");
                    string Measure = str + " ";
                    textBox3.Text = Measure;
                }
                else if (company == "英寸（in）")
                {
                    decimal MeasureArea1 = MeasureArea * Tran;
                    String str1 = MeasureArea1.ToString("0.000");
                    string Measure1 = str1 + " ";
                    textBox3.Text = Measure1;
                }
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("非法输入！");
            }
        }
    }
}
