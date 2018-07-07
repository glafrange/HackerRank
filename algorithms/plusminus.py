def plusMinus(arr, n):
  positives = 0
  negatives = 0
  zeros = 0
  for i in range(0, len(arr)):
    if (arr[i] > 0):
      positives += 1
    elif (arr[i] < 0):
      negatives += 1
    else:
      zeros += 1
  print(positives / n)
  print(negatives / n)
  print(zeros / n)