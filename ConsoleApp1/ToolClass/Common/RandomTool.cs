using System;
using System.Collections.Generic;
using CLX.Extensions.Collections;

namespace CLX.ToolClass.Common
{
    public static class RandomTool
    {
        /// <summary>
        /// 得到从begNum起依此递增的cout个数字随机打乱后的列表
        /// </summary>
        public static IList<int> GetRandomList(int begNum,int count,int det=1)
        {
            var list = new int[count];
            return ListTool.GetList(begNum,count,det).Shuffle();
        }

        /// <summary>
        /// 得到来自factory生成的count个元素随机打乱后的列表
        /// </summary>
        public static IList<T> GetRandomList<T>(Func<T> factroy,int count)
        {
            return ListTool.GetList(factroy,count).Shuffle();
        }

        /// <summary>
        /// 得到来自factory生成的count个元素随机打乱后的列表
        /// </summary>
        public static IList<T> GetRandomList<T>(Func<int,T> factroy,int count)
        {
            var list = new T[count];
            return ListTool.GetList(factroy,count).Shuffle();
        }

        /// <summary>
        /// 得到一个 row 行，col列的随机数字矩阵
        /// 数字从begNum开始，每次递增det
        /// </summary>
        public static IList<IList<int>> GetRandomMatrix(int begNum,int row,int col,int det = 1)
        {
            return GetRandomList(begNum, count: row * col, det: det).ToMatrix(row);
        }

        /// <summary>
        /// 得到一个 row 行，col列的随机数字矩阵
        /// 数字由factroy产生
        /// </summary>
        public static IList<IList<T>> GetRandomMatrix<T>(Func<T> factroy,int row,int col)
        {
            return GetRandomList(factroy, row * col).ToMatrix(row);
        }

        /// <summary>
        /// 得到一个 row 行，col列的随机数字矩阵
        /// 数字由factroy产生
        /// factroy的参数的是从0递增到row*col-1
        /// </summary>
        public static IList<IList<T>> GetRandomMatrix<T>(Func<int,T> factory,int row,int col)
        {
            return GetRandomList(factory, row * col).ToMatrix(row);
        }
    }
}
