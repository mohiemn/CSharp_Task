namespace CSharparray
{
    public class Q5
    {

        public static void DisplayArray()
        {
            Console.WriteLine("Q5========================================");
            int [] arr = new int[10];
            Console.WriteLine("Enter your element of array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("element - [" + i + "] : ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr[i] = element;
                }
            }
            Console.WriteLine("elements in array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("element in index [" + i + "] : " + arr[i]);
            }
        }
    }
}