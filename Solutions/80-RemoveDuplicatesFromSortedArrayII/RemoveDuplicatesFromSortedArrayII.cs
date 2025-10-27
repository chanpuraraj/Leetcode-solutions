public class Solution {
    public int RemoveDuplicates(int[] nums) {

        //first solution is brute force where we can use dictionary to store key and count.
        //before adding to array, we can check if the the dictionary has more third count then prevent adding from array

        //second solution is start from index 2. check previous value, if not matched, no problem at all.
        //if previous value matched, then check previous to previous by n-2, if that matched the avoid adding
        
        //Adding check for edge cases
        if(nums.Length < 3){
            return nums.Length;
        }
        var count = 2;
        var curr = 2;
        for(var i = 2; i < nums.Length;i++){
            if(nums[i] == nums[curr-1] && nums[i] == nums[curr-2]){
                continue;
            }        

            nums[curr] = nums[i];
            Console.WriteLine("Adding value at :"+curr+": "+nums[i]);
            curr++;
            count++;
        }
        return count;
    }
}