static string catAndMouse(int x, int y, int z) {
    int catADistance = Math.Abs(x - z);
    int catBDistance = Math.Abs(y - z);
    if (catADistance == catBDistance)
        return "Mouse C";
    else if (catADistance < catBDistance)
        return "Cat A";
    else
        return "Cat B";
}