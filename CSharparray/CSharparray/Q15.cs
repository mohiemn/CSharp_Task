namespace CSharparray
{
    public class Q15
    {

        public static void reverseOdd()
        {
            Console.WriteLine("Q15========================================");
            Console.Write("Enter your string : ");
            string input = Console.ReadLine();
            string[] elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Length % 2 != 0)
                {
                    string str = elements[i];
                    for (int j = str.Length - 1; j >= 0; j--)
                    {
                        Console.Write(str[j]);
                    }
                    Console.Write(" , ");
                }
                else
                {
                    Console.Write(elements[i] + " , ");
                }
            }
        }
    }
}