using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator
{
    /// <summary>
    /// <c>AreaMathForm</c>
    /// 包含所求图形的面积计算公式，即正方形、长方形 、三角形和圆形
    /// <list type="bullet">
    /// <item>
    /// <term>SqureArea</term>
    /// <description>计算正方形面积</description>
    /// </item>
    /// <item>
    /// <term>RecArea</term>
    /// <description>计算长方形面积</description>
    /// </item>
    /// <item>
    /// <term>TriArea</term>
    /// <description>计算三角形面积</description>
    /// </item>
    /// <item>
    /// <term>RoundArea</term>
    /// <description>计算圆形面积</description>
    /// </item>
    /// </list>
    /// </summary>
    public class AreaMathForm
    {
        /// <summary>
        /// 计算正方形面积
        /// </summary>
        /// <param name="length">边长</param>
        /// <returns>length*length</returns>
        public static decimal SqureArea(decimal length)
        {
            return length * length;
        }
        /// <summary>
        /// 计算长方形面积
        /// </summary>
        /// <param name="length">长</param>
        /// <param name="width">宽</param>
        /// <returns>length * width</returns>
        public static decimal RecArea(decimal length, decimal width)
        {
            return length * width;
        }
        /// <summary>
        /// 计算三角形面积
        /// </summary>
        /// <param name="width">底</param>
        /// <param name="height">高</param>
        /// <returns>width * height/2</returns>
        public static decimal TriArea(decimal width, decimal height)
        {
            return width * height / 2;
        }
        /// <summary>
        /// 计算圆形面积
        /// </summary>
        /// <param name="diam">直径</param>
        /// <returns>pi*(diam/2) * (diam / 2);</returns>
        public static decimal RoundArea(decimal diam)
        {
            return (decimal)3.1415926 * (diam / 2) * (diam / 2);
        }
    }
}
