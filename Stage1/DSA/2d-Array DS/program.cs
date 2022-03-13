public static int hourglassSum(List<List<int>> arr)
    {
        List<int> sum = new List<int>();
        
        for(int i=1;i<5;i++)
        {
            for(int j=1;j<5;j++)
            {
                int total = arr[i-1][j-1] + arr[i-1][j] + arr[i-1][j+1]
                                          +  arr[i][j]  +
                            arr[i+1][j-1] + arr[i+1][j] + arr[i+1][j+1];          
                
                sum.Add(total);     
            }
        }
        return sum.Max();
    }
