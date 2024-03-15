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
    public TreeNode DeleteNode(TreeNode root, int key) {
        
        //Insert(root, 10);

        //var list = new List<TreeNode>();
        root = DeleteTreeNode(root, key);                     

        /*int height = GetHeight(root);
        Console.WriteLine($"tree height = {height}");

        for (int level = 1; level <= height; level++) {
            NodesAtLevel(root, level, list);
            Console.WriteLine($"at level {level}: " + OutputTreeNodeList(list));
            list.Clear();
        }

        InorderTraversal(root, list);
        Console.WriteLine("Inorder: " + OutputTreeNodeList(list));
        list.Clear();

        PreorderTraversal(root, list);
        Console.WriteLine("Preorder: " + OutputTreeNodeList(list));
        list.Clear();

        PostorderTraversal(root, list);
        Console.WriteLine("Postorder: " + OutputTreeNodeList(list));  
        list.Clear();
        */
        return root;
    }

    string OutputTreeNodeList(List<TreeNode> list) {
        var sb = new StringBuilder();
        foreach (var tn in list) {
            sb.Append(tn.val);
            sb.Append(", ");
        }
        if (sb.Length > 0) sb.Length -= 2;
        return sb.ToString();
    }

    TreeNode Search(TreeNode node, int key) {
        if (node == null) return null;
        if (node.val == key) return node;
        if (key > node.val) return Search(node.right, key);
        return Search(node.left, key);
    }

    void InorderTraversal(TreeNode root, List<TreeNode> output) {
        if (root != null) {
            InorderTraversal(root.left, output);
            output.Add(root);
            InorderTraversal(root.right, output);
        }
    }

    void PreorderTraversal(TreeNode root, List<TreeNode> output) {
        if (root != null) {
            output.Add(root);
            PreorderTraversal(root.left, output);            
            PreorderTraversal(root.right, output);
        }
    }

    void PostorderTraversal(TreeNode root, List<TreeNode> output) {
        if (root != null) {
            PostorderTraversal(root.left, output);            
            PostorderTraversal(root.right, output);
            output.Add(root);
        }
    }

    int GetHeight(TreeNode root) {
        if (root == null) return 0;
        return Math.Max(GetHeight(root.left) + 1, GetHeight(root.right) + 1);
    }

    void NodesAtLevel(TreeNode root, int level, List<TreeNode> output) {
        if (root == null) return;
        if (level == 1) {
            output.Add(root);
        } else if (level > 1) {
            NodesAtLevel(root.left, level - 1, output);
            NodesAtLevel(root.right, level - 1, output);
        }
    }

    TreeNode DeleteTreeNode(TreeNode root, int key) {
        if (root == null) return root;
        if (root.val < key) {
            root.right = DeleteTreeNode(root.right, key);
            return root;
        } else if (root.val > key) {
            root.left =  DeleteTreeNode(root.left, key);
            return root;
        }

        if (root.left == null) {
            var temp = root.right;
            root = null;
            return temp;
        } else if (root.right == null) {
            var temp = root.left;
            root = null;
            return temp;
        } else { 
            var succParent = root; 
            // search for inorder successor
            var r = root.right;
            while (r.left != null) {
                succParent = r;
                r = r.left;
            }
 
            if (succParent != root)
                succParent.left = r.right;
            else
                succParent.right = r.right;
 
            // Copy 
            root.val = r.val;
 
            // Delete Successor and return root
            r = null;
            return root;
        }
    }

    TreeNode Insert(TreeNode node, int val) {
        if (node == null) {
            return new TreeNode(val);
        }
        if (val < node.val) {
            node.left = Insert(node.left, val);
        } else if (val > node.val) {
            node.right = Insert(node.right, val);
        }
        return node;
    }
}