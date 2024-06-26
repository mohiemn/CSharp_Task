namespace CSharparray
{
    public class Q14
    {

        public static void Len()
        {
            Console.WriteLine("Q14========================================");
            string[] strarr = new string[5];
            for(int i = 0; i < 5; i++)
            {
                strarr[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
               Console.WriteLine("The length of : " + strarr[i] + " is = " + strarr[i].Length); 
            }

        }
    }
}