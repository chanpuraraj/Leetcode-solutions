public class Solution {
    public int MaxProfit(int[] prices) {
        //find the lowest element and keep find the difference with each element. largest difference will be the output
        var lowestElement = 0;
        var maxDiff = 0;
        for(var i = 0; i < prices.Length; i++){
            if(i == 0) lowestElement = prices[i];

            if(prices[i] < lowestElement){
                lowestElement = prices[i];
            }
            var diff = prices[i] - lowestElement;
            if(maxDiff< diff){
                maxDiff = diff;
            }
        }
        return maxDiff;
    }
}