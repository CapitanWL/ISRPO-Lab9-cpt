using MatrixClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestsForMatrix
{
    public class MatrixTests
    {
        [Fact]
        public void MatrixTest1()
        {
            double[,] matrixTest1 = new double[,] { { 3, 5 }, { 6, 7 }, { 8, 9 }, { 10, 11 }, { 12, 13 } };
            double result;
            double userValueTest1 = 7;

            var matrixTesting = new MatrixClass(matrixTest1);
            result = matrixTesting.CountElementsGreaterThan(userValueTest1);

            Assert.Equal(6, result);
        }

        [Fact]
        public void MatrixTest2()
        {
            double[,] matrixTest2 = new double[,] { { 0.2, -1 }, { 6, -12 }, { 0.8, 9 }, { 1, 0 } };
            double result;
            double userValueTest2 = 2.8;

            var matrixTesting = new MatrixClass(matrixTest2);
            result = matrixTesting.CountElementsGreaterThan(userValueTest2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void CountElementsTest1()
        {
            double[,] matrixTest1 = new double[,] { { 0, -2 }, { 16, 2 }, { 0.33, 0.12 }, { 18, 9 } };

            double result;
            double userValueTest1 = -6;
            int userIntValue1 = 3;

            var matrixTesting = new MatrixClass(matrixTest1);
            result = matrixTesting.CountElementsGreaterThan(userValueTest1, userIntValue1);

            Assert.Equal(4, result);
        }

        [Fact]
        public void CountElementsTest2()
        {
            double[,] matrixTest2 = new double[,] { { 0, -2, 34 }, { 16, 2, -0.7 }, { 0.33, 0.12, 90 }, { 18, -9, -1 }, { 32, 27, -0.9 } };
            double result;
            double userValueTest2 = 10;
            int userIntValue2 = 2;

            var matrixTesting = new MatrixClass(matrixTest2);
            result = matrixTesting.CountElementsGreaterThan(userValueTest2, userIntValue2);

            Assert.Equal(5, result);
        }

        [Fact]
        public void GetRowColsTest1()
        {
            double[,] matrixTest1 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 8, 9, 10 } };
            int rowsResult;
            int colsResult;

            var matrixTesting = new MatrixClass(matrixTest1);
            rowsResult = matrixTesting.RowsCount;
            colsResult = matrixTesting.ColsCount;

            Assert.Equal(3, rowsResult);
            Assert.Equal(3, colsResult);

        }

        [Fact]
        public void GetRowColsTest2()
        {
            double[,] matrixTest2 = new double[5, 9];
            int rowsResult;
            int colsResult;

            var matrixTesting = new MatrixClass(matrixTest2);
            rowsResult = matrixTesting.RowsCount;
            colsResult = matrixTesting.ColsCount;

            Assert.Equal(5, rowsResult);
            Assert.Equal(9, colsResult);

        }

        [Fact]
        public void GetIndexTest1()
        {
            double[,] matrixTest1 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 8, 9, 10 } };

            var result = matrixTest1[0, 1];

            Assert.Equal(2, result);
        }

        [Fact]
        public void GetIndexTest2()
        {
            double[,] matrixTest1 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 8, 9, 10 } };

            var result = matrixTest1[1, 0];

            Assert.Equal(4, result);
        }

    }
}
