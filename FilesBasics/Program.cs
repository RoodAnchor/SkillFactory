using System.Runtime.CompilerServices;
using System.Text;

namespace FilesBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSelf();
            Console.ReadLine();
        }

        static void PrintSelf([CallerFilePath] String sourceCodeFilePath = "")
        {
            StringBuilder stringBuilder = new StringBuilder();

            using(StreamReader sr = File.OpenText(sourceCodeFilePath))
            {
                String line;

                while( (line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    stringBuilder.AppendLine(line);
                }
            }

            FileInfo fileInfo = new FileInfo(sourceCodeFilePath);

            if (!stringBuilder.ToString().Contains("Last run"))
            {
                using (StreamWriter sw = fileInfo.AppendText())
                {
                    sw.Write($"\r\n//Last run: {DateTime.Now}");
                }
            }
            else
            {
                stringBuilder.Remove(stringBuilder.Length - 13, 13);
                stringBuilder.Append(DateTime.Now);

                using (StreamWriter sw = fileInfo.CreateText())
                {
                    sw.Write(stringBuilder);
                }
            }
        }
    }
}
//Last run: 16.12.2016.12.2016.12.2016.12.2023 18:28:37