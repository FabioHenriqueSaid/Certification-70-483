/*
 * Author: Fábio Said
 * Date: 21/12/2019 23:10
 * 
 */

using System.Threading;
using System;
using System.Linq;
using System.Threading.Tasks;

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

        /* 
         * Caso queria substituir os for usados nos metodos a cima
         * Você também consegue um tempo de execucao maior caso use os metodos a baixo.
         */
        public void ParallelFor()
        {
            Parallel.For(0, 300, (i) =>
            {
            });
        }

        public void ParallelForEach()
        {
            var lista = Enumerable.Range(0, 300);
            Parallel.ForEach(lista, (item) =>
            {
            });
        }

        //Para a execução 
        public void ParallelLoopState() {
            Parallel.For(0, 300, (int i, ParallelLoopState state) =>
            {
                if (i == 10) {
                    Console.WriteLine("O loop foi parado na posiçao {0}",i);
                    state.Stop();
                }
            });
        }
    }
}