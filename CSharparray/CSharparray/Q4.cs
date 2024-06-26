namespace CSharparray
{
    public class Q4
    {

        public static void Displayinfo()
        {
            Console.WriteLine("Q4========================================");
            Console.WriteLine("Enter your info : (First name , last name , Birthday)");
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string birthday = Console.ReadLine(); ;
            
            Console.WriteLine(firstname + " "+ lastname + " " + birthday);

        }
    }
}