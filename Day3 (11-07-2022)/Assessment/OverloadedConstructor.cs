namespace Assessment
{
    public class OverloadedConstructor
    {
        public OverloadedConstructor(int num1, int num2)
        {
            Console.WriteLine($"Inside OverloadedConstructor which takes 2 parameters, and the sum is - {num1+num2}");
        }
        public OverloadedConstructor(int num1, int num2, int num3)
        {
            Console.WriteLine($"Inside OverloadedConstructor which takes 3 parameters, and the sum is - {num1 + num2 + num3}");
        }
    }
}
