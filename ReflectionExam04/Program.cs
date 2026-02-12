using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExam01
{
  internal class ReflectionExam04
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

          foreach (MemberInfo memberInfo in type.GetMembers())
          {
            Console.WriteLine($"memberInfo.Name: {memberInfo.Name}");
          }
        }
      }
    }
  }
}