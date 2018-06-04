using System;
using System.Text;

namespace lesson9
{
    public class Matrix
    {
        int [,] _array;
        string _name;

        public Matrix (string name,int rows, int cols)
        {
            _name=name;
            _array = new int [rows,cols];
            Random r = new Random();
            for(int i =0;i<rows;i++)
                for (int j=0;j<cols;j++)
                    _array[i,j]=r.Next(1,10);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Matrix: {_name}\r\n");
            for(int i=0;i<_array.GetLength(0);i++)
            {
                for(int j=0;j<_array.GetLength(1);j++)
                    sb.Append(_array[i,j]+" ");
                sb.Append("\r\n");
            }
            return sb.ToString();
        }

        public static Matrix operator +(Matrix left,Matrix right)
        {
            Matrix result = new Matrix("Result", left._array.GetLength(0),left._array.GetLength(1));
            for (int i = 0;i<left._array.GetLength(0);i++)
                for(int j=0;j<left._array.GetLength(1);j++)
                    result._array[i,j]=left._array[i,j]+right._array[i,j];
            return result;
        }

        public static Matrix operator ++(Matrix m)
        {
            Matrix result = new Matrix("Result",m._array.GetLength(0),m._array.GetLength(1));
            for (int i = 0;i<m._array.GetLength(0);i++)
                for(int j=0;j<m._array.GetLength(1);j++)
                    result._array[i,j]=m._array[i,j]+1;
            return result;
        }
        

        }
    }
