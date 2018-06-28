function main() {
    var n = parseInt(readLine());
    a = readLine().split(' ');
    a = a.map(Number);
    // Write Your Code Here
    let swaps = 0;
    for (let i=0; i < n; i++) {
        let numSwaps = 0;
        for (let j=0; j < n - 1; j++) {
            if (a[j] > a[j+1]) {
                let tmp = a[j];
                a[j] = a[j+1];
                a[j+1] = tmp;
                numSwaps++;
            }
        }
        swaps += numSwaps;
        if (numSwaps === 0) {
          break;
        }
    }
    console.log("Array is sorted in " + swaps + " swaps.");
    console.log("First Element: " + a[0]);
    console.log("Last Element: " + a[a.length - 1]);
    
}