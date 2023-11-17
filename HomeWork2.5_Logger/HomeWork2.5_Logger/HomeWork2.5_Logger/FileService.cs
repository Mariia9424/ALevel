namespace HomeWork2._5_Logger
{
    public class FileService
    {
        public static void CleanUpOldFiles(string directory)
        {
            DirectoryInfo di = new DirectoryInfo(directory);
            FileInfo[] files = di.GetFiles("*.json");

            if (files.Length > 3)
            {
                Array.Sort(files, (x, y) => DateTime.Compare(x.CreationTime, y.CreationTime));
                for (int i = 0; i < files.Length - 3; i++)
                {
                    files[i].Delete();
                }
            }
        }
    }

}