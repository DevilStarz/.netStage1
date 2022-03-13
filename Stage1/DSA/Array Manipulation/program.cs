public static long arrayManipulation(int n, List<List<int>> queries)
    {
     
     long[]  outputArray= new long[n];
                for (int i = 0; i < queries.Count(); i++) {
                   outputArray[queries[i][0]-1]=outputArray[queries[i][0]-1] +queries[i][2];
                   if(queries[i][1]<n)
                   {
                   outputArray[queries[i][1]]=outputArray[queries[i][1]]- queries[i][2];   
                   }
                }
                long temp=0,max=0;
                for(int i=0;i<n;i++){
                    temp=temp+outputArray[i];
                    if(temp>max)
                        max=temp;
                }
                 return max;   
    }
