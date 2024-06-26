namespace CSharparray
{
    public class Q3
    {

        public static void Displaycars()
        {
            Console.WriteLine("Q3========================================");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for(int i=0;i<cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}