public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var count = 1; //starting from 1 because first element is already added to array
        var curr = 1;

        //starting from index 1 to the end. for each index, it will check if the previous value is not same, then add to the array. if it match with previous value, then skip from adding
        for(var i = 1; i< nums.Length; i++){
            if(nums[i] != nums[i-1]){
                nums[curr] = nums[i];
                curr++;
                count++;
            }
        }
        return count;
    }
}