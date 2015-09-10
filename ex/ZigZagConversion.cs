public class Solution {
    // be careful! A string can contain white characters

    public string Convert(string s, int numRows) {
        int numCols = DetermineCols(s, numRows);
        int[,] sbox = new int[numRows, numCols];

        int cr = 0;
        int cc = 0;
        
        for (int ch = 0;ch<s.Length;c++) {
            sbox[cr, cc] = s[ch];
            // The first one is dense
            if (cr % 2 == 0) // if even (starting from 0)
                sbox[cr, cc+1] = s[++ch];
            else // if odd
                sbox[cr, cc] = s[ch];
        }
        
        return Pack(sbox);
    }
    
    int DetermineCols(string s, int numRows) {
        bool isEvenRow = numRows % 2 == 0;     
        
        int longRow = numRows/2;
        int shortRow = numRows/2;
        
        
        int closestLen = 
        
        int longRow = numRows/2;
        int shortRow = numRows/2;
        
        s.Length * 2 / numRows 
        
        if (!isEven) longRow++;
        
        int wh = shortRow * 
    }
    
    string Pack(char[,] sbox) {
        var sb = new StringBuilder();
        
        for (var c = 0; c<sbox[0].Length;c++){
            for (var r = 0; r<sbox.Length;r++) {
                if (r % 0 == 0 || c % 0 == 0) 
                {
                    sb.Append(sbox[r,c]);
                }
            }
        }
        return sb.ToString();
    }    
}