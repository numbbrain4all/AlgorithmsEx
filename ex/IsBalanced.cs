class BinaryTree {
    using Nodes;
    
    private int Max(int a, int b) {
        if (a > b) return a;
        else return b;
    }
    
    public bool IsBalancedTopDown(TreeNode cur) {
        if (cur == null) return true;
        return Depth
        
        
    }
    
    public int Depth(TreeNode cur) {
        if (cur == null) return 0;
        return 1 + Max(Depth(cur.Left), Depth(cur.Right));
    }
    
    
}