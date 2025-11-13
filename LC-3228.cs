public class Solution {
    public int MaxOperations(string s) {
        int numberOfOperations = 0;
        int countOfOnes = 0;
        bool isZero = false;
        
        System.Text.StringBuilder sb = new System.Text.StringBuilder(s); 

        for(int i = 0; i < sb.Length; i++){
            if(sb[i] == '0') {
                isZero = true;
            } else {
                isZero = false;
            }
            if(isZero && i == sb.Length - 1) {
                numberOfOperations += countOfOnes;
                break;
            } else if(i == sb.Length - 1 && !isZero) {
                break;
            }
            if(isZero && sb[i+1] == '1') {
                numberOfOperations += countOfOnes;
            }
            if(sb[i] == '1') {
                countOfOnes += 1;
            }
            
        }

        return numberOfOperations;
    }
}
