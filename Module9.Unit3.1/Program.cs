using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Module9.Unit3._1
{
    internal class Program
    {
        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string _row);
        delegate string GreetingsDelegate(string name);
        delegate void NewShowMessageDelegate(string _message);
        delegate int RandomNumberDelegate();

        static int RandomNumber()
        {
            return new Random().Next(0, 100);
        }
        static void ShowMessage()
        {
            Console.WriteLine("Hello World");
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static bool CheckLength(string _row)
        {
            if (_row.Length > 3)
            {
                return true;
            }
            return false;
        }
        public static string Greetings(string name)
        {
            return "Привет " + name + "! Добро пожаловать в SkillFactory";
        }
        static void NewShowMessage(string _message)
        {
            Console.WriteLine(_message);
        }
        static void Main(string[] args)
        {
            //ShowMessageDelegate showMessageDelegate = ShowMessage;
            Action showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            //SumDelegate sumDelegate = Sum;
            Func<int, int, int, int> sumDelegate = Sum;
            int result = sumDelegate(1, 30, 120);
            Console.WriteLine(result);

            //CheckLengthDelegate checkLengthDelegate = CheckLength;
            Predicate<string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate("skill_factory");
            Console.WriteLine(status);

            //GreetingsDelegate gd = new GreetingsDelegate(Program.Greetings);
            //string GreetingsMessage = gd.Invoke("Будущий гуру");
            GreetingsDelegate gd = delegate (string name)
            {
                return "Привет " + name + "! Добро пожаловать в SkillFactory";
            };
            string GreetingsMessage = gd.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);

            //Task 9.3.12
            //NewShowMessageDelegate newShowMessageDelegate = delegate(string message)
            //{
            //    Console.WriteLine(message);
            //};
            NewShowMessageDelegate newShowMessageDelegate = (message) => Console.WriteLine(message);
            newShowMessageDelegate.Invoke("Hello World!");

            //Task 9.3.13
            //RandomNumberDelegate randomNumberDelegate = delegate
            //{
            //    return new Random().Next(0, 100);
            //};
            RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);
            result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
        }
    }
}
