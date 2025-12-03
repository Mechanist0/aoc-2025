#include <stdatomic.h>
#include <stdio.h>

int main() {
  FILE *fptr;                     // Create pointer to a file
  fptr = fopen("input.txt", "r"); // Set the pointer to point to this file
  char puzzleInput[100];          // Char of length 3 to store current line

  int dial = 50;
  int zero = 0;
  // While file has a line
  // Read that line into puzzleInput with a max size of 3
  // Print that line to console
  char dir;
  int num;
  while (fscanf(fptr, "%c%3d\n", &dir, &num) != EOF) {
    int clicks = 0;

    printf("%c%d, %d, %d\n", dir, num, dial, zero);
    if (dir == 'L') {
      dial -= num;
    } else {
      dial += num;
    }

    while (dial < 0) {
      if (dial + num != 0)
        zero++;
      dial += 100;
      printf("Rotated to 99\n");
    }

    while (dial > 99) {
      dial -= 100;
      if (dial != 0)
        zero++;
      printf("Rotated to 0\n");
    }

    if (dial == 0)
      zero++;

    printf("%c%d, %d, %d\n\n", dir, num, dial, zero);
  }
  // Close the file
  fclose(fptr);
  return 0;
}
