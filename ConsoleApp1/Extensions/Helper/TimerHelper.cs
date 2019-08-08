using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLX.Extensions.Helper
{
    public static class TimerHelper
    {
        public static float GetFunctionTimeCost(this Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds / 1000f;
        }

        public async static Task<float> GetFunctionTimeCostAsync(this Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await Task.Run(action);
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds / 1000f;
        }
        
    }
}
