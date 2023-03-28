namespace Overload_Tack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area(2, 3, 4);
            Area1(4, 5);
        }
        public static void Area(int r, int p = 3)
        {
            int S = 0;
            S = p * r * r;
            Console.WriteLine( S);
           
         
        }
        public static void Area1(int a, int b)
        {
            int S = 0;
            S = a * b;  
            Console.WriteLine( S);
           
        }
        public static void Area(int a , int b, int c)
        {
            int S = 0;
            S= 2*(a*b+a*c+b*c);
            Console.WriteLine( S);
            
        }
        public static void Area(int a, int b, int c, int r) 
        {
            int p = 0;
            int S = 0;
            p = (a + b + c) / 2;
            S = p * r;
            Console.WriteLine(p);
            Console.WriteLine(S);
           
        }
       
    }
}