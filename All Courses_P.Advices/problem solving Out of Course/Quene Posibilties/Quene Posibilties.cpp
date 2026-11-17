#include <iostream>
#include <vector>
using namespace std;

#define SIZE 10

// Function prototypes
int ft_ten_queens_puzzle();
void solve(int row, vector<int>& board, int& count);
bool is_safe(int row, int col, const vector<int>& board);
void print_solution(const vector<int>& board);

// Main function to solve the puzzle
int ft_ten_queens_puzzle() {
    vector<int> board(SIZE, -1); // Vector to store queen positions; initialized to -1
    int count = 0;               // Counter for the number of solutions

    // Start solving the problem
    solve(0, board, count);

    return count; // Return the total number of solutions
}

// Recursive function to place queens row by row
void solve(int row, vector<int>& board, int& count) {
    // Base case: all queens are placed
    if (row == SIZE) {
        count++;             // Increment the solution counter
        print_solution(board); // Optional: Print the solution
        return;
    }

    // Try placing a queen in each column of the current row
    for (int col = 0; col < SIZE; col++) {
        if (is_safe(row, col, board)) {
            board[row] = col;    // Place the queen
            solve(row + 1, board, count); // Recur to place the next queen
            // No need to "undo" as board[row] will be overwritten in the next iteration
        }
    }
}

// Check if placing a queen at (row, col) is safe
bool is_safe(int row, int col, const vector<int>& board) {
    for (int i = 0; i < row; i++) {
        // Check column conflict and diagonal conflicts
        if (board[i] == col ||
            board[i] - i == col - row ||
            board[i] + i == col + row) {
            return false; // Not safe
        }
    }
    return true; // Safe
}

// Optional: Print a valid solution
void print_solution(const vector<int>& board) {
    for (int i = 0; i < SIZE; i++) {
        cout << board[i] << " ";
    }
    cout << endl;
}

// Main program to test the solution
int main() {
    int possibilities = ft_ten_queens_puzzle();
    cout << "Number of possibilities: " << possibilities << endl;
    return 0;
}
