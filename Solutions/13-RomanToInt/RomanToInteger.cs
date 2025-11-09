public class Solution {
    public int RomanToInt(string s) {
        //largest to smallest from left to right, than add
        //if right side large than left, that means substraction
        //if same letter than add

        //start iteration from start. if s[i]>=s[i+1], then add to sum, else add -s[i] to sum
        var sum = 0;
        sum+=GetValueByString(s[0]);
        Console.WriteLine(sum);
        for(var i = 1; i< s.Length;i++){
            var currValue = GetValueByString(s[i]);
            var prevValue = GetValueByString(s[i-1]);

            if(currValue > prevValue){
                sum+=-prevValue+currValue-prevValue; //removing previous element from the sum because we just realized that previous value needs to be substracted from currValure and add it to sum
                
            }else{
                sum+=currValue;
            }
        }

       
        return sum;
    }

    private int GetValueByString(char c){
        switch(c){
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
        }
        return 0;
    }
}