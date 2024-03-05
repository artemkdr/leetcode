public class Solution {
    public int MaxProfit(int[] prices) {
        int sumProfit = 0;
        int currentProfit = 0;
        int currentMin = Int32.MaxValue;                
        bool sell = true;
        foreach (int p in prices) {
            if (p < currentMin)  currentMin = p;
            sell = p - currentMin < currentProfit;
            currentProfit = Math.Max(currentProfit, p - currentMin);
            if (sell) {
                sumProfit += currentProfit;
                currentProfit = 0;
                currentMin = p;
            }
        }   
        sumProfit += currentProfit;
        return sumProfit;     
    }
}