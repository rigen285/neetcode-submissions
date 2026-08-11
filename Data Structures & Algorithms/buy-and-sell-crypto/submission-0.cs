public class Solution {
    public int MaxProfit(int[] prices) {
        int profitMax = 0;
        int left = 0;
        int right = left + 1;

        while (right<prices.Length){
            int profit = prices[right] - prices[left];
            profitMax = profit>profitMax? profit:profitMax;
            
            if(prices[left]>=prices[right]){
                left = right;
            }
            right++;
        }
        return profitMax;
    }
}
