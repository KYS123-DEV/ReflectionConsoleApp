using System.Reflection;

namespace ReflectionExam05
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      AppDomain currencDomain = AppDomain.CurrentDomain;
      foreach (Assembly asm in currencDomain.GetAssemblies())
      {
        Console.WriteLine($"asm.FullName : {asm.FullName}");
        foreach (Type type in asm.GetTypes())
        {
          Console.WriteLine($"type.FullName : {type.FullName}");

          foreach (ConstructorInfo ctorInfo in type.GetConstructors())
          {
            Console.WriteLine($"ctorInfo : {ctorInfo.Name}");
          }

          foreach (EventInfo eventInfo in type.GetEvents())
          {
            Console.WriteLine($"eventInfo : {eventInfo.Name}");
          }

          foreach (FieldInfo fieldInfo in type.GetFields())
          {
            Console.WriteLine($"fieldInfo : {fieldInfo.Name}");
          }

          foreach (MethodInfo methodInfo in type.GetMethods())
          {
            Console.WriteLine($"methodInfo : {methodInfo.Name}");
          }

          foreach (PropertyInfo propertyInfo in type.GetProperties())
          {
            Console.WriteLine($"propertyInfo : {propertyInfo.Name}");
          }
        }
      }
    }
  }
}