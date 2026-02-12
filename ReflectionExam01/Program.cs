using System.Reflection;

namespace ReflectionExam01
{
  internal class Program
  {
    static void Main(string[] args)
    {
      AppDomain currencDomain = AppDomain.CurrentDomain;
      Console.WriteLine($"currencDomain : {currencDomain.FriendlyName}");
      foreach (Assembly asm in currencDomain.GetAssemblies())
      {
        Console.WriteLine($"Assembly : {asm.GetName().Name}");
      }
    }
  }
}
