public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var pos = 0;
        var count = 0;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[pos] = nums[i];
                pos++;
                count++;
            }
        }

        return count;
    }
}