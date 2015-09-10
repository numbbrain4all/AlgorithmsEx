// better solution found here -> https://leetcode.com/discuss/54454/swapping-numbers-to-the-same-index-cell

public class Solution {
    public int MissingNumber(int[] nums) {
        int[] slot = new int[nums.Length+1];

        for (var i = 0; i<slot.Length; i++) slot[i] = -1;
        for (var j = 0; j<nums.Length; j++) slot[nums[j]] = nums[j];
        for (var i = 0; i<slot.Length; i++) if (slot[i] == -1) return i;
        
        throw new Exception("Missing Number Not Found");
    }
}