using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator.Tests
{
    /// <summary>
    /// 主类 <c>AreaMathForm</c>
    /// 包含面积计算公式的测试方法
    /// <list type="bullet">
    /// <item>
    /// <term>SqureAreaTest</term>
    /// <description>测试正方形面积公式输出值是否与理论值相等</description>
    /// </item>
    /// <item>
    /// <term>SqureAreaTestType</term>
    /// <description>测试正方形面积公式输出值类型是否与输入值相同</description>
    /// </item>
    /// <item>
    /// <term>RecAreaTest</term>
    /// <description>测试长方形面积公式输出值是否与理论值相等</description>
    /// </item>
    /// <item>
    /// <term>RecAreaTestType</term>
    /// <description>测试长方形面积公式输出值类型是否与输入值相同</description>
    /// </item>
    /// <item>
    /// <term>TriAreaTest</term>
    /// <description>测试三角形面积公式输出值是否与理论值相等</description>
    /// </item>
    /// <item>
    /// <term>TriAreaTestType</term>
    /// <description>测试三角形面积公式输出值类型是否与输入值相同</description>
    /// </item>
    /// <item>
    /// <term>RoundAreaTest</term>
    /// <description>测试圆形面积公式输出值是否与理论值相等</description>
    /// </item>
    /// <item>
    /// <term>RoundAreaTestType</term>
    /// <description>测试圆形面积公式输出值类型是否与输入值相同</description>
    /// </item>
    /// </list>
    /// </summary>
    [TestClass()]
    public class AreaMathFormTests
    {
        /// <summary>
        /// 测试正方形面积公式输出值是否与理论值相等
        /// </summary>
        [TestMethod()]
        public void SqureAreaTest()
        {
            decimal length = (decimal)4.555;
            var result_expected = length * length;
            var result_real= AreaMathForm.SqureArea(length);
            Assert.IsTrue(result_expected == result_real);
        }/// <summary>
         /// 测试正方形面积公式输出值类型是否与输入值相同
         /// </summary>
        [TestMethod()]
        public void SqureAreaTestType()
        {
            decimal length = (decimal)4.555;
            var result = AreaMathForm.SqureArea(length);
            Assert.IsInstanceOfType(result,typeof(decimal));
        }
        /// <summary>
        /// 测试长方形面积公式输出值是否与理论值相等
        /// </summary>
        [TestMethod()]
        public void RecAreaTest()
        {
            decimal length = (decimal)4.555;
            decimal width = (decimal)2.5;
            var result_expected = length * width;
            var result_real= AreaMathForm.RecArea(length, width);
            Assert.IsTrue(result_expected == result_real);
        }
        /// <summary>
        /// 测试长方形面积公式输出值类型是否与输入值相同
        /// </summary>
        [TestMethod()]
        public void RecAreaTestType()
        {
            decimal length = (decimal)4.555;
            decimal width = (decimal)2.5;
            var result= AreaMathForm.RecArea(length, width);
            Assert.IsInstanceOfType(result, typeof(decimal));
        }
        /// <summary>
        /// 测试三角形面积公式输出值是否与理论值相等
        /// </summary>
        [TestMethod()]
        public void TriAreaTest()
        {
            decimal width = (decimal)4.555;
            decimal height = (decimal)2.5;
            var result_expected =width*height/2;
            var result_real = AreaMathForm.TriArea(width,height);
            Assert.IsTrue(result_expected == result_real);
        }
        /// <summary>
        /// 测试三角形面积公式输出值类型是否与输入值相同
        /// </summary>
        [TestMethod()]
        public void TriAreaTestType()
        {
            decimal width = (decimal)4.555;
            decimal height = (decimal)2.5;
            var result = AreaMathForm.TriArea(width, height);
            Assert.IsInstanceOfType(result, typeof(decimal));
        }
        /// <summary>
        /// 测试圆形面积公式输出值是否与理论值相等
        /// </summary>
        [TestMethod()]
        public void RoundAreaTest()
        {
            decimal diam = (decimal)4.555;
            var result_expected =(decimal)3.1415926*(diam/2)*(diam/2);
            var result_real = AreaMathForm.RoundArea(diam);
            Assert.IsTrue(result_expected == result_real);
        }
        /// <summary>
        /// 测试圆形面积公式输出值类型是否与输入值相同
        /// </summary>
        [TestMethod()]
        public void RoundAreaTestType()
        {
            decimal diam = (decimal)4.555;
            var result = AreaMathForm.RoundArea(diam);
            Assert.IsInstanceOfType(result, typeof(decimal));
        }
    }
}