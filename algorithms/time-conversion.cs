static string timeConversion(string s) {
    string sHours = s.Substring(0,2);
    int intHours = int.Parse(sHours);
    if (s.IndexOf("PM") > 0)
    {
        if (intHours < 12)
            intHours += 12;
        s = s.Replace(sHours, intHours.ToString());
    }
    else 
    {
        if (intHours >= 12) {
            intHours -= 12;
            s = s.Replace(sHours, "0" + intHours.ToString());
        }
    }
    return s.Substring(0, s.Length -2);
}