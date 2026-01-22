public class Solution {
    public int MinimumPairRemoval(int[] nums) {
        List<int> nums2 = nums.ToList();
        bool isASC = false;
        int numberOfOperations = 0;
        if(nums2.Count == 1){
            return 0;
        }
        while(!isASC) {
            if(nums2.Count == 1){
                return numberOfOperations;
            }
            bool isProper = true;
            int minimalPairFirstIndex = 0;
            int minimalPairSum = nums2[0] + nums2[1];
            for(int i = 0; i < nums2.Count-1; i++) {
                if(nums2[i] > nums2[i+1]) {
                    isProper = false;
                }

                if(nums2[i] + nums2[i+1] < minimalPairSum) {
                    minimalPairFirstIndex = i;
                    minimalPairSum = nums2[i] + nums2[i+1];
                }
            }
            minimalPairSum = nums2[minimalPairFirstIndex] + nums2[minimalPairFirstIndex+1];
            if(isProper) {
                isASC = true;
            }
            if(!isProper) {
                nums2.RemoveRange(minimalPairFirstIndex, 2);
                nums2.Insert(minimalPairFirstIndex, minimalPairSum);
                numberOfOperations += 1;
            }
        }

        return numberOfOperations;
    }
}
