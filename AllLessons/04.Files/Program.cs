using System.IO;


namespace _04.Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../input.txt";
            // starts from bin/debug/net6.0
            //@ == r in python

            // StreamReader reader = new StreamReader(path); // open connection
            // string input = reader.ReadToEnd(); // read all
            // Console.WriteLine(input);
            // reader.Close(); // need to close connection or use using

            // using == with in python
            using (StreamReader reader = new StreamReader(path))      
            {
                string line = reader.ReadLine();

                while (line != null) // or while (!reader.EndOfStream)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }

            string outputPath = "../../../output.txt";
            using (StreamWriter writer = new StreamWriter(
                outputPath,
                true        // true == append, false == overwrite
                ))
            {
                writer.WriteLine("Hello");
                writer.WriteLine("World");
            }

            // ------------------- File class -------------------

            string easyRead = File.ReadAllText(path);
            Console.WriteLine(easyRead);

            string[] lines = File.ReadAllLines(path);
            Console.WriteLine(string.Join(Environment.NewLine, lines));

            File.WriteAllText(outputPath, "Hello World");
            File.AppendAllText(outputPath, "Hello World");

            // ------------------- Directory class -------------------

            string dirPath = "../../../dir";
            Directory.CreateDirectory(dirPath);
            Directory.Delete(dirPath, true);  // true == delete recursive

            string[] files = Directory.GetFiles("../../../");
            Console.WriteLine(string.Join(Environment.NewLine, files));

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);     // File Info!
                Console.WriteLine($"{info.Name} - " +
                    $"{info.CreationTime} - " +
                    $"{info.Extension} - " +
                    $"{info.Directory} - " +
                    $"{info.Length}");      // length in bytes
            }

            string[] dirs = Directory.GetDirectories("../../../");
            Console.WriteLine(string.Join(Environment.NewLine, dirs));

            foreach (var dir in dirs)
            {
                DirectoryInfo info = new DirectoryInfo(dir);     // Directory Info!
                Console.WriteLine(info.Parent);
            }

            Directory.Move(dirPath, "../../../dir2");
        }
    }
}