    static void miniMaxSum(int[] arr) {
        long totalSum = 0;
        long minSum;
        long maxSum;
        
        foreach (int number in arr) {
            totalSum += number;
        }
        
        minSum = totalSum;
        maxSum = 0;
        
        foreach (long number in arr) {
            if (totalSum - number < minSum) minSum = totalSum - number;
            if (totalSum - number > maxSum) maxSum = totalSum - number;
        }
        
        Console.WriteLine("{0} {1}", minSum, maxSum);

    }