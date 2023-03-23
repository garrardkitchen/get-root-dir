using System.Reflection;

class Program {
    static void Main(string[] args) {
        string? path = String.Empty;

        if (args.Length > 0) {
            path = Path.GetDirectoryName(args[0]);
        } else {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);        
        }

        Console.WriteLine(path);
    }
}
