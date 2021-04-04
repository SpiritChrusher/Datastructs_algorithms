using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructs_algorithms
{
    public class Binfa
    {

        public static int Sullyeszt(int[] K, int from, int end)
        {
            int x = K[from];
            var child = from + from;

            while (child <= end)
            {
                if (child < end && K[child + 1] > K[child])
                {
                    child += 1;
                    Console.WriteLine("fut");
                }
                if (K[child] > x)
                {
                    K[from] = K[child];
                    from = child;
                    child = from + from;
                }
                else
                    child = end + 1;         
            }
            K[from] = x;
            return K[from];
        }


        public static int KUPAC_RENDEZ(int[] K)
        {
            int i = K.Length / 2;

            while (i > 0)
            {
                Sullyeszt(K, i, K.Length);
                i -= 1;
            }
            i = K.Length;

            while (i > 1)
            {
                int temp = K[i];
                K[i] = K[1];
                K[1] = temp;
                i -= 1;
                Sullyeszt(K, 1, i);
            }

        }
    }
}
