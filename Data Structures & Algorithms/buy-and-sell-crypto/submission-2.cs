public class Solution {
    public int MaxProfit(int[] prices) {
        int l =0;
        int maxPro =0;

        for(int r=l; r<prices.Length;r++){
            if(prices[r]<prices[l]){
                l=r;
            }

            int profit = prices[r] - prices[l];

            maxPro = Math.Max(maxPro,profit);
        }
        return maxPro;
    }
}
