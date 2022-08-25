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
    public partial class Square : Form
    {



        public Square()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rect rect3 = new Rect();
                rect3.Show();
                this.Close();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Tri tri3 = new Tri();
                tri3.Show();
                this.Close();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Circular circular3 = new Circular();
                circular3.Show();
                this.Close();
            }
        }

        private void Square_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string long1 = textBox1.Text.Trim();
            double a = 1;
            if (double.TryParse(long1, out a))
            {
                decimal m = Convert.ToDecimal(long1);
                decimal tran = (decimal)2.54;
                decimal s = m * tran;
                decimal MeasureArea = AreaMathForm.SqureArea(m);
                decimal Tran = (decimal)6.4516;
                string company = comboBox1.Text;
                if (company == "厘米（cm)")
                {
                    String Diam = m.ToString("0.000");
                    String str = MeasureArea.ToString("0.000");
                    textBox3.Text = "边长为" + Diam + "厘米的正方形的面积为" + str + "平方厘米";
                }
                else if (company == "英寸（in）")
                {
                    String Diam1 = s.ToString("0.000");
                    decimal MeasureArea1 = MeasureArea * Tran;
                    String str1 = MeasureArea1.ToString("0.000");
                    textBox3.Text = "边长为" + Diam1 + "厘米的正方形的面积为" + str1 + "平方厘米";
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
