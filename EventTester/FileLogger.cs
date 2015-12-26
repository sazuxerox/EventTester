using System.IO;

namespace EventTester
{
    public class FileLogger
    {
        private FileStream fileStream;
        private StreamWriter streamWriter;

        //constructor
        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter =new StreamWriter(fileStream);
        }

        // Member Function which is used in the Delegate
        public void Logger(string s)
        {
            streamWriter.WriteLine(s);
        }

        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }
}
