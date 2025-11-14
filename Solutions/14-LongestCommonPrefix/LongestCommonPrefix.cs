public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //use first word by comparing it with all word of array. if first character match then 

        Array.Sort(strs);

        // the idea behind the problem was sort the array and only compare first element with last element. since its sorted array, first element and last element should have something common, if no, then there's no common prefix
        var firstElement = strs[0];
        var lastElement = strs[strs.Length-1];
        var idx = 0;
        
        while(idx < firstElement.Length){
            if(firstElement[idx] == lastElement[idx]){
                idx++;
            } else {
                break;
            }
        }

        return firstElement.Substring(0, idx); //substring is a function to cut the string by giving from and to index 

    }
}