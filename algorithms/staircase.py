def staircase(n):
  for i in range(1, n + 1):
    for j in range(0, n - i):
      sys.stdout.write(" ")
    for k in range(0, i):
      sys.stdout.write("#")
    sys.stdout.write("\n")