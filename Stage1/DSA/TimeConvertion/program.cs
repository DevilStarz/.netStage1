public static string timeConversion(string s)
    {
        bool convert = DateTime.TryParse(s,out DateTime time);
        if(convert)
        {
            return time.ToString("HH:mm:ss");
        }
        return "Invalid input";

    }