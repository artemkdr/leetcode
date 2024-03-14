public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] ans = new int[nums1.Length];
        var map = new Dictionary<int,int>();
        var stack = new Stack<int>();
        foreach (int num in nums2) {
            // it fills the stack until it founds a number greater than the last one in the stack
            // once it's found it memorizes for all the numbers in the stack this greater number
            while (stack.Any() && stack.Peek() < num) {
                map.Add(stack.Pop(), num);
            }
            stack.Push(num);
        }
        for (int i = 0; i < nums1.Length; i++) {
            ans[i] = map.GetValueOrDefault(nums1[i], -1);
        }
        return ans;
    }
}