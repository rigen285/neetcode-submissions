public class Solution {
    public int MaxProfit(int[] prices) {
        int l=0;
        int delta = 0;
        int maxDelta = delta;

        for(int r=0; r<prices.Length ;r++){
            delta = prices[r] - prices[l];
            maxDelta = Math.Max(delta,maxDelta);

            if(prices[l]>prices[r]){
                l=r;
            }
        }
        return maxDelta;
    }
}
