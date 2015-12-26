using System;

/* ========= Subscriber of the Event ============== */
namespace EventTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new FileLogger("process.log");
            var myClass = new MyClass();

            //subscribe the Functions Logger and f1.Logger
            myClass.Log += Logger;
            myClass.Log += f1.Logger;

            //The event will now be triggered in the Process() method
            myClass.Process();
            f1.Close();
        }

        private static void Logger(string s)
        {
            Console.WriteLine(s);
        }
    }
}
