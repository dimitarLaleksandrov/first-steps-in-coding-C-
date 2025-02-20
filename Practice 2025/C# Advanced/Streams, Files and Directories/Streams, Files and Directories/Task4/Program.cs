namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            var dir = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in files)
            {
                var info = new FileInfo(file);
                string extension = info.Extension;
                string name = info.Name;
                double size = info.Length;
                if (!dir.Keys.Contains(extension))
                {
                    dir.Add(extension, new Dictionary<string, double>());
                }
                dir[extension].Add(name, size);
            }

            var sortedOutput = dir
                .OrderByDescending(filesCount => filesCount.Value.Keys.Count)
                .ThenBy(extension => extension.Key)
                .ThenBy(size => size.Value.Values); 

            using (StreamWriter writer = new StreamWriter(@"..\..\..\..\report.txt"))
            {
                foreach (var ext in sortedOutput)
                {
                    writer.WriteLine(ext.Key);
                    foreach (var file in ext.Value)
                    {
                        writer.WriteLine("--{0} - {1:F3}kb", file.Key, file.Value / 1024);
                    }
                }
            }

        }
    }
}
