namespace Datastructs_algorithms
{
    public static class Selection
    {
        public static void Min_select_order(int[] v)
        {
            int cout = 0;
            for (int i = 0; i < v.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < v.Length; j++)
                {
                    if (v[j] < v[min]) 
                    {
                        min = j;
                    }
                }
                int temp = v[i];
                v[i] = v[min];
                v[min] = temp;
                cout++;
                System.Console.WriteLine($"cout: {cout}");
            }

            foreach (var item in v)
            {
                System.Console.WriteLine(item);
            }
        }

        public static void Max_select_order(int[] v)
        {
            int i = v.Length;
            while (i < 100)
            {
                
            }
        }
    }
}