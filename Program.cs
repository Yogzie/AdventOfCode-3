using System.Text.RegularExpressions;

namespace AdventOfCode__3
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string memory = File.OpenText(Environment.CurrentDirectory + "/input.txt").ReadToEnd();
            string testStringMul;
            string testStringDo;
            string testStringDont;

            Regex regExMul = new Regex(@"^mul\([0-9]{1,3},[0-9]{1,3}\).*");

            Regex regExDo = new Regex(@"^do\(\).*");
            Regex regExDont = new Regex(@"^dont\(\).*");

            // Test String
            // xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))
            // Longest an argument can be is 12

            int index = 0;
            int maxLen = 12;
            int total = 0;
            foreach (var c in memory)
            {
                if ((Math.Abs(index - memory.Length)) < maxLen) { maxLen = memory.Length - index; }
                testStringMul = memory.Substring(index, maxLen);

                
                
                if (regExMul.IsMatch(testStringMul))
                {
                    testStringMul = testStringMul.Split(')')[0];
                    int num1;
                    int num2;

                    testStringMul = testStringMul.Split('(')[1];
                    num1 = Convert.ToInt32(testStringMul.Split(',')[0]);
                    num2 = Convert.ToInt32(testStringMul.Split(',')[1]);
                    total = total + (num1 * num2);
                }
                index++;
            }

            Console.WriteLine(total);

        }
    }
}