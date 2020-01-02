/*
 * Author: Fábio Said
 * Date: 21/12/2019 23:10
 * 
 */

using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CAP1
{
    public class ExecuteTask
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.Invoke(() => Task.First(), () => Task.Second(), () => Task.Third());
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine(" Task Completed! {0}", stopwatch.ElapsedMilliseconds / 1000.0);

            stopwatch.Reset();
            stopwatch.Start();
            Task.First();
            Task.Second();
            Task.Third();
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine(" Task Completed! {0}", stopwatch.ElapsedMilliseconds / 1000.0);
            Console.ReadKey();
        }
    }
}