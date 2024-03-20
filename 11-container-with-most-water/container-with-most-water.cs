public class Solution {
    public int MaxArea(int[] height) {
        int max = 0, n = height.Length, i = 0, j = n - 1;
        while (j > i) {
            int lh = height[i], rh = height[j], cmax = (j - i) * Math.Min(lh, rh);
            if (cmax > max) max = cmax;
            else if (lh <= rh) i++;
            else j--;
        }

        /*for (var i = 0; i < n; i++) {
            var lh = height[i];
            for (var j = n - 1; j > i; j--) {
                var h = Math.Min(lh, height[j]);
                var w = j - i;
                var cmax = w * h;
                // if this current max is less than found max then left height is already a minimum one,
                // then we can stop here, because it will not be greater on decreasing width
                if (cmax > max) {
                    max = cmax;
                } else if (lh <= height[j]) {
                    break;
                }
            }
        }*/
        return max;
    }

    /*public int MaxArea1(int[] height) {
        int l = height.Length;
        int max = 0;
        int X = 0;
        int Y = 0;
        int posLeft = 0;
        int posRight = l-1;

        while (posRight > posLeft) {
            int curX = (posRight-posLeft);
            int curY =  Math.Min(height[posRight], height[posLeft]);
            if ((curX <= X && curY <= Y)) {
                    // skip
            } else {
                var s = curX * curY;
                if (s > max) {
                    max = s;
                    X = curX;
                    Y = curY;
                }

            }

            if (height[posLeft] > height[posRight]) {
                posRight--;
            } else  {
                posLeft ++;
            }
        }
        
        return max;
    }*/
}