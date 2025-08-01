using Assginment_OOP_1_C__Advanced;
using System;
class program
{
    static void Main(string[] args)
    {

        #region Question 01
        //int[] arr = { 5, 1, 4, 2, 3, 9, 6, 7, 8 };

        //implements.OptimizedBubbleSort(arr);
        //Console.WriteLine("Sorted array: ");
        //Console.WriteLine(string.Join(" ", arr));

        #endregion

        #region Question 02
        var range = new Range<int>(1, 10);
        Console.WriteLine($"Range: {range.Min} to {range.Max}");
        Console.WriteLine($"Contains 5: {range.Contains(5)}");
        Console.WriteLine($"Length: {range.length()}");
        var range2 = new Range<double>(1.5, 10.5);
        Console.WriteLine($"Range: {range2.Min} to {range2.Max}");
        Console.WriteLine($"Contains 5.5: {range2.Contains(5.5)}");
        Console.WriteLine($"Length: {range2.length()}");

        #endregion





    }
}