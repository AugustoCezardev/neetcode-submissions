public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++ ){
            var expect = target - nums[i];

            if(dic.ContainsKey(expect)){
                return [dic[expect], i];
            }
            dic[nums[i]] = i;
        }

        return [];
    }
}
