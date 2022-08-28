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
    /// <summary>
    /// 主类 <c>Square : Form</c>
    /// 包含正方形面积计算界面的按键设置，提供正方形面积计算功能及转到其他图形面积计算的选项
    /// <list type="bullet">
    /// <item>
    /// <term>Square</term>
    /// <description>正方形界面的构造函数，调用InitializeComponent()函数构造开始界面</description>
    /// </item>
    /// <item>
    /// <term>radioButton1_CheckedChanged</term>
    /// <description>1号单选控件（长方形）被选中时初始化并打开长方形计算界面</description>
    /// </item>
    /// <item>
    /// <term>radioButton3_CheckedChanged</term>
    /// <description>3号单选控件（三角形）被选中时初始化并打开三角形计算界面</description>
    /// </item>
    /// <item>
    /// <term>radioButton4_CheckedChanged</term>
    /// <description>4号单选控件（圆形）被选中时初始化并打开圆形计算界面</description>
    /// </item>
    /// <item>
    /// <term>Square_Load</term>
    /// <description>在加载正方形面积计算界面时使单位下拉选择框初始处于厘米状态</description>
    /// </item>
    /// <item>
    /// <term>button1_Click</term>
    /// <description>当计算按钮被按下时，读取数字输入框中的数字和单位下拉选择框的单位，判断是否为非法输入，若为非法输入，输出“非法输入！”并清空输入框，
    /// 若不为非法输入，则通过换算后调用面积计算公式得出面积并输出完整结果在输出框中</description>
    /// </item>
    /// </list>
    /// </summary>
    public partial class Square : Form
    {
        /// <summary>
        /// 正方形界面的构造函数，调用InitializeComponent()函数构造开始界面
        /// </summary>
        public Square()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 1号单选控件（长方形）被选中时初始化并打开长方形计算界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rect rect3 = new Rect();
                rect3.Show();
                this.Close();
            }
        }
        /// <summary>
        /// 3号单选控件（三角形）被选中时初始化并打开三角形计算界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Tri tri3 = new Tri();
                tri3.Show();
                this.Close();
            }
        }
        /// <summary>
        /// 4号单选控件（圆形）被选中时初始化并打开圆形计算界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Circular circular3 = new Circular();
                circular3.Show();
                this.Close();
            }
        }
        /// <summary>
        /// 在加载正方形面积计算界面时使单位下拉选择框初始处于厘米状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Square_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        /// <summary>
        /// 当计算按钮被按下时，读取数字输入框中的数字和单位下拉选择框的单位，判断是否为非法输入，若为非法输入，输出“非法输入！”并清空输入框，
        /// 若不为非法输入，则通过换算后调用面积计算公式得出面积并输出完整结果在输出框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string long1 = textBox1.Text.Trim();
            double a = 1;
            if (double.TryParse(long1, out a)&&a>0)
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
