using Module9.Unit3.Models;

namespace Module9.Unit3
{
    
    public class Program
    {
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public delegate int SubtractionDelegate(int a, int b);
        public delegate void ShowDelegate();
        public delegate void ShowDelegateSumAndSub(int a, int b);
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Process();
            SubtractionDelegate subtractionDelegate = Subtraction;
            int result = subtractionDelegate.Invoke(10, 5);
            int newResult = subtractionDelegate(10, 5);
            Console.WriteLine(result);
            Console.WriteLine(newResult);
            ShowDelegate showDelegate = ShowMessage1;
            showDelegate += ShowMessage2;
            showDelegate += ShowMessage3;
            showDelegate += ShowMessage4;
            showDelegate.Invoke();
            Console.WriteLine("Task 9.3.4");
            ShowDelegateSumAndSub showDelegateSumAndSub = ShowSum;
            showDelegateSumAndSub += ShowSub;
            showDelegateSumAndSub.Invoke(5, 6);
            showDelegate -= ShowMessage4;
            showDelegate -= ShowMessage3;
            showDelegate -= ShowMessage2;
            showDelegate.Invoke();
            showDelegateSumAndSub -= ShowSub;
            Console.WriteLine("Task 9.3.5");
            showDelegateSumAndSub.Invoke(4, 10);

            ShowDelegate showDelegate1 = ShowMessage1;
            showDelegate1 += ShowMessage2;
            ShowDelegate showDelegate2 = ShowMessage3;
            showDelegate2 += ShowMessage4;
            ShowDelegate showDelegate3 = showDelegate1 + showDelegate2;
            showDelegate3.Invoke();
        }
        static void ShowMessage1()
        {
            Console.WriteLine("Метод 1");
        }
        static void ShowMessage2()
        {
            Console.WriteLine("Метод 2");
        }
        static void ShowMessage3()
        {
            Console.WriteLine("Метод 3");
        }
        static void ShowMessage4()
        {
            Console.WriteLine("Метод 4");
        }
        static void ShowSum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        static void ShowSub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

    }
}
