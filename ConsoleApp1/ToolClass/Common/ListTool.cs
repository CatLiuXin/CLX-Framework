using CLX.Extensions.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLX.ToolClass.Common
{
    public static class ListTool
    {
        /// <summary>
        /// 得到从begNum起依此递增的cout个数字的列表
        /// </summary>
        public static IList<int> GetList(int begNum, int count, int det = 1)
        {
            var list = new int[count];
            return list.ResetBy(id => id * det + begNum);
        }

        /// <summary>
        /// 得到来自factory生成的count个元素的列表
        /// </summary>
        public static IList<T> GetList<T>(Func<T> factroy, int count)
        {
            var list = new T[count];
            return list.ResetBy(factroy);
        }

        /// <summary>
        /// 得到来自factory生成的count个元素的列表
        /// </summary>
        public static IList<T> GetList<T>(Func<int, T> factroy, int count)
        {
            var list = new T[count];
            return list.ResetBy(factroy);
        }

        /// <summary>
        /// 得到一个 row 行，col列的数字矩阵
        /// 数字从begNum开始，每次递增det
        /// </summary>
        public static IList<IList<int>> GetMatrix(int begNum, int row, int col, int det = 1)
        {
            return GetList(begNum, count: row * col, det: det).ToMatrix(row);
        }

        /// <summary>
        /// 得到一个 row 行，col列的数字矩阵
        /// 数字由factroy产生
        /// </summary>
        public static IList<IList<T>> GetMatrix<T>(Func<T> factroy, int row, int col)
        {
            return GetList(factroy, row * col).ToMatrix(row);
        }

        /// <summary>
        /// 得到一个 row 行，col列的数字矩阵
        /// 数字由factroy产生
        /// factroy的参数的是从0递增到row*col-1
        /// </summary>
        public static IList<IList<T>> GetMatrix<T>(Func<int, T> factory, int row, int col)
        {
            return GetList(factory, row * col).ToMatrix(row);
        }
    }
}
