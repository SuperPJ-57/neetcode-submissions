public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> ind = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length;i++)
        {
            var diff = target - nums[i];
            if (ind.ContainsKey(diff))
            {
                return new int[]{ind[diff], i};
            }
            ind[nums[i]] = i;
        }
        return null;
    }
}
