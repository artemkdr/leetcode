public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int min = Int32.MaxValue;                
        foreach (int p in prices) {
            if (p < min) min = p;            
            profit = Math.Max(profit, p - min);
        }        
        return profit;        
    }
}