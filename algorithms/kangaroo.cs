static string kangaroo(int firstKangarooStartingDistance, int firstKangarooJumpLength, int secondKangarooStartingDistance, int secondKangarooJumpLength) {
    var firstKangaroo = new {
        StartingDistance = firstKangarooStartingDistance,
        JumpLength = firstKangarooJumpLength
    };
    var secondKangaroo = new {
        StartingDistance = secondKangarooStartingDistance,
        secondKangarooJumpLength = secondKangarooJumpLength
    };
    
    int secondKangarooCurrentDistance = secondKangarooStartingDistance;
    int firstKangarooCurrentDistance = firstKangarooStartingDistance;
        
    if (firstKangarooJumpLength > secondKangarooJumpLength && firstKangarooStartingDistance < secondKangarooStartingDistance) {
        while(firstKangarooCurrentDistance < secondKangarooCurrentDistance ) {
            firstKangarooCurrentDistance += firstKangarooJumpLength;
            secondKangarooCurrentDistance += secondKangarooJumpLength;
        }
        return firstKangarooCurrentDistance == secondKangarooCurrentDistance ? "YES" : "NO";
    }
    else if (secondKangarooJumpLength > firstKangarooJumpLength && secondKangarooStartingDistance < firstKangarooStartingDistance) {
        while(secondKangarooCurrentDistance < firstKangarooCurrentDistance ) {
            secondKangarooCurrentDistance += secondKangarooJumpLength;
            firstKangarooCurrentDistance += secondKangarooJumpLength;
        }
        return firstKangarooCurrentDistance == secondKangarooCurrentDistance ? "YES" : "NO";
    }
    else
        return "NO";
    
}
