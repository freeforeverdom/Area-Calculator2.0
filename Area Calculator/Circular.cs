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
    /// 主类 <c>Circular : Form</c>
    /// 包含圆形面积计算界面的按键设置，提供圆形面积计算功能及转到其他图形面积计算的选项
    /// <list type="bullet">
    /// <item>
    /// <term>Circular</term>
    /// <description>圆形界面的构造函数，调用InitializeComponent()函数构造开始界面</description>
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
    /// <term>radioButton3_CheckedChanged</term>
    /// <description>3号单选控件（三角形）被选中时初始化并打开三角形计算界面</description>
    /// </item>
    /// <item>
    /// <term>Circular_Load</term>
    /// <description>在加载圆形面积计算界面时使单位下拉选择框初始处于厘米状态</description>
    /// </item>
    /// <item>
    /// <term>button1_Click</term>
    /// <description>当计算按钮被按下时，读取数字输入框中的数字和单位下拉选择框的单位，判断是否为非法输入，若为非法输入，输出“非法输入！”并清空输入框，
    /// 若不为非法输入，则通过换算后调用面积计算公式得出面积并输出完整结果在输出框中</description>
    /// </item>
    /// </list>
    /// </summary>
    public partial class Circular : Form
    {
        /// <summary>
        /// 圆形界面的构造函数，调用InitializeComponent()函数构造开始界面
        /// </summary>
        public Circular()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 在加载圆形面积计算界面时使单位下拉选择框初始处于厘米状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Circular_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
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
                Rect rect5 = new Rect();
                rect5.Show();
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
                Square square5 = new Square();
                square5.Show();
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
                Tri tri5 = new Tri();
                tri5.Show();
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
            string  diam= textBox1.Text.Trim();
            double d = 1;
            if (double.TryParse(diam, out d)&&d>0)
            {
                decimal m = Convert.ToDecimal(diam);
                decimal tran = (decimal)2.54;
                decimal s = m * tran;
                decimal MeasureArea = AreaMathForm.RoundArea(m);
                decimal Tran = (decimal)6.4516;
                string company = comboBox1.Text;
                if (company == "厘米（cm)")
                {
                    String Diam = m.ToString("0.000");
                    String str = MeasureArea.ToString("0.000");
                    textBox3.Text = "直径为" + Diam + "厘米的圆的面积为" + str + "平方厘米";
                }
                else if (company == "英寸（in）")
                {
                    String Diam1 = s.ToString("0.000");
                    decimal MeasureArea1 = MeasureArea * Tran;
                    String str1 = MeasureArea1.ToString("0.000");
                    textBox3.Text = "直径为" + Diam1 + "厘米的圆的面积为" + str1 + "平方厘米";
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
