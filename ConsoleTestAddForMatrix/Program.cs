using MatrixClassLibrary;

public class Program
{
    static void Main()
    {

        CTest_Driver testDriver = new CTest_Driver();

    }

}

public class CTest_Driver
{
    MatrixClass matrixTesting;
    StreamWriter log;
    private string filename = "logFile.dat";
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public CTest_Driver()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    {
        log = new StreamWriter(filename, true);
        run();
    }
    private void run()
    {
        log.WriteLine("\\\\\\\\ Log start: " + DateTime.Now + " \\\\\\\\");

        MatrixTest1();
        MatrixTest2();

        CountElementsTest1();
        CountElementsTest2();

        GetRowColsTest1();
        GetRowColsTest2();

        GetIndexTest1();
        GetIndexTest2();

        log.WriteLine("\\\\\\\\ Log end: " + DateTime.Now + " \\\\\\\\");
    }

    private void MatrixTest1()
    {
        double[,] matrixTest1 = new double[,] { { 3, 5 }, { 6, 7 }, { 8, 9 }, { 10, 11 }, { 12, 13 } };
        double result;
        double userValueTest1 = 7;

        matrixTesting = new MatrixClass(matrixTest1);
        result = matrixTesting.CountElementsGreaterThan(userValueTest1);

        log.WriteLine(DateTime.Now + ": Method: " + System.Reflection.MethodInfo.GetCurrentMethod() +
            ": Result: " + result);
        log.Flush();
    }

    private void MatrixTest2()
    {
        double[,] matrixTest2 = new double[,] { { 0.2, -1 }, { 6, -12 }, { 0.8, 9 }, { 1, 0 } };
        double result;
        double userValueTest2 = 2.8;

        matrixTesting = new MatrixClass(matrixTest2);
        result = matrixTesting.CountElementsGreaterThan(userValueTest2);

        log.WriteLine(DateTime.Now + ": Method: " + System.Reflection.MethodInfo.GetCurrentMethod() +
            ": Result: " + result);
        log.Flush();
    }

    private void CountElementsTest1()
    {
        double[,] matrixTest1 = new double[,] { { 0, -2 }, { 16, 2 }, { 0.33, 0.12 }, { 18, 9 } };

        double result;
        double userValueTest1 = -6;
        int userIntValue1 = 3;

        string matrixString = "";
        for (int i = 0; i < matrixTest1.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTest1.GetLength(1); j++)
            {
                matrixString += $"matrix[{i},{j}] = {matrixTest1[i, j]}\n";
            }
        }

        matrixTesting = new MatrixClass(matrixTest1);
        result = matrixTesting.CountElementsGreaterThan(userValueTest1, userIntValue1);

        log.WriteLine(DateTime.Now + ": Method: " + System.Reflection.MethodInfo.GetCurrentMethod() +
            ": Result: " + result);
        log.Flush();
    }

    private void CountElementsTest2()
    {
        double[,] matrixTest2 = new double[,] { { 0, -2, 34 }, { 16, 2, -0.7 }, { 0.33, 0.12, 90 }, { 18, -9, -1 }, { 32, 27, -0.9 } };
        double result;
        double userValueTest2 = 10;
        int userIntValue2 = 2;



        matrixTesting = new MatrixClass(matrixTest2);
        result = matrixTesting.CountElementsGreaterThan(userValueTest2, userIntValue2);

        log.WriteLine(DateTime.Now + ": Method: " + System.Reflection.MethodInfo.GetCurrentMethod() +
            ": Result: " + result);
        log.Flush();
    }

    private void GetRowColsTest1()
    {
        double[,] matrixTest1 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 8, 9, 10 } };
        int rowsResult;
        int colsResult;

        matrixTesting = new MatrixClass(matrixTest1);
        rowsResult = matrixTesting.RowsCount;
        colsResult = matrixTesting.ColsCount;

        log.WriteLine(DateTime.Now + ": Method: " + System.Reflection.MethodInfo.GetCurrentMethod() +
            ": Rows result: " + rowsResult + ": Columns result: " + colsResult);
        log.Flush();
    }

    private void GetRowColsTest2()
    {
        double[,] matrixTest2 = new double[5, 9];
        int rowsResult;
        int colsResult;

        matrixTesting = new MatrixClass(matrixTest2);
        rowsResult = matrixTesting.RowsCount;
        colsResult = matrixTesting.ColsCount;

        log.WriteLine(DateTime.Now + ": Method: " + System.Reflection.MethodInfo.GetCurrentMethod() +
            ": Rows result: " + rowsResult + ": Columns result: " + colsResult);
        log.Flush();
    }

    private void GetIndexTest1()
    {
        double[,] matrixTest1 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 8, 9, 10 } };

        log.WriteLine(DateTime.Now + ": Method: " + System.Reflection.MethodInfo.GetCurrentMethod() +
                      ": Result: " + matrixTest1[0, 1]);
        log.Flush();
    }

    private void GetIndexTest2()
    {
        double[,] matrixTest1 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 8, 9, 10 } };

        log.WriteLine(DateTime.Now + ": Method: " + System.Reflection.MethodInfo.GetCurrentMethod() +
                      ": Result: " + matrixTest1[1, 0]);
        log.Flush();
    }
}