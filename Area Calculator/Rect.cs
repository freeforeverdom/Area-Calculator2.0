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
    /// 主类 <c>Rect : Form</c>
    /// 包含长方形面积计算界面的按键设置，提供长方形面积计算功能及转到其他图形面积计算的选项
    /// <list type="bullet">
    /// <item>
    /// <term>Rect</term>
    /// <description>长方形界面的构造函数，调用InitializeComponent()函数构造开始界面</description>
    /// </item>
    /// <item>
    /// <term>radioButton2_CheckedChanged</term>
    /// <description>2号单选控件（正方形）被选中时初始化并打开正方形计算界面</description>
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
    /// <term>Form1_Load</term>
    /// <description>在加载长方形面积计算界面时使单位下拉选择框初始处于厘米状态</description>
    /// </item>
    /// <item>
    /// <term>button1_Click</term>
    /// <description>当计算按钮被按下时，读取数字输入框中的数字和单位下拉选择框的单位，判断是否为非法输入，若为非法输入，输出“非法输入！”并清空输入框，
    /// 若不为非法输入，则通过换算后调用面积计算公式得出面积并输出完整结果在输出框中</description>
    /// </item>
    /// </list>
    /// </summary>
    public partial class Rect : Form
    {
        /// <summary>
        /// 长方形界面的构造函数，调用InitializeComponent()函数构造开始界面
        /// </summary>
        public Rect()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 2号单选控件（正方形）被选中时初始化并打开正方形计算界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                Square square2 = new Square();
                square2.Show();
                this.Close();
            }
        }
        /// <summary>
        /// 在加载长方形面积计算界面时使单位下拉选择框初始处于厘米状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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
                Tri tri2 = new Tri();
                tri2.Show();
                this.Close ();
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
                Circular circular2 = new Circular();
                circular2.Show();
                this.Close () ;
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
            string long1 = textBox1.Text.Trim();
            string width1 = textBox2.Text.Trim();
            double c = 1;
            double d = 1;
            if (double.TryParse(long1, out c) && double.TryParse(width1, out d) && c > 0 && d > 0)
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
