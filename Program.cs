// See https://aka.ms/new-console-template for more information
namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int x;
            int i;
            int sum = 0;
            bool yes = true;
            bool no = false;
            Console.WriteLine("enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = num; num != 0; num = num / 10)
            {
                x = num % 10;
                sum = sum * 10 + x;
            }
            Console.Write($"is {i} a palindrome? ", i);
            if (i == sum)
            {
                Console.WriteLine(yes);
            }
            else
            {

                Console.WriteLine(no);
            }

        }
    }
}
