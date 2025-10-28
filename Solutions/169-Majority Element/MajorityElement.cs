public class Solution {
    public int MajorityElement(int[] nums) {
        //1. brute force solution:
        // use dictionary to keep count of element. store each value with count in dictionary
        // iterate over each element, whoever gets highest value is the answer

        // 2. use two for loop

        var map = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++){
            if(map.TryGetValue(nums[i], out int count)){
                map[nums[i]]= count+1;
            }else{
                map[nums[i]] = 1;
            }
        }
        var max = 0;
        var result = 0;
        foreach(var dic in map){
            Console.WriteLine("Key:" +dic.Key+" value :"+ dic.Value);
            if(max< dic.Value){
                max = dic.Value;
                result = dic.Key;
            }
        }
        

        return result;
        
    }
}