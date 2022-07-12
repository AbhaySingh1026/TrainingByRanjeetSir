namespace Assessment
{
    public class MethodOverloading
    {
        public void Sum(int num1, int num2)
        {
            Console.WriteLine($"Inside Sum method which takes 2 parameters, and the sum is - {num1 + num2}");
        }
        public void Sum(int num1, int num2, int num3)
        {
            Console.WriteLine($"Inside Sum method which takes 3 parameters, and the sum is - {num1 + num2 + num3}");
        }
    }
}
