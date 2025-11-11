public class Solution {
    public string IntToRoman(int num) {
        //brute force that I referred from chatGPT is:
        // create two arrays, one stores all numeric value including 7 rows which is provided in table plus + 6 values which is provided in substract condition
        // so if the value is: 4: IV, 9: IX etc.


        var value = new int[] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        var symbols = new string[]{"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        string s = "";
        for(int i = 0; i< value.Length && num>0; i++){
            while(num >= value[i]){
                s+=symbols[i];//MMMDCCXLIX
                num = num - value[i];
            }
        }
        return s;
    }
}