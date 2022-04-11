using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixWinForm
{
    static class SingleOper
    {
        static public int Rank(int razmer, double[,] array)
        {
                int rank = 0;
                int count = 1;
                while (count <= MinValue(array.GetLength(0), array.GetLength(1)))
                {
                    double[,] matrix = new double[count, count];
                    for (int i = 0; i < (array.GetLength(0) - (count - 1)); i++)
                    {
                        for (int j = 0; j < (array.GetLength(1) - (count - 1)); j++)
                        {
                            for (int k = 0; k < count; k++)
                            {
                                for (int c = 0; c < count; c++)
                                {
                                    matrix[k, c] = array[i + k, j + c];
                                }
                            }
                            if (matrix != null)
                                rank = count;
                        }
                    }
                    count++;
                }
                return rank;
        }

        static int MinValue(int first_value, int second_value)
        {
            if (first_value <= second_value) return first_value;
            else return second_value;
        }


        static public double[,] Transpon(int razmer, double[,] array)
        {
            double[,] t_array = new double[razmer, razmer];
            for (int i = 0; i < razmer; i++)
            {
                for (int j = 0; j < razmer; j++)
                {
                    t_array[j, i] = array[i, j];
                }
            }
            return t_array;
        }
        static public double[,] Square( int razmer, double[,] array, int stepen = 1)
        {
            double[,] array_result = array;
            double[,] secondArray = array;
            int count = 1;
            while (count < stepen)
            {
                array_result = new double[razmer, razmer];
                for (int i = 0; i < razmer; i++)
                {
                    for (int j = 0; j < razmer; j++)
                    {
                        for (int c = 0; c < razmer; c++)
                        {
                            array_result[i, j] += array[i, c] * secondArray[c, j];
                        }
                    }
                }
                secondArray = array_result;
                count++;
            }
            return array_result;
        }
    }
}

