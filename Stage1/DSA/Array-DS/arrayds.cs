public static List<int> reverseArray(List<int> a)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n;i++)
        {
            a.Add(Convert.ToInt32(Console.ReadLine()));
        }
        a.Reverse();
        return a;

    }