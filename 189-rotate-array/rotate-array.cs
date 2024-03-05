public class Solution {
    public void Rotate(int[] nums, int k) {
        RotateUsingList(nums, k);
        //RotatePure(nums, k);
        //RotateRecursion(nums, k);
    }

    public void RotateRecursion(int[] nums, int k) {
        if (k > nums.Length)
            k %= nums.Length;
        if (k > 0 && k != nums.Length) {            
            Move(nums, k, 0, nums[0]);            
        }
    }

    HashSet<int> done = new HashSet<int>();
    int iterations = 0;

    public void Move(int[] nums, int k, int current, int value) {
        
        int newIndex = current + k;
        if (newIndex >= nums.Length)
            newIndex -= nums.Length;
        
        if (done.Count == nums.Length || iterations++ > 2 * nums.Length) return;        
        if (done.Contains(newIndex)) {
            Move(nums, k, current + 1, nums[current + 1]);
            return;
        }        
        int prev = nums[newIndex];
        nums[newIndex] = value;
        done.Add(newIndex);
        //Console.WriteLine("**** replacing " + newIndex + " with the value " + value + ", iterations: " + iterations);
        Move(nums, k, newIndex, prev);
    }

    public void RotatePure(int[] nums, int k) {
        if (k > nums.Length)
            k %= nums.Length;
        if (k > 0 && k != nums.Length) {
            Dictionary<int,int> map = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++) {
                int newIndex = i + k;
                if (newIndex >= nums.Length)
                    newIndex -= nums.Length;
                map[newIndex] = nums[newIndex];
                nums[newIndex] = map.ContainsKey(i) ? map[i] : nums[i];
            }
        }
    }

    public void RotateUsingList(int[] nums, int k) {
        if (k > nums.Length)
            k %= nums.Length;
        if (k > 0 && k != nums.Length) {            
            List<int> list = new List<int>(nums);
            list = list.GetRange(nums.Length - k, k).Concat(list.GetRange(0, nums.Length - k)).ToList();
            for (int i = 0; i < list.Count; i++)
                nums[i] = list[i];
        }
    }
}