namespace Helpers {

    public static class Math {
        public static int Max(int a, int b) {
            return (a > b) ? a : b;
        }
        
        public static int Min(int a, int b) {
            return (a < b) ? a : b;
        }
        
        public static int Abs(int a){
            return (a > 0) ? a : a * -1;
        }
    }

}