using System;


namespace JaggedArray      //DO NOT Change the namespace name
{
    public class Program    //DO NOT Change the class name
    {
        public static void Main(string[] args)    //DO NOT change the method signature
        {
            int team,i,j,attempt;
	        Console.WriteLine("Enter the number of teams :");
	        team = Convert.ToInt32(Console.ReadLine());
	        int[][] teamsArray = new int[team][];
	        
	        for (i=0;i<team;i++)
	        {
	            Console.WriteLine("No.of attempts for team {0}",(i+1));
	            attempt = Convert.ToInt32(Console.ReadLine());
	            teamsArray[i]=new int [attempt];
	            
	        }
	        for(i=0;i<team;i++)
	        {
	            Console.WriteLine("Enter the score of team {0}",(i+1));
	            for(j=0;j<teamsArray[i].Length;j++)
	            {
	                teamsArray[i][j] = Convert.ToInt32(Console.ReadLine());
	            }
	        }
        }
        
        public static String GetTotalScore(int[][] array)        //DO NOT change the method signature
        {
            String result =" ";
            int i,j;
            for(i=0;i<array.Length;i++)
            {
                int sum =0;
                for(j=0;j<array[i].Length;j++)
                {
                    sum += array[i][j];
                    result += "Team "+(i+1)+" Total Score is "+sum+".";
                }
            }
            return result;
        }

    }
}
