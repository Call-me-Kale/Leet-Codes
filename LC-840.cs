public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int height = grid.Length;
        int width = grid[0].Length;
        int numOfMagicSquares = 0;

        for(int i = 0; i < height - 2; i++){
            for(int j = 0; j < width - 2; j++) {
                if(CalcAllRowsColumnsDiagonals(grid, i, j)){
                    numOfMagicSquares++;
                }
            }
        }

        return numOfMagicSquares;
    }

    public bool CalcAllRowsColumnsDiagonals(int[][] grid, int column, int row) {
        int magicNumber = grid[column][row] + grid[column][row+1] + grid[column][row+2];
        
        if(magicNumber > 15){
            return false;
        }

        HashSet<int> usedNums = new HashSet<int>();

        for(int i = 0; i < 3; i++) {
            for(int j = 0; j < 3; j++) {
                int val = grid[column + i][row + j];
                if(val < 1 || val > 9){
                    return false;
                }
                if(!usedNums.Add(val)){
                    return false;
                }
            }
        }

        //Calc rows
        for(int i = 1; i < 3; i++) {
            int sum = grid[column + i][row] + grid[column + i][row+1] + grid[column + i][row+2];
            if(magicNumber != sum){
                return false;
            } 
        }

        //Calc columns
        for(int i = 0; i < 3; i++) {
            int sum = grid[column][row + i] + grid[column + 1][row + i] + grid[column + 2][row + i];
            if(magicNumber != sum){
                return false;
            }
        }

        //Calc diagonals
        int diagonal1 = grid[column][row] + grid[column + 1][row + 1] + grid[column + 2][row + 2];
        int diagonal2 = grid[column + 2][row] + grid[column + 1][row + 1] + grid[column][row+2];
        if(magicNumber != diagonal1 || magicNumber != diagonal2){
            return false;
        }

        return true;
    }
}
