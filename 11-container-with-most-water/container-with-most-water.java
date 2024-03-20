class Solution {
    public int maxArea(int[] height) {
        int max = 0, n = height.length, i = 0, j = n - 1;
        while (j > i) {
            int lh = height[i], rh = height[j], cmax = (j - i) * Math.min(lh, rh);
            if (cmax > max) max = cmax;
            else if (lh <= rh) i++;
            else j--;
        }
        return max;
    }
}