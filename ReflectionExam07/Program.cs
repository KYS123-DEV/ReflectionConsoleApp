namespace ReflectionExam07
{
  [PluginAttribute]
  public class SystemInfo
  {
    bool _is64Bit { get; }
    public SystemInfo()
    {
      _is64Bit = Environment.Is64BitOperatingSystem;
      Console.WriteLine("This PC is {0}bits.", _is64Bit ? "64" : "32");
    }
  }

  [StartupAttribute]
  internal class Program
  {
    static void Main(string[] args)
    {
      SystemInfo systemInfo = new SystemInfo();
    }
  }

  public class PluginAttribute : Attribute
  {
  }

  public class StartupAttribute : Attribute
  {
  }
}