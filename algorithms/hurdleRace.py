def hurdleRace(k, height):
    height.sort()
    return height[-1] - k if height[-1] >= k else 0