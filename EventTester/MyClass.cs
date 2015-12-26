namespace EventTester
{
    public class MyClass
    {
        // Define a delegate named LogHandler
        public delegate void LogHandler(string message);

        // Define an Event based on the above Delegate
        public event LogHandler Log;

        public void Process()
        {
            OnLog("Process() Begin");
            OnLog("Process() End");
        }

        //create an OnLog method, to call the event
        protected void OnLog(string message)
        {
            if (Log != null)
            {
                Log(message);
            }
        }
    }
}
