function dayOfProgrammer (year) {
  
    const julian = [ 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 ];
    const gregorian = [ 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 ];
    const transitionYear = [ 31, 15, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 ];
    const targetDays = 256;

    let daysPassed = 0;
    let month = 0;
    let day = 0;

    if (year < 1918) {
        if (year % 4 == 0)
            julian[1]++;

        while (daysPassed < targetDays) {

            if (daysPassed + julian[month] > targetDays) {
                day = julian[month] - ((daysPassed + julian[month]) - targetDays);
                break;
            }

            daysPassed += julian[month];
            month++;
        }
    }
    else if (year == 1918) {
        while (daysPassed < targetDays) {
            if (daysPassed + julian[month] > targetDays) {
                day = transitionYear[month] - ((daysPassed + julian[month]) - targetDays);
                break;
            }
            daysPassed += transitionYear[month];
            month++;
        }
    }
    else {

        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            gregorian[1]++;
            
        while (daysPassed < targetDays) {

            if (daysPassed + julian[month] > targetDays) {
                day = gregorian[month] - ((daysPassed + julian[month]) - targetDays);
                break;
            }

            daysPassed += gregorian[month];
            month++;
        }
    }

    const d = new Date(year, month, day);
    return `${d.getDate()>9 ? d.getDate() : '0' + d.getDate()}.${d.getMonth()>9 ? d.getMonth()+1 : '0' + (d.getMonth()+1)}.${year}`
}