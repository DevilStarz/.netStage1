public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        
       List<int> res = new List<int>();
       foreach(string s in queries)
       {
           int count = 0;
           for(int i=0;i<strings.Count();i++)
           {
               if(strings[i].Equals(s))
               {
                   count++;
               }
           }
           res.Add(count);
       }
       return res;
        
    }