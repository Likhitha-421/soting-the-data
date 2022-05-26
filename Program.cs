using System;

namespace sortingdata
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {

                using (StreamReader sr = new StreamReader("E:/likhitha.txt"))
                {
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();




            int[] Cclass = new int[5];
            Cclass[0] = 8;
            Cclass[1] = 6;
            Cclass[2] = 10;
            Cclass[3] = 9;
            Cclass[4] = 7;
            


            mergeSort(Cclass, 0, 5 - 1);

            for (int i = 0; i < Cclass.Length; i++)
            {
                Console.WriteLine(Cclass[i]);
            }
        }

        public static void mergeSort(int[] arr, int p, int r)
        {
        if (p < r)
            {
            int q = (p + r) / 2;
            mergeSort(arr, p, q);
            mergeSort(arr, q + 1, r);
            merge(arr, p, q, r);
              }
        }

            public static void merge(int[] arr, int p, int q, int r)
            {
                int i, j, k;
                int n1 = q - p + 1;
                int n2 = r - q;
                int[] L = new int[n1];
                int[] R = new int[n2];
                for (i = 0; i < n1; i++)
                {
                    L[i] = arr[p + i];
                }
                for (j = 0; j < n2; j++)
                {
                    R[j] = arr[q + 1 + j];
                }
                i = 0;
                j = 0;
                k = p;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
        
    }
}



