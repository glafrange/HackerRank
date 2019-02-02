static string angryProfessor(int k, int[] a) {
    int onTime =
        a.Where((arrivalTime) => arrivalTime <= 0).ToArray().Length;
    return onTime < k ? "YES" : "NO";
}