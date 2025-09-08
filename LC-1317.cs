public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int[] outArr = GetNoZero([0,n]);

        return outArr;       
    }

    public int[] GetNoZero(int[] x) {
        int[] outArr = [x[0] + 1, x[1] - 1];
        if(!outArr[0].ToString().Contains("0") && !outArr[1].ToString().Contains("0")){
            return outArr;
        } else {
            return GetNoZero(outArr);
        }
    }
}
