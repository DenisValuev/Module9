namespace Module9.Unit5
{
    public delegate void Notify();//делегат
    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted;//событие

        public void StartProcess()
        {
            Console.WriteLine("Процесс начат!");
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted;// регистрируем событие
            bl.StartProcess();
        }
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Процесс завершен!");
        }
    }
}
