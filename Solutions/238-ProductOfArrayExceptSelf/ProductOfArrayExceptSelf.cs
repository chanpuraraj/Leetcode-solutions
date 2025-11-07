public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        // Brute force solution where  product of all element is stored and for each iteration we use division.
        // However, this is not ideal solution since I have used couple of hacks to handle zero case.
        // It works and passed all test, but ideally I should go with other tactics
        var sum = 1;
        var isZeroExist = false;
        var isNonZeroExist = false;
        var zeroCount = 0;
        foreach(var num in nums){
            if(num!=0){
                sum*= num;
                isNonZeroExist = true;
            }else{
                isZeroExist = true;
                zeroCount++;
            }
        }

        if(!isNonZeroExist) sum = 0;
        var result = new int[nums.Length];

        for(var  i = 0; i< nums.Length; i++){
            var curr = nums[i];
            if(curr==0){
                if(zeroCount>1){
                    result[i] = 0;
                }else{
                    result[i] = sum;
                }
                
                continue;
            }

            if(isZeroExist){
                result[i] = 0;
                continue;
            }
            result[i] = sum/curr;
        }

        return result;
    }
}