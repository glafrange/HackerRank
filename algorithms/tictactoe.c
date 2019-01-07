// function drawBoard() {
//   const totalRows = 5;
//   const totalColumns = 5;

//   for (let row = 0; row < totalRows; row++) {
//     for (let column = 0; column < totalColumns; column++) {
//       if (row % 2 === 0 && column % 2 === 0) {
//         console.log('+')
//       }
//       else if (row % 2 === 0) {
//         console.log('-')
//       }
//       else if (column % 2 === 0) {
//         console.log('|')
//       }
//       else {
//         console.log(' ')
//       }
//     }
//     console.log('\n')
//   }
// }

// drawBoard()

#include <stdio.h>

int drawBoard() {
  int totalRows = 7;
  int totalColumns = 7;
  for (int row = 0; row < totalRows; row++) {
    for (int column = 0; column < totalColumns; column++) {
      if (row % 2 != 0 && column % 2 == 0) {
        printf("+");
      }
      else if (row % 2 != 0) {
        printf("-");
      }
      else if (column % 2 != 0) {
        printf("|");
      }
      else {
        printf(" ");
      }
    }
    printf("\n");
  }
}

void main() {
  drawBoard();
}