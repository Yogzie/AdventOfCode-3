namespace AdventOfCode__3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Memory: ");

            string memory = Console.ReadLine();
            string rememberStr = "";

            string regEx = "^[mul](+[0-9,]+)";

            // Test String
            // xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))

            int index = 0;
            foreach (var c in memory)
            {
                
                if (rememberStr == "mul(")
                {
                    Console.WriteLine(c);
                }

                index++;
            }



        }
    }
}