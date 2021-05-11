using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructs_algorithms
{
    public class Binfa
    {

        public static void KUPAC_RENDEZ(int[] K)
        {
            int i = K.Length / 2;

            while (i > 0)
            {
                //Sullyeszt(K, i, K.Length);
                heapify(K, i, K.Length);
                i -= 1;
            }
            i = K.Length-1;

            while (i > 1)
            {
                int temp = K[i];
                K[i] = K[1];
                K[1] = temp;
                i -= 1;
                //Sullyeszt(K, 1, i);
                heapify(K, 1,i);
            }
            
        }

        private static void heapify(int[] array, int i, int m)
        {
            int j;
            while (2 * i + 1 <= m)
            {
                j = 2 * i + 1;
                if (j < m)
                {
                    if (array[j - 1] < array[j])
                    {
                        j++;
                        Console.WriteLine("m");
                    }
                }
                if (array[i] < array[j])
                {
                    swapKeys(array, i, j);
                    i = j;
                }
                else
                    i = m;
            }
        }

        private static void heapify2(int[] array, int i, int m)
        {
            int j = array[i];
            int child = 2 * i + 1;
            while (child <= m)
            {
                //j = 2 * i + 1;
                if (j < m)
                {
                    if (array[j] < array[j + 1])
                        j++;
                }
                if (array[i] < child)
                {
                    swapKeys(array, i, j);
                    i = j;
                }
                else
                    i = m;
            }
        }

        public static void swapKeys(int[] array, int i, int j)
        {
            int temp;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void Sullyeszt(int[] K, int from, int end)
        {
            int i = 0;
            int szamolchild = 0;

            int x = K[from]+1;
            var child = ((K.Length - 2) / 2);//from + from;

            while (child <= end)
            {
                Console.WriteLine(++i);
                if (child < end && K[child + 1] > K[child])
                {
                    child += 1;
                    Console.WriteLine($"child: {++szamolchild}");
                }
                if (K[child] > x)
                {
                    Console.WriteLine($"ennyi:{++i}");
                    K[from] = K[child];
                    from = child;
                    child = from + from;
                }
                else
                    child = end + 1;         
            }
            from = end;
           
        }


    }
}
