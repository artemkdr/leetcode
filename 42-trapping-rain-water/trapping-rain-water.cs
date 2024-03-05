public class Solution {
    public int Trap(int[] height) {        
        int n = height.Length, water = 0, wall = -1, canKeepUntil = -1;
        for (var i = 0; i < n; i++) {                
            int h = height[i];            
            if (i == 0 || h >= wall) {
                wall = h;
                //Console.WriteLine($"i = {i}, h = {h}, wall = {wall}");
            } else {
                //Console.WriteLine($"i = {i}, h = {h}, wall = {wall}");
                bool canKeep = canKeepUntil > i;
                int localMax = -1, localMaxIndex = -1, localMinIndex = -1;
                if (canKeepUntil < i) {                    
                    for (var j = i + 1; j < n; j++) {                        
                        if (height[j] > localMax) {
                            localMax = height[j];
                            localMaxIndex = j;
                        }
                        if (height[j] >= wall) {
                            canKeep = true;
                            canKeepUntil = j;
                            break;
                        }
                    }
                }
                if (!canKeep && localMax > h) {
                    wall = localMax;                    
                    canKeepUntil = localMaxIndex;
                    canKeep = true;
                    //Console.WriteLine($"UPDATE LOCAL MAX AND WALL TO {wall}");
                }
                if (canKeep) {                    
                    water += (wall - h);
                    //Console.WriteLine($"add {wall - h} to water => {water}");
                } else {                    
                    wall = h;
                }
            }
        }        
        return water;
    }
}