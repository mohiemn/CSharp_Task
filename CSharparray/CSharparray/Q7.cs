namespace CSharparray
{
    public class Q7
    {

        public static void MinNumber()
        {
            Console.WriteLine("Q7========================================");
            int a1 = Convert.ToInt32(Console.ReadLine()) ;
            int a2 = Convert.ToInt32(Console.ReadLine());
            if (a1 < a2)
            {
                Console.WriteLine("The smallest number is : " + a1);
            }else
            {
                Console.WriteLine("The smallest number is : " + a2);
            }

        }
    }
}