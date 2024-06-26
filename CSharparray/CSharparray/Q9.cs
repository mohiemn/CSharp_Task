namespace CSharparray
{
    public class Q9
    {

        public static void SortingArray()
        {
            Console.WriteLine("Q9========================================");
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element in [" + i + "] : ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr[i] = element;
                }
            }
            int maxele = arr[2];
            int middle = arr[1];
            int minele = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minele)
                {
                    minele = arr[i];
                }
                if (arr[i] > maxele)
                {
                    maxele = arr[i];
                }
                if (middle < minele)
                {
                    middle = arr[i];
                }
                if (middle > maxele)
                {
                    middle = arr[i];
                }
            }
            Console.WriteLine(minele + " "+middle + " "+ maxele);
        }
    }
}