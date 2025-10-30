public class Solution {
    public void Rotate(int[] nums, int k) {
        var size = nums.Length;
        var temp = new int[size];

        var pos = 0;
        for(var i = 0; i < nums.Length; i++){
            pos = (i+k)% size; 
            temp[pos] = nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = temp[i];
        }
    }
}
