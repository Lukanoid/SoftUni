namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            int numberOfElements = filePath.IndexOf('.') - filePath.LastIndexOf(@"\") - 1;
            string fileName = filePath.Substring(filePath.LastIndexOf(@"\") + 1, numberOfElements);
            string fileExt = filePath.Substring(filePath.IndexOf('.') + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExt}");
        }
    }
}