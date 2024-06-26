namespace CSharparray
{
    public class Q6
    {

        public static void SummationArray()
        {
            Console.WriteLine("Q6========================================");
            int[] arr = new int[10];
            int sum = 0;
            Console.WriteLine("Enter your element of array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("index - [" + i + "] : ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr[i] = element;
                }
                sum += arr[i];
            }
            Console.WriteLine("Sum of all elements stored in the array is : " + sum);
            
        }
    }
}