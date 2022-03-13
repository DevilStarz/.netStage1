public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long min = arr.Take(4).Sum(item=> (long)item);
        long max = arr.Skip(1).Sum(item=> (long)item);
        Console.WriteLine($"{min} {max}");

    }