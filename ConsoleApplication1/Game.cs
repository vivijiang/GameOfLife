using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Game
    {
        public static int row;
        public static int col;
        public static int[,] Next(int[,] input)
        {
            row = input.GetLength(0);
            col = input.GetLength(1);
            int[,] result = new int[row, col];
            ScanRow(input, result, 0, 0);
            return result;
        }

        public static void ScanRow(int[,] source, int[,] result, int curRowIndex, int curColumnIndex)
        {
            if (curRowIndex == row)
            {
                return;
                //ScanCurCell(source, result, curRowIndex, curColumnIndex);
            }
            else
            {
                ScanCurCell(source, result, curRowIndex, curColumnIndex);
                curColumnIndex = (curColumnIndex + 1) % col;
                if (curColumnIndex == 0) curRowIndex++;
                ScanRow(source, result, curRowIndex, curColumnIndex);
            }

        }

        public static int[] dx = { 0, 0, -1, 1, -1, -1, 1, 1 };
        public static int[] dy = { -1, 1, 0, 0, -1, 1, -1, 1 };


        private static bool CheckIsInBound(int curRow, int curCol)
        {
            if (!(curRow >= 0 && curRow < row)) return false;
            if (!(curCol >= 0 && curCol < col)) return false;
            return true;
        }

        public static void ScanCurCell(int[,] source, int[,] result, int curRow, int curCol)
        {
            int count = 0;
            if (CheckIsInBound(curRow + dx[0], curCol + dy[0])) count += source[curRow + dx[0], curCol + dy[0]];
            if (CheckIsInBound(curRow + dx[1], curCol + dy[1])) count += source[curRow + dx[1], curCol + dy[1]];
            if (CheckIsInBound(curRow + dx[2], curCol + dy[2])) count += source[curRow + dx[2], curCol + dy[2]];
            if (CheckIsInBound(curRow + dx[3], curCol + dy[3])) count += source[curRow + dx[3], curCol + dy[3]];
            if (CheckIsInBound(curRow + dx[4], curCol + dy[4])) count += source[curRow + dx[4], curCol + dy[4]];
            if (CheckIsInBound(curRow + dx[5], curCol + dy[5])) count += source[curRow + dx[5], curCol + dy[5]];
            if (CheckIsInBound(curRow + dx[6], curCol + dy[6])) count += source[curRow + dx[6], curCol + dy[6]];
            if (CheckIsInBound(curRow + dx[7], curCol + dy[7])) count += source[curRow + dx[7], curCol + dy[7]];

            if (source[curRow, curCol] == 1)
            {
                if (count == 2 || count == 3)
                    result[curRow, curCol] = 1;
            }

            else
            {
                if (count == 3)
                    result[curRow, curCol] = 1;
                else
                {
                    result[curRow, curCol] = 0;
                }
            }

        }
    }
}
