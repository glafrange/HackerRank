static int birthdayCakeCandles(int[] candleSizes) {
    int largestCandleSize = 0;
    int numberOfLargestCandles = 1;
    
    for (int candleIndex = 0; candleIndex < candleSizes.Length; candleIndex++) {
        int candleSize = candleSizes[candleIndex];
        if (candleSize > largestCandleSize) {
            largestCandleSize = candleSize;
            numberOfLargestCandles = 1;
        }
        else if (candleSize == largestCandleSize) {
          numberOfLargestCandles++;
        }
    }
    return numberOfLargestCandles;
}