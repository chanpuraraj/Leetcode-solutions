public class Solution {
    public int LengthOfLastWord(string s) {
        var length = 0;
        for(var i = s.Length-1; i>=0; i--){
             if(s[i] == ' '){
                if(length>0){
                    return length;
                }
                continue;
            }
            length++;
        }
        return length;
    }
}