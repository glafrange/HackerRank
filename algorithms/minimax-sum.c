void miniMaxSum(int arr_count, int* arr) {
    long long fullSum = 0;
    long long largest = 0;
    long long smallest = 0;
    for(int i = 0; i < arr_count; i++)
    {
        fullSum += arr[i];
        smallest += arr[i];
    }
    
    for (int i = 0; i < arr_count; i++)
    {
        long long fullSumWithout = fullSum - arr[i];
        if (fullSumWithout > largest)
        {
            largest = fullSumWithout;
        }
        else if (fullSumWithout < smallest)
        {
            smallest = fullSumWithout;
        }
    }
    
    printf("%li %li", smallest, largest);

}