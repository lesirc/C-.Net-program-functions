using System;
public class ArrayExample
{
    static void printMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Minimum element is: " + min);
    }

    static void printMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Maximum element is: " + max);
    }
    public static void Main(string[] args)
    {
        int[] arr1 = { 25, 10, 20, 15, 40, 50 };
        int[] arr2 = { 12, 23, 44, 11, 54 };

        printMin(arr1);//passing array to function  
        printMin(arr2);

        printMax(arr1);
        printMax(arr2);
        Console.ReadKey();
    }
    
}
