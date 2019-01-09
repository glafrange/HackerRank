// Complete the dayOfProgrammer function below.
function dayOfProgrammer(year) {
  var d;
  if (year < 1918) {
      d = findDate('julian', year % 4 == 0, year);
  } else if (year == 1918) {
      d = findDate('transitionYear', false, year);
  } else {
      d = findDate('gregorian', year % 400 == 0 || year % 4 == 0 && year % 100 != 0, year)
  }
  return `${d.getDate()>9 ? d.getDate() : '0' + d.getDate()}.${d.getMonth()>9 ? d.getMonth()+1 : '0' + (d.getMonth()+1)}.${year}`
}

function findDate(selectedCalendar, isLeapYear, year) {
  const targetDays = 256;
  let daysPassed = 0;
  let month = 0;
  let day = 0;
  const calendars = {
      julian: [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31],
      gregorian: [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31],
      transitionYear: [31, 15, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
  };
  const calendar = calendars[selectedCalendar];
  if (isLeapYear) {
      calendar[1] += 1;
  }

  while (daysPassed < targetDays) {
      if (daysPassed + calendar[month] > targetDays) {
          day = calendar[month] - ((daysPassed + calendar[month]) - targetDays);
          break;
      }
      daysPassed += calendar[month];
      month++;
  }
  return new Date(year, month, day)
}