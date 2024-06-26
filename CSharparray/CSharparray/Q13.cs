namespace CSharparray
{
    public class Q13
    {

        public static void Houres()
        {
            Console.WriteLine("Q13========================================");
             
            Console.Write("Minutes : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int totminutes = m % 60;
            int tothours = m / 60;
            Console.Write(tothours + " Hours, " +totminutes + " Minutes");
        }
    }
}