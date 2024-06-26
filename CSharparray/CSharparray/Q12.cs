namespace CSharparray
{
    public class Q12
    {

        public static void Minutes()
        {
            Console.WriteLine("Q12========================================");
            Console.Write("Hours : ");
            int h = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Minutes : ");
            int m = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(h * 60 + m);
        }
    }
}