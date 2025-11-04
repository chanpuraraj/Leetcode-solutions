public class Solution {
    public bool CanJump(int[] nums) {
        var length = nums.Length;
        
        if(nums.Length == 1){
            return true;
        }

        if(nums.Length > 1 && nums[0] == 0){
            return false;
        }

        var maxReach = 0;
        for(var i = 0; i < length; i++){
            if(i>maxReach){
                return false;
            }         

            maxReach = Math.Max(maxReach, i+nums[i]);
        }

        return true;
    }
}