public class Solution {
    public int Candy(int[] ratings) {
        int candies = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for (int i = 0; i < ratings.Length; i++) {
            if (!map.ContainsKey(i)) {
                map[i] = 1;
            }
            var leftR = i > 0 ? ratings[i - 1] : -1;
            var currR = ratings[i];            
            if (leftR >= 0 && currR > leftR) {
                map[i] = map[i - 1] + 1;
            }
        }

        for (int i = ratings.Length - 1; i >= 0; i--) {
            var rightR = i < ratings.Length - 1 ? ratings[i + 1] : -1;   
            var currR = ratings[i];      
            if (rightR >= 0 && currR > rightR) {
                map[i] = map[i + 1] + 1;
            }
            var leftR = i > 0 ? ratings[i - 1] : -1;
            if (leftR >= 0 && currR > leftR && map[i] <= map[i - 1] + 1) {
                map[i] = map[i - 1] + 1;
            }
        }
        
        foreach (int k in map.Keys) {
            candies += map[k];
            //Console.WriteLine("" + ratings[k] + " - " + map[k]);
        }
        return candies;
    }
}