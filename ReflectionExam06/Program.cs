namespace ReflectionExam06
{
  public class SystemInfo
  {
    bool _is64Bit;
    public SystemInfo()
    {
      _is64Bit = Environment.Is64BitOperatingSystem;
      Console.WriteLine("This PC is {0}bits", _is64Bit ? "64" : "32");
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      SystemInfo sysInfo = new ();
      Type? SystemInfoType = Type.GetType("ReflectionExam06.SystemInfo");
      object objInstance = Activator.CreateInstance(SystemInfoType);
    }
  }
}
