namespace CSharparray
{
    public class Q11
    {

        public static void Miles()
        {
            Console.WriteLine("Q11========================================");
            Console.Write("kilometers per hour : ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double ans = a1 * 0.621371;
            Console.Write(ans + " miles per hour");
        }
    }
}