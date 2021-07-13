using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MatrixPr;

namespace MatrixPr.Tests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void sum_Matrix3x5_8return()
        {
            //add
                Matrix temp = new Matrix(3, 5);
            
            //assert
            Assert.AreEqual(8,temp.sum());
        }
    }
}
