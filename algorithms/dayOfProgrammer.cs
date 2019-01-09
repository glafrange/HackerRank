static string dayOfProgrammer(int year) {
    int[] julian = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    int[] gregorian = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    int[] transitionYear = { 31, 15, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    int targetDays = 256;
    int currentDays = 0;
    int month = 0;
    int daysOfMonth = 0;

    if (year < 1918) {
        if (year % 4 == 0)
            currentDays++;

        while (currentDays < targetDays) {
            if (currentDays + julian[month] > targetDays) {
                daysOfMonth = julian[month] - ((currentDays + julian[month]) - targetDays);
                break;
            }
            currentDays += julian[month];
            month++;
        }
    }
    else if (year == 1918) {
        while (currentDays < targetDays) {
            if (currentDays + julian[month] > targetDays) {
                daysOfMonth = transitionYear[month] - ((currentDays + julian[month]) - targetDays);
                break;
            }
            currentDays += transitionYear[month];
            month++;
        }
    }
    else {
        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            currentDays++;
        while (currentDays < targetDays) {
            if (currentDays + julian[month] > targetDays) {
                daysOfMonth = gregorian[month] - ((currentDays + julian[month]) - targetDays);
                break;
            }
            currentDays += gregorian[month];
            month++;
        }
    }
    
    return $"{daysOfMonth}.0{month + 1}.{year}";

}
