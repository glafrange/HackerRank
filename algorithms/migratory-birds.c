int migratoryBirds(int ar_count, int* ar) {
  int counter[6] = {0, 0, 0, 0, 0, 0};
  
  for (int i = 0; i < ar_count; i++) {
    counter[ar[i]]++;
  }
  
  int largest = 0;
  for (int i = 0; i < 6; i++) {
    if (counter[i] > counter[largest]) {
      largest = i;
    }
  }
  
  return largest;
}