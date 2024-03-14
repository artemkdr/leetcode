/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int[] FindMode(TreeNode root) {
        var map = new Dictionary<int,int>();
        CountNext(root, map);
        var rslt = new List<int>();
        int max = -1;
        foreach (var v in map.Keys) {
            max = Math.Max(max, map[v]);
        }
        foreach (var v in map.Keys) {
            if (map[v] == max) {
                rslt.Add(v);
            }
        }
        return rslt.ToArray();
    }

    public void CountNext(TreeNode node, Dictionary<int,int> map) {
        map[node.val] = map.GetValueOrDefault(node.val, 0) + 1;
        if (node.left != null)
            CountNext(node.left, map);
        if (node.right != null)
            CountNext(node.right, map);
    }
}