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
    /// 主类 <c>begin : Form</c>
    /// 包含初始选择界面的按键效果设置，提供用户初始计算图形的选择
    /// <list type="bullet">
    /// <item>
    /// <term>begin</term>
    /// <description>开始界面的构造函数，调用InitializeComponent()函数构造开始界面，并使5号单选控件（默认）处于选中状态</description>
    /// </item>
    ///  <item>
    /// <term>begin_Load</term>
    /// <description>加载初始界面时调用的函数</description>
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
    /// <term>radioButton4_CheckedChanged</term>
    /// <description>4号单选控件（圆形）被选中时初始化并打开圆形计算界面</description>
    /// </item>
    /// </list>
    /// </summary>
    public partial class begin : Form
    {
        /// <summary>
        /// 调用InitializeComponent()函数构造开始界面，并使5号单选控件（默认）处于选中状态
        /// </summary>
        public begin()
        {
            InitializeComponent();
            radioButton5.Checked = true ;
        }
        /// <summary>
        /// 加载初始界面时调用的函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void begin_Load(object sender, EventArgs e)
        {

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
                Rect rect1 = new Rect();
                rect1.Show();
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
                Square square1 = new Square();
                square1.Show();
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
                Tri tri1 = new Tri();
                tri1.Show();
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
                Circular circular1 = new Circular();
                circular1.Show();
            }
        }
    }
}
