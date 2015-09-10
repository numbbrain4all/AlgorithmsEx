public class Solution {
    
    public int SingleNumberNaive(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach (var n in nums){
            if (!dict.ContainsKey(n)) dict.Add(n, 1);
            else dict[n]++;
        }
        
        foreach (var pair in dict)
            if (pair.Value != 2) return pair.Key;
    
        throw new Exception("Value Not Found");
    }
    
    public int SingleNumberNoExtraSpace(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach (var n in nums){
            if (!dict.ContainsKey(n)) dict.Add(n, 1);
            else dict[n]++;
        }
        
        foreach (var pair in dict)
            if (pair.Value != 2) return pair.Key;
    
        throw new Exception("Value Not Found");
    }
    
}