namespace OOPSelfStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "fatema";
            string PhoneNumber = "1234567890";
            int age = 24;
            Person User = new Person(name,age,PhoneNumber);
            Console.WriteLine("User Sucess addes");
            
        }
    }
}
