using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructs_algorithms
{
    public static class Searches
    {
       public static int full_search_while(int[] vec, int value)
        {
            int i = 0;
            while (i < vec.Length && vec[i] != value)
            {
                i++;
            }
            if (i > vec.Length)
            {
                Console.WriteLine("there is no such element");
                return -1;
            }
            else
            {
                return i;
            }
        }

        public static int full_search_for(int[] vec, int value)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] == value)
                {
                    return i;
                }
            }
            Console.WriteLine("Wasn't found");
            return -1;
        }

        public static int full_search_rec(int[] vec, int value)
        {

            if (vec.Length == 0)
            {
                Console.WriteLine("empty array");
                return -1;
            }
            else if (vec[0] == value)
            {
                return 0;
            }
            else
            {
                return full_search_rec(vec[1..^0], value) + 1;
            }
        }

        public static int full_search_rec_mine(int[] vec, int value, int i) // itt kell egy 0 kezdőérték paraméternek
        {
            if (vec.Length == 0)
            {
                Console.WriteLine("empty array");
                return -1;
            }
            else if (vec[i] == value)
            {
                return i;
            }
            else
            {
                i++;
                return full_search_rec_mine(vec, value, i);
            }
        }
    }
}
