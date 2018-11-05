static int getMoneySpent(int[] keyboards, int[] drives, int budget) {
    int largestPurchase = -1;
    
    foreach (int keyboard in keyboards)
    {
        foreach(int drive in drives)
        {
            if (keyboard + drive > largestPurchase && keyboard + drive <= budget)
                largestPurchase = keyboard + drive;
        }
    }
    return largestPurchase;
}