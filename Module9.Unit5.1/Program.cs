namespace Module9.Unit5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += ShowNumber;
            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены некорректные значение"); ;
                }
            }
        }

        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("Введено значение: 1"); break;
                case 2: Console.WriteLine("Введено значение: 2"); break;
            }
        }
    }
    class NumberReader
    {
        public delegate void NumberReaderDelegate(int value);
        public event NumberReaderDelegate NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Необходимо ввести значение: либо 1, либо 2");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent.Invoke(number);
        }
    }
}
