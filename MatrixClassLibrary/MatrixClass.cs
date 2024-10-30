namespace MatrixClassLibrary
{
    public class MatrixClass
    {
        private double[,] _matrix;

        public int RowsCount => _matrix.GetLength(0);
        public int ColsCount => _matrix.GetLength(1);

        public double this[int rows, int cols]
        {
            get => _matrix[rows, cols];
            set => _matrix[rows, cols] = value;
        }

        public MatrixClass(int rows, int cols)
        {
            _matrix = new double[rows, cols];
        }

        public MatrixClass(double[,] matrix)
        {
            _matrix = matrix ?? throw new ArgumentNullException(nameof(matrix));
        }

        public int CountElementsGreaterThan(double userValue)
        {
            return _matrix.Cast<double>().Where(v => v > userValue).Count();
        }

        public int CountElementsGreaterThan(double userValue, int intValue)
        {
            return _matrix.Cast<double>()
                .Select((value, index) => new { Value = value, ColumnIndex = index % _matrix.GetLength(1) })
                .GroupBy(v => v.ColumnIndex)
                .SelectMany(group => group.Where(v => (v.ColumnIndex % intValue == 0) && v.Value > userValue))
                .Count();
        }

    }
}
