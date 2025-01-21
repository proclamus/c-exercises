    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var countApplesInHouse = 0;
        var countOrangesInHouse = 0;
        for(int i=0;i<apples.Count();i++)
        {
            apples[i] = a+apples[i];
            if(apples[i] >= s && apples[i] <= t)
            {
                countApplesInHouse++;
            }
        }
        
        for(int i=0;i<oranges.Count();i++)
        {
            oranges[i] = b+oranges[i];
            if(oranges[i] >= s && oranges[i] <= t)
            {
                countOrangesInHouse++;
            }
        }
        
        Console.WriteLine(countApplesInHouse);
        Console.WriteLine(countOrangesInHouse);
    }

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var countApplesInHouse = 0;
        var countOrangesInHouse = 0;
        
        countApplesInHouse = apples.Count(apple => a + apple >= s && a + apple <= t);
        countOrangesInHouse = oranges.Count(orange => b + orange >= s && b + orange <= t );
        
        Console.WriteLine(countApplesInHouse);
        Console.WriteLine(countOrangesInHouse);
    }
