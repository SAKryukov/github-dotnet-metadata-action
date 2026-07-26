namespace SA;
using Console = System.Console;

static class EntryPoint {

    static void Main() {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Agnostic.AssemblyWrapper wrapper = new(System.Reflection.Assembly.GetEntryAssembly());
        Console.WriteLine($"{wrapper.ProductName} v.{wrapper.AssemblyVersion}");
        Console.Write("Press any key... "); Console.ReadKey(false);
    } //void Main

} //class EntryPoint