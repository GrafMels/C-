string val = "442";
        int from = 10;
        int to = 16;
 
        string binary = Convert.ToString(Convert.ToInt32(val, from), to);
        Console.WriteLine(binary);