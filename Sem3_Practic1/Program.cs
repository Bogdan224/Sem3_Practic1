namespace Sem3_Practic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<MyFile> myFiles = new List<MyFile>
                {
                    new MyFile("chrome", "exe", 2677.0, "11.11.2011"),
                    new MyFile("chrome.VisualElementsManifest", "xml", 2677.0, "11.11.2011"),
                    new MyFile("chrome_proxy", "exe", 2677.0, "11.11.2011"),
                    new MyFile("master_preferences", "file", 2677.0, "11.11.2011"),
                    new MyFile("128.0.6613.138", "folder", 2677.0, "11.11.2011"),
                    new MyFile("SetupMetrics", "folder", 2677.0, "11.11.2011")
                };
                FileDescriptor fd = new FileDescriptor("C:\\Program Files\\Google\\Chrome\\Application", myFiles);
                //FileDescriptor fd = new FileDescriptor("C:\\Program Files\\Google\\Chrome\\Application", myFiles);
                MainForm.Draw(fd);

            }
        }
    }
}
