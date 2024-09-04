namespace Module9.Unit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Произошло исключение");
            exception.Data.Add("Дата создания исключения:", DateTime.Now);
            exception.HelpLink = "www.yandex.ru";
        }
    }
}
