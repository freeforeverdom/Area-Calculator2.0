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
    public partial class Rect : Form
    {
        
        
        
        public Rect()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                Square square2 = new Square();
                square2.Show();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Tri tri2 = new Tri();
                tri2.Show();
                this.Close ();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Circular circular2 = new Circular();
                circular2.Show();
                this.Close () ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string long1 = textBox1.Text.Trim();
            string width1 = textBox2.Text.Trim();
            double c = 1;
            if (double.TryParse(long1, out c) && double.TryParse(width1, out c))
            {
                decimal m = Convert.ToDecimal(long1);
                decimal n = Convert.ToDecimal(width1);
                decimal Tran = (decimal)2.54;
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
                decimal MeasureArea = AreaMathForm.RecArea(m,n);
                String str = MeasureArea.ToString("0.000");
                String str1 = m.ToString("0.000");
                String str2 = n.ToString("0.000");
                textBox3.Text = "长为" + str1 + "厘米，" + "宽为" + str2 + "厘米的长方形的面积为" + str + "平方厘米";
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
