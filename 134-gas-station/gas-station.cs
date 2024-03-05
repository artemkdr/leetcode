public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {        
        int totalSum = 0, index = -1, sumFromLastDiff = 0;
        for (var i = 0; i < gas.Length; i++) {
            int diff = gas[i] - cost[i];
            totalSum += diff;   
            sumFromLastDiff += diff;            
            if (diff < 0 && sumFromLastDiff < 0) {
                sumFromLastDiff = 0;
                index = -1;
            } else if (diff >= 0 && index == -1) index = i;            
        }
        return totalSum >= 0 ? index : -1;
    }
    
}