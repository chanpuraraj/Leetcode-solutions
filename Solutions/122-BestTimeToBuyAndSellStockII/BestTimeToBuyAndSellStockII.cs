public class Solution {
    public int MaxProfit(int[] prices) {
        var length = prices.Length;
        if(length == 1){
            return 0;
        }

        var sum = 0;
        for(var i = 1; i< length; i++){
            if(prices[i]> prices[i-1]){
                var diff = prices[i] - prices[i-1];
                sum+= diff;
            }
        }

        return sum;
    }
}