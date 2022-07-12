namespace Assessment
{
    interface IMath
    {
        void Addition(int num1, int num2);
    }
    interface IMath1
    {
        void Multiplication(int num1, int num2);
    }
    public class Perform : IMath, IMath1
    {
        public void Addition(int num1, int num2)
        {
            Console.WriteLine($"Inside Addition method derived from Interface IMath, and the output is - {num1 + num2}");
        }
        public void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"Inside multiplication method derived from Interface IMath1, and the output is - {num1 * num2}");
        }
    }
    
}
