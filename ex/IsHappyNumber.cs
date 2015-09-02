public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> unhappy = new HashSet<int>();
        while (n != 1) {
            n = DigitSquareSum(n);
            if (unhappy.Contains(n)) return false;
            unhappy.Add(n);
        }        
        return true;
    }

    private int DigitSquareSum(int n) {
        int sum = 0; 

        while (n >= 10) {   // when not a single digit
            int r = n % 10; // r is the right-most digit
            sum += r * r;   // r^2 and add it to the sum
            n = n / 10;     // shift to the left
        } 
        sum += n * n;       // when a single digit
        return sum;
    }
}