namespace Day13PracticeProblem
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Wlcome To Day 13 Practice Problem");
            int firstnum = 55, secondnum = 90, thirdnum = 155;
            double firstnum1 = 5.5, secondnum1 = 88.5, thirdnum1 = 10.5;
            string firstnum2 = "Apple", secondnum2 = "Peach", thirdnum2 = "Banana";

            int num = GenericMax<int>.Maxnum(firstnum, secondnum, thirdnum);
            double num1 = maxfloat<double>.Maxnum(firstnum1, secondnum1, thirdnum1);
            string num2 = maxstring<string>.Maxnum(firstnum2, secondnum2, thirdnum2);

            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);

        }
    }
}