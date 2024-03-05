public class Solution {
    public int HIndex1(int[] citations) {
        Array.Sort(citations);
        int result = 0;
        for (int i=citations.Length-1; i>=0; i--)
        {
            if (citations[i] > result)
                result++;
            else
                return result;
        }

        return result;
    }

    public int HIndex(int[] citations) {
        if (citations.Length == 1) {
            return Math.Min(citations[0], 1);
        }
        int n = citations.Length;
        int hIndex = 0;
        int[] hIndexes = new int[n];
        for (int i = 0; i < n; i++) {
            var h1 = citations[i];
            if (hIndex == 0) hIndex = Math.Min(h1, 1);
            int c = 1;
            if (i > 0 && h1 < hIndexes[i - 1]) {
                hIndex = hIndexes[i - 1];
            } else {
                for (int j = 0; j < n; j++) {
                    if (i == j) continue;
                    var h = citations[j];
                    if (h >= h1) {                        
                        if (c++ >= h1) {
                            hIndex = Math.Max(hIndex, h1);                                                    
                            break;
                        } else if (c > hIndex) {
                            hIndex = c;                        
                        }                    
                    }                
                }  
            }
            hIndexes[i] = hIndex;
        }        
        return hIndex;
    }
}