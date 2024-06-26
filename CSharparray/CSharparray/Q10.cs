namespace CSharparray
{
    public class Q10
    {

        public static void MaxNumber()
        {
            Console.WriteLine("Q10========================================");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element in [" + i + "] : ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr[i] = element;
                }
            }
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("The max element in array is : " + max);

        }
    }
}