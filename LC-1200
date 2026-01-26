public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        
        IList<IList<int>> result = [];
        int minDiff = 0;
        
        for(int i = 0; i < arr.Length - 1; i++) {
            if(minDiff == 0 || minDiff > arr[i + 1] - arr[i]) {
                minDiff = arr[i+1] - arr[i];
                result.Clear();
            }
            if(arr[i+1] - arr[i] == minDiff){
                result.Add(new List<int>{arr[i], arr[i+1]});
            }
        }

        return result;
    }
}
