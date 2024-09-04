namespace Module9.Unit2
{
    internal class Program
    {
        static int Division(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            //try
            //{
            //    int result = Division(7, 0);
            //    Console.WriteLine(result);
            //}
            //catch (Exception e)
            //{
            //    if (e is DivideByZeroException)
            //    {
            //        Console.WriteLine("На ноль делить нельзя!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Произошла непредвиденная ошибка в приложении.");
            //    }
            //}
            //finally
            //{
            //    Console.WriteLine("Блок Finally сработал!");
            //}
            try
            {

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (RankException e)
            { 
                Console.WriteLine(e.GetType);
            }
        }
    }
}
