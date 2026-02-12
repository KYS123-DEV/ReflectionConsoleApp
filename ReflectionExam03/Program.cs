using System.Reflection;

namespace ReflectionExam03
{
  internal class Program
  {
    static void Main(string[] args)
    {
      AppDomain currencDomain = AppDomain.CurrentDomain;
      foreach (Assembly asm in currencDomain.GetAssemblies()) {
        Console.WriteLine($"asm.FullName : {asm.FullName}");

        foreach (Type type in asm.GetTypes())
        {
          Console.WriteLine($"type.FullName : {type.FullName}");
        }
      }
    }
  }
}
