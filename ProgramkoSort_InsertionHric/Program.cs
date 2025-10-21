using System;

using System.Diagnostics;



class Program

{

    static void Main()

    {

        int[] arr = { 9, 3, 7, 1, 5, 4, 8, 2, 6 };

        TestInsertionSort((int[])arr.Clone());

    }



    static void TestInsertionSort(int[] arr)

    {

        Console.WriteLine("\n--- Insertion Sort ---");

        Measure("Insertion Sort", () =>

        {

            InsertionSort(arr);

        });



        Console.WriteLine("Výsledek:");

        PrintArray(arr);

    }



    static void InsertionSort(int[] arr)

    {

        int n = arr.Length;

        for (int i = 1; i < n; ++i)

        {

            int key = arr[i];

            int j = i - 1;



            while (j >= 0 && arr[j] > key)

            {

                arr[j + 1] = arr[j];

                j = j - 1;

            }

            arr[j + 1] = key;

        }

    }



    static void Measure(string name, Action action)

    {

        var watch = Stopwatch.StartNew();

        action();

        watch.Stop();



        Console.WriteLine($"{name} trvalo: {watch.Elapsed.TotalMilliseconds:F3} ms");

    }



    static void PrintArray(int[] arr)

    {

        Console.WriteLine(string.Join(", ", arr));

    }

}

