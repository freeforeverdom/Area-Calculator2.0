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
    /// 主类 <c>Tri : Form</c>
    /// 包含三角形面积计算界面的按键设置，提供三角形面积计算功能及转到其他图形面积计算的选项
    /// <list type="bullet">
    /// <item>
    /// <term>Tri</term>
    /// <description>三角形界面的构造函数，调用InitializeComponent()函数构造开始界面</description>
    /// </item>
    /// <item>
    /// <term>radioButton1_CheckedChanged</term>
    /// <description>1号单选控件（长方形）被选中时初始化并打开长方形计算界面</description>
    /// </item>
    /// <item>
    /// <term>radioButton2_CheckedChanged</term>
    /// <description>2号单选控件（正方形）被选中时初始化并打开正方形计算界面</description>
    /// </item>
    /// <item>
    /// <term>radioButton4_CheckedChanged</term>
    /// <description>4号单选控件（圆形）被选中时初始化并打开圆形计算界面</description>
    /// </item>
    /// <item>
    /// <term>Tri_Load</term>
    /// <description>在加载三角形面积计算界面时使单位下拉选择框初始处于厘米状态</description>
    /// </item>
    /// <item>
    /// <term>button1_Click</term>
    /// <description>当计算按钮被按下时，读取数字输入框中的数字和单位下拉选择框的单位，判断是否为非法输入，若为非法输入，输出“非法输入！”并清空输入框，
    /// 若不为非法输入，则通过换算后调用面积计算公式得出面积并输出完整结果在输出框中</description>
    /// </item>
    /// </list>
    /// </summary>
    public partial class Tri : Form
    {
        /// <summary>
        /// 三角形界面的构造函数，调用InitializeComponent()函数构造开始界面
        /// </summary>
        public Tri()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 在加载三角形面积计算界面时使单位下拉选择框初始处于厘米状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tri_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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
                Rect rect4 = new Rect();
                rect4.Show();
                this.Close();
            }
        }
        /// <summary>
        /// 2号单选控件（正方形）被选中时初始化并打开正方形计算界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Square square4 = new Square();
                square4.Show();
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
                Circular circular4 = new Circular();
                circular4.Show();
                this.Close();
            }
        }
        /// <summary>
        /// 当计算按钮被按下时，读取数字输入框中的数字和单位下拉选择框的单位，判断是否为非法输入，若为非法输入，输出“非法输入！”并清空输入框，
        /// 若不为非法输入，则通过换算后调用面积计算公式得出面积并输出完整结果在输出框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string base1 = textBox1.Text.Trim();
            string height1 = textBox2.Text.Trim();
            double a = 1;
            double b = 1;
            if (double.TryParse(base1, out a) && double.TryParse(height1, out b)&&a>0&&b>0)
            {
                decimal m = Convert.ToDecimal(base1);
                decimal n = Convert.ToDecimal(height1);
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
                decimal MeasureArea = AreaMathForm.TriArea(m,n);
                String str = MeasureArea.ToString("0.000");
                String str1 = m.ToString("0.000");
                String str2 = n.ToString("0.000");
                textBox3.Text = "底长为" + str1 + "厘米，" + "高为" + str2 + "厘米的三角形的面积为" + str + "平方厘米";
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
