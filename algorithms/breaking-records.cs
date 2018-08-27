static int[] breakingRecords(int[] scores) {
    int highestScore = scores[0];
    int brokenHighScores = 0;
    int lowestScore = scores[0];
    int brokenLowScores = 0;
        
    foreach (int score in scores) {
        if (score > highestScore) {
            highestScore = score;
            brokenHighScores++;
        }
        if (score < lowestScore) {
            lowestScore = score;
            brokenLowScores++;
        }
    }
    return new int[] {brokenHighScores, brokenLowScores};
}