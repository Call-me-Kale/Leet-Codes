public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Array.Sort(nums);
        int max = 0;
        int lastNumber = 0;
        int currentNumberCount = 1;
        int numberOfSameMax = 1;
        for(int i = 0; i < nums.Count(); i++) {
            if(lastNumber != nums[i]) {
                lastNumber = nums[i];
                currentNumberCount = 1;
            } else {
                currentNumberCount = currentNumberCount + 1;
            }
            if(currentNumberCount == max){
                numberOfSameMax = numberOfSameMax + 1;
            }
            if(currentNumberCount > max){
                max = currentNumberCount;
                numberOfSameMax = 1;
            }
        }

        return max * numberOfSameMax;
    }
}
