static int countingValleys(int n, string s) {
    int level = 0;
    int valleys = 0;
    
    foreach(char step in s)
    {
        if (step == 'U')
        {
            level++;
            if (level == 0)
                valleys++;
        }
        else if (step == 'D')
            level--;
    }
    return valleys;
}