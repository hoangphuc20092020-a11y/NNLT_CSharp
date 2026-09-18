using MyLib;
namespace Bai1_3;
class Program
{
    static void Main()
    {
        Person p = new Person();
        Console.WriteLine("enter Person: ");
        p.Input();
        Console.WriteLine("\nOutPut: ");
        p.Output();
        Console.WriteLine("\nIs living: "+ p.IsLiving());
        // test copy constructor
        Person p2 =  new Person(p);
        Console.WriteLine("\nPerson copied: ");
        p2.Output();
    }
}