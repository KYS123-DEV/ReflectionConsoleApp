using System.Reflection;

namespace ReflectionExam02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      AppDomain currencDomain = AppDomain.CurrentDomain;
      foreach (Assembly asm in currencDomain.GetAssemblies())
      {
        Console.WriteLine(" " + asm.FullName);

        Console.WriteLine("===================================================================================");

        foreach (Module module in asm.GetModules())
        {
          Console.WriteLine(" " + module.FullyQualifiedName);
        }

        Console.WriteLine("************************************************************************************");

        foreach (Type type in asm.GetTypes())
        {
          Console.WriteLine(" " + type.FullName);
        }
      }
    }
  }
}
