public static int formingMagicSquare(List<List<int>> s)
    {
        int res = int.MaxValue;
        int[ , , ] all = new int[8,3,3]
        {
            {{4,9,2},{3,5,7},{8,1,6}},
            {{2,9,4},{7,5,3},{6,1,8}},
            {{8,1,6},{3,5,7},{4,9,2}},
            {{6,1,8},{7,5,3},{2,9,4}},
            {{8,3,4},{1,5,9},{6,7,2}},
            {{4,3,8},{9,5,1},{2,7,6}},
            {{6,7,2},{1,5,9},{8,3,4}},
            {{2,7,6},{9,5,1},{4,3,8}}
        };
        int[][] l = s.Select(a=>a.ToArray()).ToArray();
        int tmp;
        for(int i =0;i<8;i++)
        {
            tmp=0;
            tmp+=Math.Abs(all[i,0,0]-l[0][0]);
            tmp+=Math.Abs(all[i,0,1]-l[0][1]);
            tmp+=Math.Abs(all[i,0,2]-l[0][2]);
            
            tmp+=Math.Abs(all[i,1,0]-l[1][0]);
            tmp+=Math.Abs(all[i,1,1]-l[1][1]);
            tmp+=Math.Abs(all[i,1,2]-l[1][2]);
            
            tmp+=Math.Abs(all[i,2,0]-l[2][0]);
            tmp+=Math.Abs(all[i,2,1]-l[2][1]);
            tmp+=Math.Abs(all[i,2,2]-l[2][2]);
            
            if(tmp<res)
            
                res = tmp;
            
            
        }
        return res;
    }
