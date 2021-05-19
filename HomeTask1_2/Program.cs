using System;
using System.Reflection;

namespace HomeTask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom("UserLibrary");
            Console.WriteLine($"Assembly full name: {assembly.FullName}");
            Console.WriteLine("Types of assembly:");
            foreach(var type in assembly.GetTypes())
            {
                Console.WriteLine(type.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Members of User type:");
            Type myType = assembly.GetType("UserLibrary.User");
            foreach(var member in myType?.GetMembers())
            {
                Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
            }
        }
    }
}
