namespace ConsoleApp11
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            int age = GetAge("Hur gammal är du?");
            Console.WriteLine("Din ålder är " + age);
            string city = GetName("city");
            Console.WriteLine("vackert " + city);

        }
        public static string GetName(string quettion)
        {
            while(true)
            {
                Console.WriteLine(quettion);
                string input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("Ogiltigt inmatning");
            }
           
        }
        public static int GetAge(string quettion)
        {
            while(true)
            {
                Console.WriteLine(quettion);
                if(int.TryParse(Console.ReadLine(), out int age))
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Ogiltigt inmatning");
                }
            }
        }
       
   
              
    }
}