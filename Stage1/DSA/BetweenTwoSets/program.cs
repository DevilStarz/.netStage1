public static int getTotalX(List<int> a, List<int> b)
    {
        int total =0;
        int number = a.Max();
        
        Enumerable.Range(number, b.Min()).ToList()
            .ForEach(n=>
            {
                if(a.All(e=> number % e == 0|| e%number ==0)
                && b.All(e=> number % e == 0 || e%number  == 0))
                total++;
                number++;
            });
        
        return total;
    }