public class Solution {
    Random random;
    int count = 0;
    Dictionary<int,int[]> map = new Dictionary<int,int[]>();

    public Solution(int[][] rects) {
        random = new Random();
        foreach (var r in rects) {   
            map[count] = new int[4] { r[0], r[1], Math.Abs(r[2] - r[0]) + 1, Math.Abs(r[3] - r[1]) + 1 };
            count += (Math.Abs(r[2] - r[0]) + 1) * (Math.Abs(r[3] - r[1]) + 1);     
        }
        //Console.WriteLine("count = " + count);
    }
    
    public int[] Pick() {
        int r = random.Next(count) + 1;
        int prevKey = 0;
        foreach (var key in map.Keys) {  
            if (key >= r) {
                break;
            }      
            prevKey = key;
        }
        var data = map[prevKey];
        return new [] { data[0] + random.Next(data[2]), data[1] + random.Next(data[3]) };
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(rects);
 * int[] param_1 = obj.Pick();
 */