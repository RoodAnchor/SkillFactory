using Microsoft.VisualBasic.FileIO;

namespace FileSystemBasics
{
    internal class Program
    {
        static void Main(String[] args)
        {
            DirectoryInfo testDirectory = 
                new DirectoryInfo(
                    $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\TestDirectory"
                );

            try
            {
                if (!testDirectory.Exists)
                    testDirectory.Create();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DeleteFolder(String folderPath)
        {
            DirectoryInfo folderToDelete = new DirectoryInfo(folderPath);

            if (folderToDelete.Exists ) 
            {
                FileSystem.DeleteDirectory(folderPath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
            }
        }
    }
}