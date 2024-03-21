public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        int n = nums.Length;
        var list = new List<int[]>();

        if (n == 3 && (nums[0] + nums[1] + nums[2]) == 0) {
            list.Add(nums);
            return list.ToArray();
        }

        Array.Sort(nums);
        int i = 0, j = 0, k = 0, target = 0;

        while (i < n - 2) {
            // skip dups
            if (i > 0 && nums[i] == nums[i - 1]) {
                i++;
                continue;
            }

            j = i + 1;
            k = n - 1;
            target = -nums[i];

            while (j < k) {
                // skip dups
                if (j > i + 1 && nums[j] == nums[j - 1]) {
                    j++;
                    continue;
                }
                // skip dups
                if (k < n - 1 && nums[k] == nums[k + 1]) {
                    k--;
                    continue;
                }

                var sum = nums[j] + nums[k];
                if (sum == target) {
                    list.Add(new int[3] { nums[i], nums[j], nums[k] });
                }
                if (sum > target) {
                    k--;
                } else {
                    j++;
                }
            }
            i++;
        }
        return list.ToArray();

        /*
        for (var i = 0; i < n - 2; i ++) {
            for (var j = i + 1; j < n - 1; j++) {
                
                for (var k = j + 1; k < n; k++) {
                    if (nums[i] + nums[j] + nums[k] == 0) {
                        var arr = new int[3] { nums[i], nums[j], nums[k] };
                        Array.Sort(arr);
                        var key = arr[0] + "_" + arr[1] + "_" + arr[2];
                        if (!hashset.Contains(key)) {
                            list.Add(arr);
                            hashset.Add(key);
                        }                        
                        //Console.WriteLine($"**** {i}, {j}, {k}");
                    }
                }
            }
        }
        */
    }
}