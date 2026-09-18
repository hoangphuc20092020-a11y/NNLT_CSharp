using System.Runtime.CompilerServices;

namespace MyLib;
public class Person
{
    private int id;
    private String name;
    private int yob;
    private int yod;
    // defualt constructer
    public Person()
    {
        id=0;
        name = "";
        yob = 0;
        yod = 0;
    }
    // copy constructor 
    public Person( Person other)
    {
        this.id = other.id;
        this.name = other.name;
        this.yob = other.yob;
        this.yod = other.yod;
    }
    public void Input()
    {
        Console.Write("enter id: ");
        id = int.Parse(Console.ReadLine()!);

        Console.Write("enter name: ");
        name = Console.ReadLine()!;

        Console.Write("enter year of birth: ");
        yob = int.Parse(Console.ReadLine()!);

        Console.Write("enter year of death: ");
        yod = int.Parse(Console.ReadLine()!);

    }
    public void Output()
    {
        Console.WriteLine($"id:{id}, name:{name}, yob:{yob}, yod:{yod}");
    }
    public bool IsLiving()
    {
        return yod == 0; // yod == 0 -> True -> còn sống
    }

}