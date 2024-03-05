public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length < 2)
            return 0;

        int n = prices.Length;
        int profit1 = 0;
        int maxProfit = 0;
        int min1 = Int32.MaxValue;
        int min2 = Int32.MaxValue;
        foreach (var p in prices) {
            // just the same code as for max profit for one transaction
            min1 = Math.Min(min1, p);
            profit1 = Math.Max(profit1, p - min1);
            
            // but now consider for the second transaction the minimum is "p" without profit for the 1st transaction
            // because ...
            min2 = Math.Min(min2, p - profit1);
            // then max total profit will be current "p" minus that minimum
            maxProfit = Math.Max(maxProfit, p - min2);
        }
        return maxProfit;
    }

    
}