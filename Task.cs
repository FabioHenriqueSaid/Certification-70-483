/*
 * Author: Fábio Said
 * Date: 21/12/2019 23:10
 * 
 */

using System.Threading;
using System;

namespace CAP1
{
    public class Task
    {
        public static void First()
        {
            for (int count = 0; count <= 300; count++)
            {
                Time();
                Console.Write("1");
            }
        }

        public static void Second()
        {
            for (int count = 0; count <= 300; count++)
            {
                Time();
                Console.Write("2");
            }
        }

        public static void Third()
        {
            for (int count = 0; count <= 300; count++)
            {
                Time();
                Console.Write("3");
            }
        }

        private static void Time()
        {
            Thread.Sleep(10);
        }
    }
}