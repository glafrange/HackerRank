#include <stdio.h>

struct Board{
  int cellCount;
  char cells[9];
};

int drawBoard(struct Board board) {
  int totalRows = 5;
  int totalColumns = 5;
  int cellIndex = 0;

  for (int row = 0; row < totalRows; row++) 
  {
    for (int column = 0; column < totalColumns; column++) 
    {
      if (row % 2 != 0 && column % 2 != 0) 
      {
        printf("+");
      }
      else if (row % 2 != 0) 
      {
        printf("-");
      }
      else if (column % 2 != 0) 
      {
        printf("|");
      }
      else 
      {
        printf("%c", board.cells[cellIndex]);
        cellIndex++;
      }
    }
    printf("\n");
  }
}

int main() {
  struct Board gameBoard;
  gameBoard.cellCount = 9;
  gameBoard.cells[0] = 'x';
  gameBoard.cells[1] = 'o';
  gameBoard.cells[2] = 'x';
  gameBoard.cells[3] = 'o';
  gameBoard.cells[4] = 'x';
  gameBoard.cells[5] = 'o';
  gameBoard.cells[6] = ' ';
  gameBoard.cells[7] = ' ';
  gameBoard.cells[8] = 'x';

  drawBoard(gameBoard);
}
