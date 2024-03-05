public class Solution {
    public int RemoveDuplicates(int[] nums) {        
        if (nums.Length <= 2) return nums.Length;        
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            //Console.WriteLine("----------------");            
            //Console.WriteLine("index: " + index + ", i: " + i);            
            if (index - 2 >= 0 && nums[index - 2] == nums[i]) {
                //Console.WriteLine("index: " + nums[index - 2] + " == " + nums[i]);
                continue;
            }
            //Console.WriteLine("place in " + index + " instead of " + nums[index] + " -> " + nums[i]);
            if (nums[index] != nums[i])
                nums[index] = nums[i];            
            //Console.WriteLine(String.Join(", ", nums));
            index++;            
        }
        return index;
    }
}