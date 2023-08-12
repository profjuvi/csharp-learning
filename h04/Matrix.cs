
namespace h04{
    public class Matrix
    {
        int rows;
        int columns;
        int[,] matrix;
        public int Rows
        {
            get { return rows; }
        }
        public int Columns
        {
            get { return columns; }
        }
        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }
        // matrix1 + matrix2
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if ( matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns )
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for ( int i = 0; i < matrix1.Rows; ++i )
            {
                for ( int j = 0; j < matrix1.Columns; ++j )
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        // matrix1 - matrix2
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if ( matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns )
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for ( int i = 0; i < matrix1.Rows; ++i )
            {
                for ( int j = 0; j < matrix1.Columns; ++j )
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }
        // matrix * const
        public static Matrix operator *(Matrix matrix1, int constant)
        {
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for ( int i = 0; i < matrix1.Rows; ++i )
            {
                for ( int j = 0; j < matrix1.Columns; ++j )
                {
                    result[i, j] = matrix1[i, j] * constant;
                }
            }
            return result;
        }
        // matrix1 * matrix2
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if ( matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns )
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for ( int i = 0; i < matrix1.Rows; ++i )
            {
                for ( int j = 0; j < matrix1.Columns; ++j )
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return result;
        }

        // ==
        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if ( ReferenceEquals(matrix1, matrix2) ) return true;
            if ( ReferenceEquals(matrix1, null) || ReferenceEquals(matrix2, null) ) return false;
            if ( matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns ) return false;
            for ( int i = 0; i < matrix1.Rows; ++i )
            {
                for ( int j = 0; j < matrix1.Columns; ++j )
                {
                    if ( matrix1[i, j] != matrix2[i, j] ) return false;
                }
            }
            return true;
        }
        // != 
        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !( matrix1 == matrix2 );
        }
        // Equals
        public override bool Equals(object? obj)
        {
            if ( !(obj is Matrix) ) return false;
            return this == (Matrix)obj;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + rows.GetHashCode();
                hash = hash * 23 + columns.GetHashCode();
                for ( int i = 0; i < rows; ++i )
                {
                    for ( int j = 0; j < columns; ++j )
                    {
                        hash = hash * 23 + matrix[i, j].GetHashCode();
                    }
                }
                return hash;
            }
        }
    }
}